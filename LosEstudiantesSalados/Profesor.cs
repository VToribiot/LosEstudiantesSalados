using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
    public class Profesor : Persona
    {
		public List<Asignatura> Asignaturas = new List<Asignatura>();
		string AreaAcademica { get; set; }

        public Profesor(string cedula, string nombres, string apellidos, int edad, string areaAcademica)
        {
            Cedula = cedula;
            Nombres = nombres;
            Apellidos = apellidos;
            Edad = edad;
            AreaAcademica = areaAcademica;
        }
        public bool ValidarDuplicadosEnAsignacion(Asignatura asignatura)
        {
            if (Asignaturas.Contains(asignatura))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
            
        public bool AsignarAsignatura(Asignatura asignatura)
        {
			try
			{
                if (ValidarDuplicadosEnAsignacion(asignatura))
                {
					Asignaturas.Add(asignatura);

					return true;
				}
                else
                {
                    return false;
                }
			
			}
			catch (Exception)
			{

				return false;
			}
		}

    }
}
