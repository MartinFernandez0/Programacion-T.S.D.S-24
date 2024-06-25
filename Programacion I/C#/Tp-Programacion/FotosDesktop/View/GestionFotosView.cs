using FotosDesktop.View;
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

namespace FotosDesktop
{
    public partial class GestionFotosView : Form
    {
        FotosMonsterRepository repo = new FotosMonsterRepository();

        public GestionFotosView()
        {
            InitializeComponent();
            CargarFotos();
        }
        private async void CargarFotos()
        {
            dataGridFotosMonsterView.DataSource = await repo.ObtenerFotosMonsterAsync();
        }

        private void btnAgregarFoto_Click(object sender, EventArgs e)
        {
            AgregarEditarFotoView agregarEditarFotoView = new AgregarEditarFotoView();
            agregarEditarFotoView.ShowDialog();
            CargarFotos();
        }

        private void btnSalirFotos_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditarFoto_Click(object sender, EventArgs e)
        {
            //obtener el ID del libro seleccionado
            string? idFotoSeleccionada = (string)dataGridFotosMonsterView.CurrentRow.Cells[0].Value;

            // Instanciar la ventana AgregarEditarLibro y pasarle ese ID a su constructor
            //(Vamos a tener que crear un nuevo constructor en ese formulario que este preparado para recibir al id)
            AgregarEditarFotoView agregarEditarFotoView = new AgregarEditarFotoView(idFotoSeleccionada);

            // Llamamos a la ventana con el metodo showmodal que la pone por encima
            agregarEditarFotoView.ShowDialog();
            CargarFotos();

            //Recargar la grilla
        }
        private async void btnEliminarFoto_Click(object sender, EventArgs e)
        {
            //Obtener el ID del libro Seleccionado y Su numbre:

            string? idFotoSeleccionada = (string)dataGridFotosMonsterView.CurrentRow.Cells[0].Value;
            string? nombreFotoSeleccionada = (string)dataGridFotosMonsterView.CurrentRow.Cells[1].Value;

            //mostramos un messagebox que pregunta "Estas seguro que desea borrarlo"
            DialogResult respuesta = MessageBox.Show
                (
                $"Está seguro que quiere eliminar la foto {nombreFotoSeleccionada}?",
                "Eliminar Libro",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                );

            //si el usuario selecciono "SI" - enviamos a borrar el libro utilizando el ID y la objeto Repo.
            if (respuesta == DialogResult.Yes)
            {
                await repo.EliminarFotosMonsterAsync(idFotoSeleccionada);
                CargarFotos();
            }

        }
    }
}
