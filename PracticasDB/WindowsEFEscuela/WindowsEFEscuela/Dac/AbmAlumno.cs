using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using WindowsEFEscuela.Data;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela.Dac
{
    public static class AbmAlumno
    {
        private static DBEFEscuela context = new DBEFEscuela();
        public static List<Alumno> TraerTodos()
        {
            return context.Alumnos.ToList();
        }

        public static Alumno TraerUnoById(int id)
        {
            return context.Alumnos.Find(id);

        }

        public static int Insert(Alumno alumno)
        {
            context.Alumnos.Add(alumno);

            return context.SaveChanges();
        }

        public static int Modificar(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            alumnoOrigen.Nombre = alumno.Nombre;
            return context.SaveChanges();
        }

        public static int Eliminar(Alumno alumno)
        {
            Alumno alumnoOrigen = context.Alumnos.Find(alumno.IdAlumno);
            if (alumnoOrigen != null)
            {
                context.Alumnos.Remove(alumnoOrigen);
                return context.SaveChanges();
            }
            return 0;
        }
    }
}
