using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    // Clase que gestiona la lista de alumnos
    public class AlumnoManager
    {
        private List<Alumno> alumnos; // Lista privada de alumnos

        // Constructor que inicializa la lista de alumnos
        public AlumnoManager()
        {
            alumnos = new List<Alumno>();
        }

        // Método para agregar un alumno a la lista
        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }

        // Método para obtener todos los alumnos
        public List<Alumno> ObtenerAlumnos()
        {
            return alumnos;
        }

        // Método para filtrar alumnos por edad
        public List<Alumno> FiltrarPorEdad(int edad)
        {
            return alumnos.Where(a => a.Edad == edad).ToList();
        }

        // Método para obtener el promedio de edad de todos los alumnos
        public double ObtenerPromedioEdad()
        {
            return alumnos.Average(a => a.Edad);
        }
    }
}