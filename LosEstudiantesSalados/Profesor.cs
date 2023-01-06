using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstudiantes
{
    public class Profesor : Persona
    {

        List<Asignatura> Asignatura = new List<Asignatura>();
        string AreaAcademica { get; set; }

        public Profesor CrearProfesor(string cedula, string nombres, string apellidos, int edad, Asignatura asignaturas, string areaAcademica)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            Asignatura.Add(asignaturas);
            AreaAcademica = areaAcademica;
            return this;
        }

    }
}
