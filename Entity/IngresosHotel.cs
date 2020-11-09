using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class IngresosHotel
    {
        
        public decimal ValorPagoPensionado { get; set; }
        public decimal Piso { get; set; }
        public decimal CalcularServicio()
            {

                if (Piso == 1)
                {
                   
                ValorPagoPensionado = 300000;
                }
                else if (Piso == 2)
                {

                ValorPagoPensionado = 350000;
                }
                else if (Piso == 3)
                {
                   
                ValorPagoPensionado = 400000;
                }
                return ValorPagoPensionado;

            }
        
    }
}
