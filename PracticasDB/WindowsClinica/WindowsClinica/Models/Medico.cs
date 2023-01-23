using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models
{
    [Table ("Medico")]
    public class Medico
    {
        [Key]
        public int IdMedico { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Apellido { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }

        public int IdEspecialidad { get; set; }

        public int Matricula { get; set; }
        public DateTime? FechaNacimiento { get; set; }

        public Clinica clinica { get; set; }
        public List<Paciente> pacientes { get; set;}        
        [ForeignKey("IdEspecialidad")]
        public Espcialidad espcialidad { get; set; }
    }
}
