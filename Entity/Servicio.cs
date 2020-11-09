using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Servicio
    {
        public string Comida { get; set; }
        public decimal ValorComida { get; set; }
        public string TipoComida { get; set; }

        public decimal TotalServicios;

        public Servicio(string comida, decimal valorComida, string tipoComida)
        {
            Comida = comida;
            ValorComida = valorComida;
            TipoComida = tipoComida;
           
        }
        public Servicio()
        {
        }
        public decimal CalcularServicio()
        {
            
            if (TipoComida == "Desayuno")
            {
                ValorComida = 2000*30;
                TotalServicios = ValorComida;
            }
            else if(TipoComida == "Almuerzo")
            {
                ValorComida = 4000*30;
                TotalServicios = ValorComida;
            }
            else if (TipoComida == "Cena")
            {
                ValorComida = 3000*30;
                TotalServicios = ValorComida;
            }
            return TotalServicios;

        }
        public override string ToString()
        {
            return $"{Comida};{ValorComida};{TipoComida}";
        }


    }
}
