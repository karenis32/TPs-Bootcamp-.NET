using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Factura
    {
        public Cliente cliente { get; set; }
        public Empleado empleado { get; set; }
        public int NroFactura { get; set; }
        public List<DetalleFactura> ListaDetalleFactura { get; set; }

        public DetalleFactura DetalleFactura
        {
            get => default;
            set
            {
            }
        }

        public Empleado Empleado
        {
            get => default;
            set
            {
            }
        }

        public Factura(Cliente cliente, int nroFactura, List<DetalleFactura> listaDetalleFactura, Empleado empleado)
        {
            this.cliente = cliente;
            this.empleado = empleado;
            NroFactura = nroFactura;
            ListaDetalleFactura = listaDetalleFactura;
            
        }
    }
}
