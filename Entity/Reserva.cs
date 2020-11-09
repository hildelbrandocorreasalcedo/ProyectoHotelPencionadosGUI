using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Reserva
    {

        public decimal CodigoRegistro { get; set; }
        public DateTime FechaDeEntrada { get; set; }
        public string Estado { get; set; }
        public decimal Precio { get; set; }

        
        public string PedirReserva(Habitacion habitacion)
        {

            if (habitacion.Estado == "disponible")
            {
                return "Habitacion disponible";
            }
            else
            {
                return "Habitacion ocupada";
            }
        }
    }
}
