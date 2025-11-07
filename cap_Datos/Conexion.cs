using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace cap_Datos
{
    public class Conexion
    {
        public static string cadena = ConfigurationManager.ConnectionStrings["CadenaConexion"]?.ToString()
    ?? throw new Exception("Cadena de conexión 'CadenaConexion' no encontrada en App.config.");
    }
}
