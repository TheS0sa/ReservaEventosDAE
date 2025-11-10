using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cap_Negocios;

namespace cap_Presentacion.FormAuxiliares
{
    public partial class ListConfiguraciones : Form
    {
        // Instancia de la capa de negocios
        CN_Configuracion objetoCN = new CN_Configuracion();


        public ListConfiguraciones()
        {
            InitializeComponent();
        }

        private void listConfiguraccion_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListConfiguraciones_Load(object sender, EventArgs e)
        {
            // Cargar los datos en el DataGridView
            listConfiguraccion.DataSource = objetoCN.ListarConfiguracion();
            listConfiguraccion.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


        }
    }
}
