using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reserva
    {
        
        public Habitacion habitacion;
        public decimal CodigoReserva { get; set; }
        public DateTime FechaDeEntrada { get; set; }
        public string Estado { get; set; }

        public decimal PrecioReserva;

        public Reserva(decimal codigoReserva, DateTime fechaDeEntrada, string estado)
        {
            CodigoReserva = codigoReserva;
            FechaDeEntrada = fechaDeEntrada;
            Estado = estado;
            
        }
        public void PedirHabitacion(Habitacion habitacion)
        {
            this.habitacion = habitacion;
        }
        public decimal CalcularPrecioReserva(Habitacion habitacion)
        {

            PrecioReserva = habitacion.CalcularValorHabitacion();
            
            return PrecioReserva;
        }
    }
}
