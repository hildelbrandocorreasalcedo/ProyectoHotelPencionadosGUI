using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Pensionado:Persona
    {
       
        public string CarreraUniversitaria { get; set; }

        public Reserva reserva;

        public Pensionado(long identificacion, string nombre, string apellido, int telefono, int fechaNacimiento, string carreraUniversitaria)
        {
            Identificacion = identificacion;
            Nombre = nombre;
            Apellido = apellido;
            Telefono = telefono;
            FechaNacimiento = fechaNacimiento;
            CarreraUniversitaria = carreraUniversitaria;
        }
        public void PedirReserva(Reserva reserva)
        {
            this.reserva = reserva;
        }

    }
}
