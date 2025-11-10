using cap_Entidades;
using cap_Negocios;
using cap_Presentacion.FormAuxiliares;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cap_Presentacion
{
    public partial class Reserva : Form
    {
        private CN_Reserva objetoCN = new CN_Reserva();

        public Reserva()
        {
            InitializeComponent();
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        //Boton para navegar al menu
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
            this.Close();
        }

        private void Reserva_Load(object sender, EventArgs e)
        {

        }
        //Boton para agregar reserva
        private void btnAddReserva_Click(object sender, EventArgs e)
        {
            try
            {
                E_Reserva newReserva = new E_Reserva
                {
                    IdUsuario = int.Parse(txbAddByIdUsuario.Text),
                    IdRecurso = int.Parse(txbAddByIdRecurso.Text),
                    FechaHoraInicio = DateTime.Parse(dtpAddInicio.Text),
                    FechaHoraFin = DateTime.Parse(dtpAddFin.Text),
                    Motivo = cmbAddMotivo.Text

                };
                if (objetoCN.InsertarReserva(newReserva))
                {
                    MessageBox.Show("Reserva Agregda con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar reserva" + ex.Message);
            }
        }

        private void btnListarReservas_Click(object sender, EventArgs e)
        {
            ListReservas listReservasForm = new ListReservas();
            listReservasForm.Show();
        }

        private void btnDeleteReserva_Click(object sender, EventArgs e)
        {
            try
            {
                E_Reserva deleteReserva = new E_Reserva
                {
                    IdReserva = int.Parse(txbDeleteById.Text)
                };
                if (objetoCN.EliminarReserva(deleteReserva))
                {
                    MessageBox.Show("Reserva Eliminada con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar reserva" + ex.Message);
            }
        }

        private void btnUpdateReserva_Click(object sender, EventArgs e)
        {
            try
            {
                E_Reserva updateReserva = new E_Reserva
                {
                    IdReserva = int.Parse(txbUpdateById.Text),
                    IdUsuario = int.Parse(txbUpdateByIdUsuario.Text),
                    IdRecurso = int.Parse(txbUpdateByIdRecurso.Text),
                    FechaHoraInicio = DateTime.Parse(dtpUpdateInicio.Text),
                    FechaHoraFin = DateTime.Parse(dtpUpdateFin.Text),
                    Motivo = cmbUpdateMotivo.Text
                };
                if (objetoCN.ActualizarReserva(updateReserva))
                {
                    MessageBox.Show("Reserva Actualizada con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar reserva" + ex.Message);
            }
        }

        
    }


}
