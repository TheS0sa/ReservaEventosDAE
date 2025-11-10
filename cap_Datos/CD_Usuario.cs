using cap_Entidades;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace cap_Datos
{
    public class CD_Usuario
    {
        //Metodo para Insertar Usuario
        public bool InsertarRecurso(E_Usuario objUsuario)
        {
            bool resultado = false;
            using(SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using(SqlCommand cmd = new SqlCommand("usp_Insert_Usuario", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@nombre", objUsuario.Nombre);
                        cmd.Parameters.AddWithValue("@telefono", objUsuario.Telefono);
                        cmd.Parameters.AddWithValue("@contraseña", objUsuario.Contraseña);
                        cmd.ExecuteNonQuery();
                        resultado = true;

                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar usuario: " + ex.Message);
                }
            }
            return resultado;
        }

        //Metodo para actualizar un usuario existente
        public bool ActualizarUsuario(E_Usuario objUsuario)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Update_Usuario", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuario", objUsuario.IdUsuario);
                        cmd.Parameters.AddWithValue("@nombre", objUsuario.Nombre);
                        cmd.Parameters.AddWithValue("@telefono", objUsuario.Telefono);
                        cmd.Parameters.AddWithValue("@contraseña", objUsuario.Contraseña);
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar usuario: " + ex.Message);
                }
            }
            return resultado;
        }

        //Metodo para eliminar un usuario
        public bool ElimnarUsuario(E_Usuario objUsuario)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Delete_Usuario", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idUsuario", objUsuario.IdUsuario);
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al Eliminar usuario: " + ex.Message);
                }
            }
            return resultado;
        }

        //Metodo para listar usuarios
        public List<E_Usuario> ListarUsuarios()
        {
            List<E_Usuario> lista = new List<E_Usuario>();
            string consultaSql = "SELECT idUsuario, nombre, telefono, contraseña FROM usuario";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand(consultaSql, oconexion))
                    {
                        cmd.CommandType = CommandType.Text;
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new E_Usuario
                                {
                                    IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                    Nombre = dr["nombre"].ToString(),
                                    //CorreoElectronico = dr["correo"].ToString(),
                                    Telefono = dr["telefono"].ToString(),
                                    Contraseña = dr["contraseña"].ToString()
                                });
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al Eliminar usuario: " + ex.Message);
                }
            }
            return lista;
        }

    }
}
