using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class AdmistradorDueño: Persona
    {
        public DateTime FechaMes { get; set; }

        public decimal TotalIngresosPensionadoHotel;

        public decimal TotalGastosHotel;

        public decimal SalarioAdministrador;

        public GastosHotel GastosHotel;
        private string UserName { get; set; }
        private string Pass { get; set; }

        public AdmistradorDueño(string username, string pass )
        {
            UserName = username;
            Pass = pass;
       
        }


        public AdmistradorDueño(DateTime fechaMes, decimal ingresosPensionados, decimal gastosLuz, decimal gastosGas, decimal gastosAgua)
        {
            FechaMes = fechaMes;
              
        }
        public AdmistradorDueño()
        {
        }
        public decimal CalcularTotalIngresosHotel(IngresosHotel ingresosHotel)
        {
            TotalIngresosPensionadoHotel = ingresosHotel.CalcularIngresosHotel();
            return TotalIngresosPensionadoHotel;

        }
        public decimal CalcularGastosTotalHotel(GastosHotel gastosHotel)
        {
            TotalGastosHotel = gastosHotel.MandarValor();
            return TotalGastosHotel;
        }
        public void CalcularSalarioAdministrador()
        {
            SalarioAdministrador = TotalIngresosPensionadoHotel - TotalGastosHotel;
            
        }

        public override string ToString()
        {
            return $"{FechaMes};{TotalIngresosPensionadoHotel};{TotalGastosHotel};{SalarioAdministrador}";
        }
    }
}

    