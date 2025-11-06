namespace cap_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Configuracion configForm = new Configuracion();
            configForm.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Usuario usuarioForm = new Usuario();
            usuarioForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Recurso recursoForm = new Recurso();
            recursoForm.ShowDialog();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reserva reservaForm = new Reserva();
            reservaForm.ShowDialog();
            this.Close();
        }
    }
}
