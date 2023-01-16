using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Models;
using System.Data.Entity;

namespace WindowsEFEscuela.Data
{
    public class DBEFEscuela: DbContext
    {
        //Constructor
        public DBEFEscuela() : base("KeyDB") { }

        
        //PropiedadesDBSET

        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Profesor> Profesores { get; set; }
        public DbSet<Aula> Aulas { get; set; }
        public DbSet<Materia>  Materias { get; set; }
    }
}
