using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class DetalleFactura
    {
        public int cantidadProductos { get; set; }
        public Factura factura { get; set; }
        public Producto producto { get; set; }

        public Producto Producto
        {
            get => default;
            set
            {
            }
        }

        public DetalleFactura(int cantidadProductos, Factura factura, Producto producto)
        {
            this.cantidadProductos = cantidadProductos;
            this.factura = factura;
            this.producto = producto;
        }
    }
}
