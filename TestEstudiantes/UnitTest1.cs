using Xunit;
using LosEstudiantesSalados;

namespace TestSchool
{
    public class UnitTest1
    {
        [Fact]
        public void Test_Crear_Estudiante()
        {
            // Arrange
             Estudiante estudiante = new Estudiante();
            // Assert
            Assert.True(estudiante.CrearEstudiante("402-1128582-6", "Vasquez Pena", "Yazmin", 21, "IDS"));
        }

        [Fact]
        public void Test_Crear_Carrera()
        {
            // Arrange
            Carrera carrera = new Carrera();
            // Assert
            Assert.True(carrera.CrearCarrera("IDS", "Ingenieria en software",24));
        }
    }
}