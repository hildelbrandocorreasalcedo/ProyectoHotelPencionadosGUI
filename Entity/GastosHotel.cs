using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class GastosHotel
    {

        public decimal GastosLuz { get; set; }
        public decimal GastosGas { get; set; }
        private decimal GastosAgua { get; set; }

        public decimal TotalGastos;

        public decimal gastosServicios;


        public decimal CalcularGastosHotel(Servicio servicios)
        {

            gastosServicios = servicios.CalcularServicio();
            TotalGastos = gastosServicios + GastosLuz + GastosGas + GastosAgua;

            return TotalGastos;
        }

        public decimal MandarValor()
        {
            return TotalGastos;


        }

    }
}