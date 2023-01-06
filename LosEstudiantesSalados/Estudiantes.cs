using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
	public class Estudiante : Persona
	{
		public Carrera Carrera { get; set; }
		public List<Asignatura> Asignaturas = new List<Asignatura>();
		public List<Calificacion> Calificaciones = new List<Calificacion>();

		public Estudiante (string cedula, string nombre, string apellido, int edad, Carrera carrera)
        {
			Cedula = cedula;
			Nombres = nombre;
			Apellidos = apellido;
			Edad = edad;
			Carrera = carrera;
		}

		public bool SeleccionarAsignatura(Asignatura asignatura)
        {
			return true;
        }
	}
}
