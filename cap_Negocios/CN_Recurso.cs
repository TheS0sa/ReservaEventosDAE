using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cap_Datos;
using cap_Entidades;

namespace cap_Negocios
{
    public class CN_Recurso
    {
        private CD_Recurso objetoCD_Recurso = new CD_Recurso();

        //Metodo para insertar un nuevo recurso
        public bool InsertarRecurso(E_Recurso objRecurso)
        {
            if (objRecurso == null)
            {
                { throw new ArgumentNullException(nameof(objRecurso), "El objeto de recurso no puede ser nulo."); }
            }
            return objetoCD_Recurso.InsertarRecurso(objRecurso);
        }
        //Metodo para eliminar recurso
        public bool EliminarRecuso(E_Recurso objRecurso)
        {
            if (objRecurso == null)
            {
                { throw new ArgumentNullException(nameof(objRecurso), "El objeto de configuración no puede ser nulo."); }
            }
            if (objRecurso.IdRecurso <= 0)
            {
                throw new Exception("El ID de la configuración debe ser mayor a cero para eliminar.");
            }
            return objetoCD_Recurso.EliminarRecuso(objRecurso);
        }
        //Metodo para listar recurso
        public List<E_Recurso> ListarRecursos()
        {
            return objetoCD_Recurso.ListarRecursos();
        }
        //Metodo para actualizar recurso
        public bool ActualizarRecurso(E_Recurso objRecurso)
        {
            if (objRecurso == null)
            {
                { throw new ArgumentNullException(nameof(objRecurso), "El objeto de recurso no puede ser nulo."); }
            }
            if (objRecurso.IdRecurso <= 0)
            {
                throw new Exception("El ID del recurso debe ser mayor a cero para actualizar.");
            }
            if (string.IsNullOrWhiteSpace(objRecurso.NombreRecurso))
            {
                throw new Exception("El Nombre del recurso no puede estar vacío.");
            }
            if (objRecurso.Capacidad <= 0)
            {
                throw new Exception("La Capacidad del recurso debe ser mayor a cero.");
            }
            if (string.IsNullOrWhiteSpace(objRecurso.Estado))
            {
                throw new Exception("El Estado del recurso no puede estar vacío.");
            }
            return objetoCD_Recurso.ActualizarRecurso(objRecurso);
        }
    }
}
