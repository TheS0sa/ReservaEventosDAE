using System;

public class E_Reserva
{
    public int IdReserva { get; set; }
    public int IdUsuario { get; set; }
    public int IdRecurso { get; set; }
    public DateTime FechaHoraInicio { get; set; }
    public DateTime FechaHoraFin { get; set; }

    public string NombreUsuario { get; set; }
    public string NombreRecurso { get; set; }

    public string Motivo { get; set; }

    // Constructor vacío
    public E_Reserva() { }
}
