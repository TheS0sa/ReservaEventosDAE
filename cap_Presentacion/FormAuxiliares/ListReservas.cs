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
    public partial class ListReservas : Form
    {
        private CN_Reserva objetoCN = new CN_Reserva();
        public ListReservas()
        {
            InitializeComponent();
        }

        private void ListReservas_Load(object sender, EventArgs e)
        {
            dgvListarReservas.DataSource = objetoCN.ListarReservas();
            dgvListarReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
