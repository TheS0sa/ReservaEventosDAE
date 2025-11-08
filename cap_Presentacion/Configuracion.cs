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
using cap_Negocios;
using cap_Presentacion.FormAuxiliares;
namespace cap_Presentacion
{
    public partial class Configuracion : Form
    {

        private CN_Configuracion objetoCN = new CN_Configuracion();
        public Configuracion()
        {
            InitializeComponent();
        }


        //Boton para listar las configuraciones 
        private void btnListConfig_Click(object sender, EventArgs e)
        {
            ListConfiguraciones listConfiguraciones = new ListConfiguraciones();
            listConfiguraciones.Show();
        }

        //Boton para agregar una nueva configuracion
        private void btnAddConfig_Click(object sender, EventArgs e)
        {
            try
            {
                E_Configuracion nuevaConfig = new E_Configuracion
                {
                    Clave = txtBoxClave.Text,
                    Valor = txtBoxValor.Text
                };

                if (objetoCN.InsertarConfiguracion(nuevaConfig))
                {
                    MessageBox.Show("Configuración agregada con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar la configuración: " + ex.Message);
            }
        }
        //Boton para eliminar una configuracion existente
        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            try
            {
                E_Configuracion deleteConfig = new E_Configuracion
                {
                    IdConfiguracion = int.Parse(txtBoxDeleteCongbyId.Text)
                };
                if (objetoCN.EliminarConfiguracion(deleteConfig))
                {
                    MessageBox.Show("Configuración eliminada con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar la configuración: " + ex.Message);
            }

        }

        private void btnUpdateConfig_Click(object sender, EventArgs e)
        {
            try
            {
                E_Configuracion updateConfig = new E_Configuracion
                {
                    IdConfiguracion = int.Parse(txtBoxIdConfig.Text),
                    Clave = txtBoxUpdateClave.Text,
                    Valor = txtBoxUpdateValor.Text
                };
                if (objetoCN.ActualizarConfiguracion(updateConfig))
                {
                    MessageBox.Show("Configuración actualizada con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar la configuración: " + ex.Message);
            }
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
