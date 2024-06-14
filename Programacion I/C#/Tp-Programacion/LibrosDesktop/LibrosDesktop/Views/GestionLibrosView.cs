using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_PDF.Repositories;

namespace LibrosDesktop.Views
{
    public partial class GestionLibrosView : Form
    {
        LibrosRepository repo = new LibrosRepository();
        public GestionLibrosView()
        {
            InitializeComponent();
            CargarLibrosALaGrilla();
        }

        private async void CargarLibrosALaGrilla()
        {
            dataGridLibros.DataSource = await repo.ObtenerLibrosAsync();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView();
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();
        }

        // DELETE
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            //Obtener el ID del libro Seleccionado y Su numbre:

            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;
            string? nombreLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar el libro {nombreLibroSeleccionado}?",
                "Eliminar Libro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el libro utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarAsync(idLibroSeleccionado);
                CargarLibrosALaGrilla();
            }
        }

        //UPDATE
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //obtener el ID del libro seleccionado
            string? idLibroSeleccionado = (string)dataGridLibros.CurrentRow.Cells[0].Value;

            // Instanciar la ventana AgregarEditarLibro y pasarle ese ID a su constructor
            //(Vamos a tener que crear un nuevo constructor en ese formulario que este preparado para recibir al id)
            AgregarEditarLibroView agregarEditarLibroView = new AgregarEditarLibroView(idLibroSeleccionado);

            // Llamamos a la ventana con el metodo showmodal que la pone por encima
            agregarEditarLibroView.ShowDialog();
            CargarLibrosALaGrilla();

            //Recargar la grilla

        }
    }
}
