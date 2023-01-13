using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibFactura
{
    public class Usuario
    {
        public int NroUsuario { get; set; }
        public Cliente cliente { get; set; }

        public Cliente Cliente
        {
            get => default;
            set
            {
            }
        }

        public Usuario(int nroUsuario, Cliente cliente)
        {
            NroUsuario = nroUsuario;
            this.cliente = cliente;
        }
    }
}
