using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key]
        public int Id { get; set; }

        [Required]//no acepta null
        public int Capacidad { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(1)]//long de la cadena
        [Required]//es olbigatorio. No acepta nulos
        public string Codigo { get; set; }
    }
}
