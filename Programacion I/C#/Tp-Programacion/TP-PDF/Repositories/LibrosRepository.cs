using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_PDF.Models;

namespace TP_PDF.Repositories
{
    public class LibrosRepository
    {
        string urlApi = "https://ingenieria-2f72.restdb.io/rest/libros";
        HttpClient client = new HttpClient();

        public LibrosRepository()
        {
            //configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "64f8c70e688854d2c40bfe84");
        }
        public async Task<ObservableCollection<Libro>?> ObtenerLibrosAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<Libro>>(response);
        }

        public async Task<Libro?> AgregarAsync(string nombre, string autor, int paginas, string editorial, string sinopsis, string portada_url, string genero)
        {
            //creamos un objeto del tipo Nota con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                autor = autor,
                paginas = paginas,
                editorial = editorial,
                sinopsis = sinopsis,
                portada_url = portada_url,
                genero = genero
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(

                  JsonConvert.SerializeObject(libro),
                  Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlApi, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }
        public async Task<Libro?> ActualizarAsync(string nombre, string autor, int paginas, string editorial, string sinopsis, string portada_url, string genero, string id)
        {
            //creamos un objeto del tipo Libro con los parámetros que llegan
            Libro libro = new Libro()
            {
                nombre = nombre,
                autor = autor,
                editorial = editorial,
                portada_url = portada_url,
                sinopsis = sinopsis,
                paginas = paginas,
                genero = genero
            };

            //enviamos por POST el objeto que creamos a la URL de la API
            var librojson = new StringContent(
                    JsonConvert.SerializeObject(libro),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync(urlApi + "/" + id, librojson);

            //retorna el objeto que se agregó en la API ya con su ID generado por la base de datos
            return JsonConvert.DeserializeObject<Libro>(
                await response.Content.ReadAsStringAsync());
        }
        public async Task<bool> EliminarAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }
        public async Task<Libro?> ObtenerPorIdAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<Libro>(response);
        }
    }
}
