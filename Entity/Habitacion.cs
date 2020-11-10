using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Habitacion
    {
        public decimal NumeroPisoHotel { get; set; }
        public decimal NumeroHabitacionHotel { get; set; }
        public decimal ValorHabitacion { get; set; }
        public string Estado { get; set; }

        public string EstadoHabitacion;

        public Habitacion(decimal numeroPisoHotel, decimal numeroHabitacionHotel, decimal valorHabitacion, string estado)
        {
            NumeroPisoHotel = numeroPisoHotel;
            NumeroHabitacionHotel = numeroHabitacionHotel;
            ValorHabitacion = valorHabitacion;
            Estado = estado;
        }
        public void SacarEstado()
        {

            if (Estado == "disponible")
            {
                EstadoHabitacion = "Habitacion disponible";
            }
            else
            {
                EstadoHabitacion =  "Habitacion ocupada";
            }
        }
            public decimal CalcularValorHabitacion()
        {

            if (NumeroPisoHotel == 1)
            {

                ValorHabitacion = 300000;
            }
            else if (NumeroPisoHotel == 2)
            {

                ValorHabitacion = 350000;
            }
            else if (NumeroPisoHotel == 3)
            {

                ValorHabitacion = 400000;
            }
            return ValorHabitacion;
        }
    }
}
