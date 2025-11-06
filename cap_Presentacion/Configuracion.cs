using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cap_Entidades;

namespace cap_Presentacion
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void btnListConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            E_Configuracion e_Configuracion = new E_Configuracion();
            e_Configuracion.Clave = txtBoxClave.Text;
            e_Configuracion.Valor = txtBoxValor.Text;
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {

        }

        private void btnUpdateConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
            this.Close();
        }
    }
}
