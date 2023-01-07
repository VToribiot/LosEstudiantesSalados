using Xunit;
using LosEstudiantesSalados;

namespace TestSchool
{
    public class Validar
    {
        [Fact]
        public void Test_Assign_Subjects()
        {
            // Arrange
            Asignatura subject = new Asignatura("IDS306", "Construcción de Software", 4);
            Profesor professor = new Profesor("1234567890", "Luis", "Segura", 47, "Ingeniería");

            // Action
            bool result = professor.AsignarAsignatura(subject);

            // Assert
            Assert.True(result);
            
        }

        [Fact]
        public void Test_Fail_Assign_Subjects()
        {
            // Arrange
            Asignatura subjects = new Asignatura("IDS306", "Construcción de Software", 4);
            Profesor professor = new Profesor("1234567890", "Luis", "Segura", 47, "Ingeniería");
            professor.AsignarAsignatura(subjects);
            // Action
            bool result = professor.AsignarAsignatura(subjects);

            // Assert
            Assert.False(result);

        }
        [Fact]
        public void Duplicate_Test_Assignment_Subjects()
        {
            // Arrange
            Asignatura subject1 = new Asignatura("IDS306", "Construcción de Software", 4);
            Profesor professor = new Profesor("1234567890", "Luis", "Segura", 47, "Ingeniería");

            // Action
            bool result = professor.ValidarDuplicadosEnAsignacion(subject1);

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Fail_Duplicates_Assignment_Subjects()
        {
            // Arrange
            Asignatura subject2 = new Asignatura("IDS306", "Construcción de Software", 4);
            Profesor professor = new Profesor("1234567890", "Luis", "Segura", 47, "Ingeniería");

            // Action
            professor.AsignarAsignatura(subject2);
            bool result = professor.ValidarDuplicadosEnAsignacion(subject2);

            // Assert
            Assert.False(result);

        }

        [Fact]
        public void Test_Select_Subjects()
        {
            // Arrange
            Asignatura subject3 = new Asignatura("IDS306", "Construcción de Software", 4);
            Carrera carrer = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer);

            // Action
            bool result = student.SeleccionarAsignatura(subject3);

            // Assert
            Assert.True(result);

        }

        [Fact]
        public void Test_Subject_Duplicate_Student()
        {
            // Arrange
            Asignatura subject4 = new Asignatura("IDS306", "Construcción de Software", 4);
            Carrera carrer2 = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student2 = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer2);

            // Action
            bool result = student2.ValidarDuplicadosAsignatura(subject4);

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Test_Fail_Duplicate_Subject_Student()
        {
            // Arrange
            Asignatura subject5 = new Asignatura("IDS306", "Construcción de Software", 4);
            Carrera carrer3 = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student3 = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer3);

            // Action

            student3.SeleccionarAsignatura(subject5);
            bool result = student3.ValidarDuplicadosAsignatura(subject5);

            // Assert
            Assert.False(result);
        }

        [Fact]
        public void Test_Qualify_Student()
        {
            // Arrange
            Carrera carrer5 = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student5 = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer5);
            Asignatura subject6 = new Asignatura("IDS306", "Construcción de Software", 4);
            Calificacion calificacion = new Calificacion(subject6, "A", 100);

            // Action
            bool result = student5.CalificarEstudiante(calificacion); 

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Test_Select_Subject()
        {
            // Arrange
            Carrera carrer6 = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student6 = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer6);
            Asignatura subject7 = new Asignatura("IDS306", "Construcción de Software", 4);
            
            // Action


            bool result = student6.SeleccionarAsignatura(subject7);

            // Assert
            Assert.True(result);
        }
        [Fact]
        public void Test_Fail_Select_Subject()
        {
            // Arrange
            Carrera carrer7 = new Carrera("IDS", "Ingeniería de Software", 22);
            Estudiante student7 = new Estudiante("001235467984", "Alejandro", "Ramirez", 21, carrer7);
            Asignatura subject8 = new Asignatura("IDS306", "Construcción de Software", 4);

            // Action
            student7.SeleccionarAsignatura(subject8);
            bool result = student7.SeleccionarAsignatura(subject8);

            // Assert
            Assert.False(result);
        }
    }
}