using Xunit;
using LosEstudiantesSalados;

namespace TestSchool
{
    public class Validar
    {
        [Fact]
        public void Test_Asignar_Asignaturas()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("IDS306", "Construcción de Software", 4);
            Profesor profesor = new Profesor("1234567890", "Luis", "Segura", 47, "Ingeniería");

            // Action
            bool result = profesor.AsignarAsignatura(asignatura);

            // Assert
            Assert.True(result);
            
        }

        [Fact]
        public void Test_Seleccionar_Asignaturas()
        {
            // Arrange
            Asignatura asignatura = new Asignatura("IDS306", "Construcción de Software", 4);
            Carrera carrera = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante estudiante = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrera);

            // Action
            bool result = estudiante.SeleccionarAsignatura(asignatura);

            // Assert
            Assert.True(result);

        }
    }
}