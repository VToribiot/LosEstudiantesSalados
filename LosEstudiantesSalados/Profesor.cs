using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
    public class Profesor : Persona
    {
        string AreaAcademica { get; set; }

        public Profesor(string cedula, string nombres, string apellidos, int edad, string areaAcademica)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            AreaAcademica = areaAcademica;
        }

        public bool AsignarAsignatura(Asignatura asignatura)
        {
            return true;
        }

    }
}
