using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibFactura;

namespace FacturaForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Producto> productos = new List<Producto>();
            
            List<DetalleFactura> detalleFacturas = new List<DetalleFactura>();
            Categoria indumentaria = new Categoria("Indumentaria", "Ropa femenina", productos);

            Producto producto1 = new Producto("Remera", 2500, 25, detalleFacturas, indumentaria);
            Producto producto2 = new Producto("Pantalon", 1800, 30, detalleFacturas, indumentaria);

            productos.Add(producto1);
            productos.Add(producto2);

            gridProducto.DataSource = productos;

        }
    }
}
