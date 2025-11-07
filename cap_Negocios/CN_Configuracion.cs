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
    }
}
