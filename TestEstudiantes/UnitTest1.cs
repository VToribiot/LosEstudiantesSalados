using Xunit;
using ProyectoEstudiantes;

namespace TestSchool
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            // Arrange



            // Act
            Persona persona = new Persona();
            Console.WriteLine(persona.GetEdad());


            // Assert
            Assert.Equal("Tengo 18 años", persona.GetEdad());
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(4, 4);
        }
    }
}