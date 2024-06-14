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

namespace FotosDesktop.View
{
    public partial class AgregarEditarFotoView : Form
    {
        private string idFotoSeleccionada;
        private FotosMonsterRepository repo = new FotosMonsterRepository();

        public AgregarEditarFotoView()
        {
            InitializeComponent();
        }
        public AgregarEditarFotoView(string idFotoSeleccionada)
        {
            this.idFotoSeleccionada = idFotoSeleccionada;
            InitializeComponent();
            CargarFoto();
        }

        private async void CargarFoto()
        {
            FotoMonster? foto = await repo.ObtenerPorIdFotosMonsterAsync(this.idFotoSeleccionada);

            if (foto != null)
            {
                txtNombreFoto.Text = foto.nombre;
                txtFechaFoto.Text = foto.fecha;
                txtImagenFoto.Text = foto.imagen_url;
                txtAnecdotaFoto.Text = foto.anecdota;
                pictureBox1.ImageLocation = foto.imagen_url;
            }
            else
            {
                MessageBox.Show("ERROR: No se encontro la Fotografia");
            }
        }

        private void btnCancelarFoto_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnGuardarFoto_Click(object sender, EventArgs e)
        {
            if (this.idFotoSeleccionada != null)
            {
                await repo.ActualizarFotosMonsterAsync(

                    txtNombreFoto.Text,
                    txtFechaFoto.Text,
                    txtImagenFoto.Text,
                    txtAnecdotaFoto.Text,
                    this.idFotoSeleccionada);
                this.Close();
            }
            else
            {
                await repo.AgregarFotosMonsterAsync(
                    txtNombreFoto.Text,
                    txtFechaFoto.Text,
                    txtImagenFoto.Text,
                    txtAnecdotaFoto.Text);
                this.Close();
            }
        }
    }
}
