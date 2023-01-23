using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsClinica.Models
{
    [Table ("Especialidad")]
    public class Espcialidad
    {
        [Key]
        public int IdEspecialidad { get; set; }

        [Column(TypeName = "varchar")]
        [StringLength(50)]
        [Required]
        public string Nombre { get; set; }
      
        public List<Medico> ListaMedicos { get; set; }
    }
}
