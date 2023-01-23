using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models
{
    [Table("Clinica")]
    public class Clinica
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "varchar")]//tipo de datos en SQL Server
        [StringLength(50)]//long de la cadena
        [Required]//es olbigatorio. No acepta nulos
        public string Nombre { get; set; }


        public DateTime FechaInicioActividades { get; set; }

        public List<Medico> medicos { get; set; }
        public List<Paciente> paciente { get; set;}
        public List<Habitacion> habitaciones { get;set; }
    }
}
