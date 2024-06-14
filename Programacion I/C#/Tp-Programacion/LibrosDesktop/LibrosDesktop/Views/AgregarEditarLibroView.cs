using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PDF.Models;
using TP_PDF.Repositories;

namespace LibrosDesktop.Views
{
    public partial class AgregarEditarLibroView : Form
    {
        private string idLibroSeleccionado;
        private LibrosRepository repo = new LibrosRepository();

        //CONSTRUCTOR que no recibe parametros
        public AgregarEditarLibroView()
        {
            InitializeComponent();
        }
        //Constructor que recibe el ID
        public AgregarEditarLibroView(string idLibroSeleccionado)
        {
            this.idLibroSeleccionado = idLibroSeleccionado;
            InitializeComponent();
            CargarDatosLibroEnPantalla();
        }

        private async void CargarDatosLibroEnPantalla()
        {
            Libro? libro = await repo.ObtenerPorIdAsync(this.idLibroSeleccionado);

            if (libro != null)
            {
                txtNombre.Text = libro.nombre;
                txtAutor.Text = libro.autor;
                numericUpDownPaginas.Value = libro.paginas;
                txtEditorial.Text = libro.editorial;
                txtSinopsis.Text = libro.sinopsis;
                txtPortadaUrl.Text = libro.portada_url;
                txtGenero.Text = libro.genero;
                pictureBoxPortada.ImageLocation = libro.portada_url;
            }
            else
            {
                MessageBox.Show("ERROR: No se encontro el libro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.idLibroSeleccionado != null)
            {
                await repo.ActualizarAsync(

                    txtNombre.Text,
                    txtAutor.Text,
                    (int)numericUpDownPaginas.Value,
                    txtEditorial.Text,
                    txtSinopsis.Text,
                    txtPortadaUrl.Text,
                    txtGenero.Text,
                    this.idLibroSeleccionado);
                this.Close();
            }
            else
            {
                await repo.AgregarAsync(

                    txtNombre.Text,
                    txtAutor.Text,
                    (int)numericUpDownPaginas.Value,
                    txtEditorial.Text,
                    txtSinopsis.Text,
                    txtPortadaUrl.Text,
                    txtGenero.Text);
                this.Close();
            }
        }
    }
}
