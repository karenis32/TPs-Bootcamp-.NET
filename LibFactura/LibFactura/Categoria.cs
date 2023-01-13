using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Categoria
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public List<Producto> ListaProductos { get; set; }

        public Categoria(string nombre, string descripcion, List<Producto> listaProductos)
        {
            Nombre = nombre;
            Descripcion = descripcion;
            ListaProductos = listaProductos;
        }
    }
}
