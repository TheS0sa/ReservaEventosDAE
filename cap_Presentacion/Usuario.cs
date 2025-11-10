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
    public partial class Usuario : Form
    {

        private CN_Usuario objetoCN = new CN_Usuario();
        public Usuario()
        {
            InitializeComponent();
        }
        //Boton para navegar al menu
        private void btnGoHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 homeForm = new Form1();
            homeForm.ShowDialog();
            this.Close();
        }

        private void Usuario_Load(object sender, EventArgs e)
        {

        }

        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                E_Usuario newUsuario = new E_Usuario
                {
                    Nombre = txbAddNombre.Text,
                    Telefono = txbAddTelefono.Text,
                    Contraseña = txbAddContrasenia.Text
                };

                if (objetoCN.InsertarUsuario(newUsuario))
                {
                    MessageBox.Show("Usuario Agregdo con exito");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar usuario" + ex.Message);
            }

        }

        private void btnUpdateUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                E_Usuario updatedUsuario = new E_Usuario
                {
                    IdUsuario = int.Parse(txbUpdateById.Text),
                    Nombre = txbUpdateNombre.Text,
                    Telefono = txbUpdateTelefono.Text,
                    Contraseña = txbUpdateContrasenia.Text
                };
                if (objetoCN.ActualizarUsuario(updatedUsuario))
                {
                    MessageBox.Show("Usuario actualizado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message);
            }
        }

        private void btnDeleteUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                E_Usuario deleteUsuario = new E_Usuario
                {
                    IdUsuario = int.Parse(txbDeleteById.Text)
                };
                if (objetoCN.EliminarUsuario(deleteUsuario))
                {
                    MessageBox.Show("Usuario eliminado con éxito.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el usuario: " + ex.Message);
            }
        }

        private void btnListarUsuario_Click(object sender, EventArgs e)
        {
            ListUsuarios listUsuarios = new ListUsuarios();
            listUsuarios.Show();
        }
    }
}
