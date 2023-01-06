using ProyectoEstudiantes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
	public class Estudiante : Persona
	{
		public List<Asignatura> Asignaturas { get; set; }
		public List<Calificacion> Calificaciones { get; set; }
		public int IdCarrera { get; set; }

		public bool CrearEstudiante(string cedulaV, string ApellidoV, string NombreV, int EdadV, string carreraId)
        {

			return true;
        }
	}
}
