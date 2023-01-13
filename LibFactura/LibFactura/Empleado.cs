using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Empleado : Persona
    {
        public DateTime fechaContratado { get; set; }
        public int Legajo { get; set; }
        public Empleado(string nombre, string apellido, string dNI, int legajo, DateTime fechaContratado) : base(nombre, apellido, dNI)
        {
            Legajo = legajo;
            this.fechaContratado = fechaContratado;
        }
    }
}
