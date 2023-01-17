using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsEFEscuela.Models
{
    [Table("Alumno")]
    public class Alumno
    {
        [Key]
        public int IdAlumno { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es olbigatorio. No acepta nulos
        public string Nombre { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es olbigatorio. No acepta nulos
        public string Apellido { get; set;}

        public DateTime? FechaNacimiento { get; set; }
        public Alumno()
        {
        }
        public Alumno( string nombre, string apellido, DateTime? fechaNacimiento, Profesor profesor)
        {
            this.profesor= profesor;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }

        public Profesor profesor { get; set; }


    }
}
