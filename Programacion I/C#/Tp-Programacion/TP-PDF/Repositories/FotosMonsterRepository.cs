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
    public class FotosMonsterRepository
    {
        string urlApi = "https://monsterenergy-daf5.restdb.io/rest/fotos";
        HttpClient client = new HttpClient();

        public FotosMonsterRepository()
        {
            // Configuramos que trabajará con respuestas JSON
            client.DefaultRequestHeaders.Add("Accept", "application/json");
            client.DefaultRequestHeaders.Add("apikey", "6660ee1e4fbd54fde1195ff5");
        }

        public async Task<ObservableCollection<FotoMonster>?> ObtenerFotosMonsterAsync()
        {
            var response = await client.GetStringAsync(urlApi);
            return JsonConvert.DeserializeObject<ObservableCollection<FotoMonster>>(response);
        }

        public async Task<FotoMonster?> AgregarFotosMonsterAsync(string nombre, string fecha, string image_url, string anecdota)
        {
            FotoMonster foto = new FotoMonster()
            {
                nombre = nombre,
                fecha = fecha,
                imagen_url = image_url,
                anecdota = anecdota
            };

            var fotojson = new StringContent(
                  JsonConvert.SerializeObject(foto),
                  Encoding.UTF8, "application/json");

            var response = await client.PostAsync(urlApi, fotojson);

            return JsonConvert.DeserializeObject<FotoMonster>(
                await response.Content.ReadAsStringAsync());
        }

        public async Task<bool> EliminarFotosMonsterAsync(string id)
        {
            var response = await client.DeleteAsync(urlApi + "/" + id);
            return response.IsSuccessStatusCode;
        }

        public async Task<FotoMonster?> ObtenerPorIdFotosMonsterAsync(string id)
        {
            var response = await client.GetStringAsync($"{urlApi}/{id}");
            return JsonConvert.DeserializeObject<FotoMonster>(response);
        }

        //CODIGO LIGRO
        //public async Task<Libro?> ObtenerPorIdAsync(string id)
        //{
        //    var response = await client.GetStringAsync($"{urlApi}/{id}");
        //    return JsonConvert.DeserializeObject<Libro>(response);

        public async Task<FotoMonster?> ActualizarFotosMonsterAsync(string nombre, string fecha, string image_url, string anecdota, string id)
        {
            FotoMonster foto = new FotoMonster()
            {
                nombre = nombre,
                fecha = fecha,
                imagen_url = image_url,
                anecdota = anecdota
            };

            var fotojson = new StringContent(
                    JsonConvert.SerializeObject(foto),
                    Encoding.UTF8, "application/json");

            var response = await client.PutAsync (urlApi + "/" + id, fotojson);

            return JsonConvert.DeserializeObject<FotoMonster>(await response.Content.ReadAsStringAsync());
        }
    }

}