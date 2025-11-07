using System;
using System.Collections.Generic;
using Microsoft.Data.SqlClient;
using System.Data;
using cap_Entidades;

namespace cap_Datos
{
    public class CD_Configuracion
    {
        public List<E_Configuracion> ListarConfiguracion()
        {
            List<E_Configuracion> lista = new List<E_Configuracion>();

            // Definimos la consulta SQL DIRECTA
            string consultaSql = "SELECT idConfig, clave, valor FROM configuracion";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();

                    // Se usa la consulta SQL directa en lugar del nombre del stored procedure
                    using (SqlCommand cmd = new SqlCommand(consultaSql, oconexion))
                    {
                        // Se establece el CommandType como Text (sentencia SQL) en lugar de StoredProcedure
                        cmd.CommandType = CommandType.Text;

                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new E_Configuracion
                                {
                                    // Asegúrate de usar el nombre exacto de la columna 'idConfig' de la tabla
                                    // y los nombres 'clave' y 'valor'.
                                    IdConfiguracion = Convert.ToInt32(dr["idConfig"]),
                                    Clave = dr["clave"].ToString(),
                                    Valor = dr["valor"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Se lanza la excepción personalizada para ser capturada en la capa de negocio/presentación
                    throw new Exception("Error al listar configuraciones: " + ex.Message);
                }
            }

            return lista;
        }
    }
}
