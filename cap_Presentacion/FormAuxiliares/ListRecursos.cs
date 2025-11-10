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
    public partial class ListRecursos : Form
    {
        CN_Recurso objetoCN = new CN_Recurso();
        public ListRecursos()
        {
            InitializeComponent();
        }

        private void dgvListRecurso_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListRecursos_Load(object sender, EventArgs e)
        {
            dgvListRecurso.DataSource = objetoCN.ListarRecursos();
            dgvListRecurso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
