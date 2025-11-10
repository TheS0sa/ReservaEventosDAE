using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cap_Datos;
using cap_Entidades;

namespace cap_Negocios
{
    public class CN_Usuario
    {
        CD_Usuario objetoCD_Usuario = new CD_Usuario();


        //Metodo para insertar un nuevo usuario
        public bool InsertarUsuario(E_Usuario objUsuario)
        {
            if (objUsuario == null)
            {
                { throw new ArgumentNullException(nameof(objUsuario), "El objeto de Usuario no puede ser nulo."); }
            }
            return objetoCD_Usuario.InsertarRecurso(objUsuario);

        }

        //Metodo para actualizar un usuario existente
        public bool ActualizarUsuario(E_Usuario objUsuario)
        {
            if (objUsuario == null)
            {
                 throw new ArgumentNullException(nameof(objUsuario), "El objeto de Usuario no puede ser nulo."); 
            }
            if (objUsuario.IdUsuario <= 0)
            {
                throw new Exception("El ID del Usuario debe ser mayor a cero para actualizar.");
            }
            if (string.IsNullOrWhiteSpace(objUsuario.Nombre))
            {
                throw new Exception("El Nombre del Usuario no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(objUsuario.Telefono))
            {
                throw new Exception("El Teléfono del Usuario no puede estar vacío.");
            }
            if (string.IsNullOrWhiteSpace(objUsuario.Contraseña))
            {
                throw new Exception("La Contraseña del Usuario no puede estar vacía.");
            }
            return objetoCD_Usuario.ActualizarUsuario(objUsuario);
        }

        //Metodo para eliminar usuario
        public bool EliminarUsuario(E_Usuario objUsuario)
        {
            if (objUsuario == null)
            {
                 throw new ArgumentNullException(nameof(objUsuario), "El objeto de Usuario no puede ser nulo."); 
            }
            if (objUsuario.IdUsuario <= 0)
            {
                throw new Exception("El ID del Usuario debe ser mayor a cero para eliminar.");
            }
            return objetoCD_Usuario.ElimnarUsuario(objUsuario);
        }

        //Metodo para listar usuario
        public List<E_Usuario> ListarUsuario()
        {
            return objetoCD_Usuario.ListarUsuarios();
        }

    }                                           
}
