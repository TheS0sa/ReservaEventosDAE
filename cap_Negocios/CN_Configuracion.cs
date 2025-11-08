using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using cap_Datos;
using cap_Entidades;

namespace cap_Negocios
{
    public class CN_Configuracion
    {
        private CD_Configuracion objetoCD_Configuracion = new CD_Configuracion();

        public List<E_Configuracion> ListarConfiguracion()
        {
            return objetoCD_Configuracion.ListarConfiguracion();
        }

        //Metodo para insertar una nueva configuración
        public bool InsertarConfiguracion(E_Configuracion objConfig)
        {
            if (objConfig == null)
            {
                { throw new ArgumentNullException(nameof(objConfig), "El objeto de configuración no puede ser nulo."); }
            }
            return objetoCD_Configuracion.InsertarConfiguracion(objConfig);
        }

        //Metodo para actualizar una configuración existente
        public bool ActualizarConfiguracion(E_Configuracion objConfig)
        {
            if (objConfig == null)
            {
                { throw new ArgumentNullException(nameof(objConfig), "El objeto de configuración no puede ser nulo."); }
            }

            if (objConfig.IdConfiguracion <= 0)
            {
                throw new Exception("El ID de la configuración debe ser mayor a cero para actualizar.");
            }
            if (string.IsNullOrWhiteSpace(objConfig.Clave))
            {
                throw new Exception("La Clave de configuración no puede estar vacía.");
            }
            if (string.IsNullOrWhiteSpace(objConfig.Valor))
            {
                throw new Exception("El Valor de configuración no puede estar vacío.");
            }
            return objetoCD_Configuracion.ActualizarConfiguracion(objConfig);
        }

        //Metodo para eliminar una configuración existente
        public bool EliminarConfiguracion(E_Configuracion objConfig)
        {
            if (objConfig == null)
            {
                { throw new ArgumentNullException(nameof(objConfig), "El objeto de configuración no puede ser nulo."); }
            }
            if (objConfig.IdConfiguracion <= 0)
            {
                throw new Exception("El ID de la configuración debe ser mayor a cero para eliminar.");
            }
            return objetoCD_Configuracion.EliminarConfiguracion(objConfig);
        }
    }
}
