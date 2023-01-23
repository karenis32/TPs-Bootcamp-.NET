using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsClinica.Models;
using System.Data.Entity;


namespace WindowsClinica.Data
{
    public class DBClinica: DbContext
    {
        //Constructor
        public DBClinica() : base("KeyDB") { }


        //PropiedadesDBSET

        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Habitacion> Habitaciones { get; set; }
        public DbSet<Medico> Medicos { get; set; }
        public DbSet<Paciente> Pacientees { get; set; }
        public DbSet<Espcialidad> Espcialidades { get;set; }

    }
}
