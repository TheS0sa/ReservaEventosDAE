using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using cap_Datos;

namespace cap_Negocios
{
    public class CN_Reserva
    {
        private CD_Reserva objetoCD_Reserva = new CD_Reserva();

        //Metodo para verificar solapamiento de reservas nuevas
        private bool VerificarSolapamiento(int idRecurso, DateTime inicio, DateTime fin)
        {
            try
            {
                return objetoCD_Reserva.VerificarSolapamiento(idRecurso, inicio, fin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la Capa de Negocios al verificar solapamiento: " + ex.Message, ex);
            }
        }
        //Metodo para verificar solapamiento de reservas a actualizar
        private bool VerificarSolapamientoUpdate(int idReservaAExcluir, int idRecurso, DateTime inicio, DateTime fin)
        {
            try
            {
                return objetoCD_Reserva.VerificarSolapamientoUpdate(idReservaAExcluir, idRecurso, inicio, fin);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en CN al verificar solapamiento para actualización: " + ex.Message, ex);
            }
        }
        //Metodo para insertar reserva
        public bool InsertarReserva(E_Reserva objReserva)
        {
            if (objReserva == null)
            {
                throw new ArgumentNullException(nameof(objReserva), "El objeto de Reserva no puede ser nulo.");
            }
            if (objReserva.IdRecurso <= 0)
            {
                throw new Exception("El ID del Recurso debe ser mayor a cero para insertar una reserva.");
            }
            if (objReserva.IdUsuario <= 0)
            {
                throw new Exception("El ID del Usuario debe ser mayor a cero para insertar una reserva.");
            }
            if (objReserva.FechaHoraInicio >= objReserva.FechaHoraFin)
            {
                throw new Exception("La fecha de inicio debe ser anterior a la fecha de fin.");
            }
            if (VerificarSolapamiento(objReserva.IdRecurso, objReserva.FechaHoraInicio, objReserva.FechaHoraFin))
            {
                throw new Exception("La reserva no se puede insertar debido a un solapamiento con una reserva existente.");
            }

            return objetoCD_Reserva.InsertarReserva(objReserva);
        }

        //Metodo para listar reservas
        public List<E_Reserva> ListarReservas()
        {
            try
            {
                return objetoCD_Reserva.ListarReservas();
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la Capa de Negocios al listar reservas: " + ex.Message, ex);
            }

        }

        //Metodo para eliminar reserva
        public bool EliminarReserva(E_Reserva objReserva)
        {
            if (objReserva == null)
            {
                throw new ArgumentNullException(nameof(objReserva), "El objeto de Reserva no puede ser nulo.");
            }
            if (objReserva.IdReserva <= 0)
            {
                throw new Exception("El ID de la Reserva debe ser mayor a cero para eliminar.");
            }
            return objetoCD_Reserva.EliminarReserva(objReserva);
        }

        //Metodo para actualizar reserva
        public bool ActualizarReserva(E_Reserva objReserva)
        {
            if (objReserva == null)
            {
                throw new ArgumentNullException(nameof(objReserva), "El objeto de Reserva no puede ser nulo.");
            }
            if (objReserva.IdReserva <= 0)
            {
                throw new Exception("El ID de la Reserva debe ser mayor a cero para actualizar.");
            }
            if (objReserva.FechaHoraInicio >= objReserva.FechaHoraFin)
            {
                throw new Exception("La fecha de inicio debe ser anterior a la fecha de fin.");
            }


            if (VerificarSolapamientoUpdate(objReserva.IdReserva, objReserva.IdRecurso, objReserva.FechaHoraInicio, objReserva.FechaHoraFin))
            {
                throw new Exception("La reserva no se puede actualizar debido a un solapamiento con otra reserva existente.");
            }

            return objetoCD_Reserva.ActualizarReserva(objReserva);
        }
    }
}
