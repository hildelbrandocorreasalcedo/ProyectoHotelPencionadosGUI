using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IngresosHotel
    {
        public decimal CantidadPensionados;
        public decimal TotalIngresosHotel;

        public decimal CalcularIngresosHotel()
        {
            TotalIngresosHotel = CantidadPensionados;


            return TotalIngresosHotel;

        }
    }
}
