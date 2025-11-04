using System;

public class E_Reserva
{
        public int IdReserva { get; set; }
        public int IdUsuario { get; set; }
        public int IdRecurso { get; set; }
        public int IdEstado { get; set; }
        public DateOnly FechaInicio { get; set; }
        public DateOnly FechaFin { get; set; }
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFin { get; set; }
        public string Motivo { get; set; }

        // Constructor vacío
        public E_Reserva() { }
}
