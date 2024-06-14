namespace FotosDesktop
{
    public partial class MenuInicioFotosView : Form
    {
        public MenuInicioFotosView()
        {
            InitializeComponent();
        }

        private void btnFotosInicio_Click(object sender, EventArgs e)
        {
            GestionFotosView gestionFotosView = new GestionFotosView();
            gestionFotosView.ShowDialog();
        }
    }
}
