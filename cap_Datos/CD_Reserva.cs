using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cap_Datos
{
    public class CD_Reserva
    {

        // Metodo para verificar solapamiento de reservas
        public bool VerificarSolapamiento(int idRecurso, DateTime inicio, DateTime fin)
        {
            int conflictoCount = 0;

            // Asume que la clase Conexion y la cadena son accesibles
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Verificar_Solapamiento", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // Parámetros de la nueva reserva
                    cmd.Parameters.AddWithValue("@idRecurso", idRecurso);
                    cmd.Parameters.AddWithValue("@NuevoInicio", inicio);
                    cmd.Parameters.AddWithValue("@NuevoFin", fin);

                    try
                    {
                        oconexion.Open();
                        // ExecuteScalar devuelve el primer valor de la primera fila (el COUNT)
                        conflictoCount = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        // Manejo de error de conexión/SQL
                        throw new Exception("Error al verificar solapamiento: " + ex.Message);
                    }
                }
            }
            // Si el conteo es > 0, HAY solapamiento/conflicto.
            return conflictoCount > 0;
        }

        //Metodo para verificar solapamiento de reservas a actualizar
        public bool VerificarSolapamientoUpdate(int idReservaAExcluir, int idRecurso, DateTime inicio, DateTime fin)
        {
            int conflictoCount = 0;

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                // LLAMAMOS AL SP ESPECÍFICO PARA ACTUALIZACIÓN
                using (SqlCommand cmd = new SqlCommand("usp_Verificar_Solapamiento_Update", oconexion))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    // PARÁMETROS: Incluyendo el ID a excluir
                    cmd.Parameters.AddWithValue("@idReservaAExcluir", idReservaAExcluir);
                    cmd.Parameters.AddWithValue("@idRecurso", idRecurso);
                    cmd.Parameters.AddWithValue("@NuevoInicio", inicio);
                    cmd.Parameters.AddWithValue("@NuevoFin", fin);

                    try
                    {
                        oconexion.Open();
                        conflictoCount = (int)cmd.ExecuteScalar();
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al verificar solapamiento para actualización: " + ex.Message);
                    }
                }
            }
            return conflictoCount > 0;
        }

        //Metodo para insertar una nueva reserva
        public bool InsertarReserva(E_Reserva objReserva)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Insert_Reserva", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idRecurso", objReserva.IdRecurso);
                        cmd.Parameters.AddWithValue("@idUsuario", objReserva.IdUsuario);
                        cmd.Parameters.AddWithValue("@fechaHoraInicio", objReserva.FechaHoraInicio);
                        cmd.Parameters.AddWithValue("@fechaHoraFin", objReserva.FechaHoraFin);
                        cmd.Parameters.AddWithValue("@motivo", objReserva.Motivo);
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al insertar reserva: " + ex.Message);
                }
            }
            return resultado;
        }

        //Metodo para listar todas las reservas
        public List<E_Reserva> ListarReservas()
        {
            List<E_Reserva> lista = new List<E_Reserva>();

            // Consulta SQL con INNER JOIN
            string query = @"
        SELECT 
            R.idReserva, 
            R.idUsuario, 
            R.idRecurso, 
            R.fechaHoraInicio, 
            R.fechaHoraFin, 
            R.motivo,
            U.nombre AS NombreUsuario,   -- Traemos el nombre del usuario
            C.nombre AS NombreRecurso    -- Traemos el nombre del recurso
        FROM 
            Reservas R
        INNER JOIN 
            usuario U ON R.idUsuario = U.idUsuario
        INNER JOIN 
            recurso C ON R.idRecurso = C.idRecurso";

            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                using (SqlCommand cmd = new SqlCommand(query, oconexion))
                {
                    cmd.CommandType = CommandType.Text;

                    try
                    {
                        oconexion.Open();
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                lista.Add(new E_Reserva
                                {
                                    IdReserva = Convert.ToInt32(dr["idReserva"]),
                                    IdUsuario = Convert.ToInt32(dr["idUsuario"]),
                                    IdRecurso = Convert.ToInt32(dr["idRecurso"]),

                                    FechaHoraInicio = dr.GetDateTime(dr.GetOrdinal("fechaHoraInicio")),
                                    FechaHoraFin = dr.GetDateTime(dr.GetOrdinal("fechaHoraFin")),

                                    Motivo = dr["motivo"].ToString(),

                                    // Mapeamos las nuevas columnas del JOIN
                                    NombreUsuario = dr["NombreUsuario"].ToString(),
                                    NombreRecurso = dr["NombreRecurso"].ToString()
                                });
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception("Error al listar reservas en la Capa de Datos (JOIN): " + ex.Message);
                    }
                }
            }
            return lista;
        }

        //Metodo para eliminar una reserva existente
        public bool EliminarReserva(E_Reserva objReserva)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Delete_Reserva", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idReserva", objReserva.IdReserva);
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al eliminar reserva: " + ex.Message);
                }
            }
            return resultado;
        }

        //Metodo para actualizar una reserva existente
        public bool ActualizarReserva(E_Reserva objReserva)
        {
            bool resultado = false;
            using (SqlConnection oconexion = new SqlConnection(Conexion.cadena))
            {
                try
                {
                    oconexion.Open();
                    using (SqlCommand cmd = new SqlCommand("usp_Update_Reserva", oconexion))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@idReserva", objReserva.IdReserva);
                        cmd.Parameters.AddWithValue("@idRecurso", objReserva.IdRecurso);
                        cmd.Parameters.AddWithValue("@idUsuario", objReserva.IdUsuario);
                        cmd.Parameters.AddWithValue("@fechaHoraInicio", objReserva.FechaHoraInicio);
                        cmd.Parameters.AddWithValue("@fechaHoraFin", objReserva.FechaHoraFin);
                        cmd.Parameters.AddWithValue("@motivo", objReserva.Motivo);
                        cmd.ExecuteNonQuery();
                        resultado = true;
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al actualizar reserva: " + ex.Message);
                }
            }
            return resultado;
        }
    }

}
