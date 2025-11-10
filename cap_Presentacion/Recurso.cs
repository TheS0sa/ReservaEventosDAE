using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using cap_Entidades;
using cap_Negocios;
using cap_Presentacion.FormAuxiliares;


namespace cap_Presentacion
{
    public partial class Recurso : Form
    {
        // Instancia de la capa de negocios
        private CN_Recurso objetoCN = new CN_Recurso();
        public Recurso()
        {
            InitializeComponent();
        }

        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
            this.Close();
        }

        //Boton para Insertar Recursos
        private void btnAddRecurso_Click(object sender, EventArgs e)
        {
            try
            {
                E_Recurso nuevoRecurso = new E_Recurso
                {
                    NombreRecurso = txbAddNombre.Text,
                    Capacidad = (int)txbAddCapacidad.Value,
                    Estado = txbAddEstado.Text
                };

                if (objetoCN.InsertarRecurso(nuevoRecurso))
                {
                    MessageBox.Show("Recurso agregado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el recurso: " + ex.Message);
            }
        }
        //Boton para eliminar un recurso existente
        private void btnDeleteRecurso_Click(object sender, EventArgs e)
        {
            try
            {
                E_Recurso deleteRecurso = new E_Recurso
                {
                    IdRecurso = int.Parse(txbDeleteById.Text)
                };
                if (objetoCN.EliminarRecuso(deleteRecurso))
                {
                    MessageBox.Show("Recurso eliminado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el recurso: " + ex.Message);
            }
        }
        //Boton para listar los recursos existentes
        private void btnListarRecurso_Click(object sender, EventArgs e)
        {
            ListRecursos listRecursos = new ListRecursos();
            listRecursos.Show();
        }

        //Boton para actualizar un recurso existente
        private void btnUpdateRecurso_Click(object sender, EventArgs e)
        {


    //public int IdRecurso { get; set; }
    //    public string NombreRecurso { get; set; }
    //    public int Capacidad { get; set; }
    //    public string Estado { get; set; }

            try
            {
                E_Recurso updateRecurso = new E_Recurso
                {
                    IdRecurso = int.Parse(txbUpdateById.Text),
                    NombreRecurso = txbUpdateNombre.Text,
                    Capacidad = (int)txbUpdateCapacidad.Value,
                    Estado = txbUpdateEstado.Text,
                };
                if (objetoCN.ActualizarRecurso(updateRecurso))
                {
                    MessageBox.Show("Recurso actualizado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el recurso: " + ex.Message);
            }
            
        }
    }
}
