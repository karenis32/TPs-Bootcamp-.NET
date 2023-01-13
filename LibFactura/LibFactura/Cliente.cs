using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Cliente : Persona
    {
        public Usuario usuario { get; set; }
        public List<Factura> ListaFacturas { get; set; }
        public bool clienteVIP { get; set; }

        public Factura Factura
        {
            get => default;
            set
            {
            }
        }

        public Cliente(string nombre, string apellido, string dNI, Usuario usuario, List<Factura> listaFacturas, bool clienteVIP) : base(nombre, apellido, dNI)
        {
            this.usuario = usuario;
            ListaFacturas = listaFacturas;
            this.clienteVIP = clienteVIP;
        }

    }
}
