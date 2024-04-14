using Alumnos;

namespace AlumnoManagerTests
{
    // Clase que contiene pruebas para la clase AlumnoManager
    public class AlumnoManagerTests
    {
        // Prueba para verificar que se agrega un alumno a la lista correctamente
        [Fact]
        public void AgregarAlumno_DebeAgregarAlumnoALaLista()
        {
            // Arrange
            var manager = new AlumnoManager(); // Se instancia un objeto de AlumnoManager
            var alumno = new Alumno { Nombre = "Juan", Edad = 20, Promedio = 8.5 }; // Se crea un objeto de Alumno

            // Act
            manager.AgregarAlumno(alumno); // Se agrega el alumno a la lista del manager

            // Assert
            Assert.Contains(alumno, manager.ObtenerAlumnos()); // Se verifica que el alumno está en la lista
        }

        // Prueba para verificar que se filtran los alumnos por edad correctamente
        [Fact]
        public void FiltrarPorEdad_DebeDevolverAlumnosConEdadDada()
        {
            // Arrange
            var manager = new AlumnoManager(); // Se instancia un objeto de AlumnoManager
            var alumno1 = new Alumno { Nombre = "Juan", Edad = 20, Promedio = 8.5 }; // Se crean dos objetos de Alumno con diferentes edades
            var alumno2 = new Alumno { Nombre = "Maria", Edad = 22, Promedio = 7.8 };
            manager.AgregarAlumno(alumno1); // Se agregan los alumnos a la lista del manager
            manager.AgregarAlumno(alumno2);

            // Act
            var resultado = manager.FiltrarPorEdad(20); // Se filtran los alumnos con edad 20

            // Assert
            Assert.Single(resultado); // Se verifica que solo hay un alumno en el resultado
            Assert.Contains(alumno1, resultado); // Se verifica que el alumno con edad 20 está en el resultado
        }

        // Prueba para verificar que se calcula correctamente el promedio de edad de los alumnos
        [Fact]
        public void ObtenerPromedioEdad_DebeDevolverPromedioDeEdades()
        {
            // Arrange
            var manager = new AlumnoManager(); // Se instancia un objeto de AlumnoManager
            var alumno1 = new Alumno { Nombre = "Juan", Edad = 20, Promedio = 8.5 }; // Se crean dos objetos de Alumno con diferentes edades
            var alumno2 = new Alumno { Nombre = "Maria", Edad = 22, Promedio = 7.8 };
            manager.AgregarAlumno(alumno1); // Se agregan los alumnos a la lista del manager
            manager.AgregarAlumno(alumno2);

            // Act
            var promedio = manager.ObtenerPromedioEdad(); // Se calcula el promedio de edad de los alumnos

            // Assert
            Assert.Equal(21, promedio); // Se verifica que el promedio es 21
        }
    }
}
   