namespace cap_Presentacion
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configuracion = new Configuracion();
            configuracion.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario usuario = new Usuario();
            usuario.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recursos recursos = new Recursos();
            recursos.ShowDialog();
            this.Close();
        }
    }
}
