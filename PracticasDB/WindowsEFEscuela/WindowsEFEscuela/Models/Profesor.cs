using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEFEscuela.Models
{

    [Table("Profesor")]
    public class Profesor
    {
        public int ProfesorId { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es obligatorio. No acepta nulos
        public string Apellido { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es obligatorio. No acepta nulos
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es obligatorio. No acepta nulos
        public string Titulo { get; set; }

        public Profesor(string apellido, string nombre, string titulo)
        {
            Apellido = apellido;
            Nombre = nombre;
            Titulo = titulo;
        }

        public List<Alumno> ListaAlumnos { get; set; }

    }
}
