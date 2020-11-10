using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class DetallesFactura
    {
        public Servicio servicio;
        public Reserva reserva;

        decimal precioTotal;

        public decimal CalcularMonto(Servicio servicio, Reserva reserva)
        {

            this.servicio = servicio;
            this.reserva = reserva;

            precioTotal = reserva.PrecioReserva + servicio.CalcularServicio();
            return precioTotal;
        }

        public decimal MandarDetalle()
        {
            return precioTotal;
        }
    }

}
