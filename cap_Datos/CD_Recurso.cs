using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using cap_Entidades;
using Microsoft.Data.SqlClient;

namespace cap_Datos
{
    public class CD_Recurso
    {
        //Metodo para insertar un nuevo recurso
        public bool InsertarRecurso(E_Recurso objRecurso)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Insert_Recurso", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", objRecurso.NombreRecurso);
                        cmd.Parameters.AddWithValue("@capacidad", objRecurso.Capacidad);
                        cmd.Parameters.AddWithValue("@estado", objRecurso.Estado);

                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }catch (Exception ex)
                {
                    throw new Exception("Error al insertar recurso: " + ex.Message);
                }
            }
                return resultado;
        }

        //Metodo para eliminar un recurso existente
        public bool EliminarRecuso(E_Recurso objRecurso)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Delete_Recurso", oconexion))
                    {
                        
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRecurso", objRecurso.IdRecurso);
                        cmd.ExecuteNonQuery();
                        resultado = true;

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar recurso: " + ex.Message);
                }
            }
            return resultado;
        }


        //Metodo para listar los recursos
        public List<E_Recurso> ListarRecursos()
        {
            List<E_Recurso> lista = new List<E_Recurso>();

            string consultaSql = "SELECT idRecurso, nombre, capacidad, estado FROM recurso";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand (consultaSql, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new E_Recurso
                                {
                                    IdRecurso = Convert.ToInt32(dr["idRecurso"]),
                                    NombreRecurso = dr["nombre"].ToString(),
                                    Capacidad = Convert.ToInt32(dr["capacidad"]),
                                    Estado = dr["estado"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al listar recursos: " + ex.Message);
                }
            }
                return lista;
        }
        //Metodo para actualizar recursos
        public bool ActualizarRecurso(E_Recurso objRecurso)
        {
            bool resultado = false;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Update_Recurso", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRecurso", objRecurso.IdRecurso);
                        cmd.Parameters.AddWithValue("@nombre", objRecurso.NombreRecurso);
                        cmd.Parameters.AddWithValue("@capacidad", objRecurso.Capacidad);
                        cmd.Parameters.AddWithValue("@estado", objRecurso.Estado);
                        cmd.ExecuteNonQuery();
                        resultado = true;

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar el recurso" + ex.Message);
                }

                return resultado;
            }
        }
    }
}
