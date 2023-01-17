using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEFEscuela.Dac;
using WindowsEFEscuela.Models;

namespace WindowsEFEscuela
{
    public partial class frmAlumno : Form
    {
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void MostrarAlumnos()
        {
            gridAlumnos.DataSource = AbmAlumno.TraerTodos();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor("Ramos", "Sofia", "Profe Ed Fisica");
            Alumno alumno = new Alumno("Flor", "Sanchez", new DateTime(1985,05,05), profesor);

            int filasAfectadas = AbmAlumno.Insert(alumno);

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Ok");
                MostrarAlumnos();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Alumno alumno = AbmAlumno.TraerUnoById(id);
                if (alumno != null)
                {
                    alumno.Nombre = "jorge";
                    int filasAfectadas = AbmAlumno.Modificar(alumno);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ok");
                        MostrarAlumnos();
                    }
                }
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);
                Alumno alumno = AbmAlumno.TraerUnoById(id);
                if (alumno != null)
                {
                    alumno.Nombre = "jorge";
                    int filasAfectadas = AbmAlumno.Eliminar(alumno);

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Ok");
                        MostrarAlumnos();
                    }
                }
            }
        }

        private void btnBuscarID_Click(object sender, EventArgs e)
        {
            if (txtId.Text != "")
            {
                int id = Convert.ToInt32(txtId.Text);

                Alumno alumno = AbmAlumno.TraerUnoById(id);
                MessageBox.Show(alumno.Nombre);
            }
        }
    }
}
