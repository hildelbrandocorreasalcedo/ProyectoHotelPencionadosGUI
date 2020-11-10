using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Factura
    {
        public Pensionado Pensionado { get; set; }
        public Servicio Servicio { get; set; }
        public Reserva Reserva { get; set; }
        public Habitacion Habitacion { get; set; }
        public DetallesFactura DetallesFactura { get; }

        public decimal CodigoFactura { get; set; }
        public decimal TotalFactura;

        public Factura()
        {
        }
        public Factura(decimal codigoFactura, Pensionado pesionado, Servicio servicio, Reserva reserva, Habitacion habitacion, DetallesFactura detallesFactura)
        {
            CodigoFactura = codigoFactura;
            Pensionado = pesionado;
            Reserva = reserva;
            Servicio = servicio;
            Habitacion = habitacion;
            DetallesFactura = detallesFactura;
        }
         
        public decimal CalcularTotalFactura(DetallesFactura detallesFactura)
        {
            TotalFactura = detallesFactura.MandarDetalle();
            return TotalFactura;
        }
    }
}
