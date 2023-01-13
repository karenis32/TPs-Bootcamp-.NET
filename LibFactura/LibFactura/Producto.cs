using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Producto
    {
        public string Nombre { get; set; }
        public int Precio { get; set; }
        public int Stock { get; set; }
        public List<DetalleFactura> ListaDetalleFactura { get; set; }
        public Categoria categoria { get; set; }

        public Categoria Categoria
        {
            get => default;
            set
            {
            }
        }

        public Producto(string nombre, int precio, int stock, List<DetalleFactura> listaDetalleFactura, Categoria categoria)
        {
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
            ListaDetalleFactura = listaDetalleFactura;
            this.categoria = categoria;
        }
    }
}
