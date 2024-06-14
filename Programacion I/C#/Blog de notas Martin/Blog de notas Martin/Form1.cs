namespace Blog_de_notas_Martin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Abriendo un archivo");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void ajusteDeLineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.WordWrap = !textBox1.WordWrap;
        }
    }
}
