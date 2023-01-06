using LosEstudiantesSalados;
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
		public bool ValidarExistenciaAsignatura(Calificacion calificacion)
		{
			if (Asignaturas.Contains(calificacion.asignatura))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool ValidarDulicadoCalificacion(Calificacion calificacion)
		{
			if (Calificaciones.Contains(calificacion))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool CalificarEstudiante(Calificacion calificacion)
		{
			if (ValidarExistenciaAsignatura(calificacion))
			{
				if (ValidarDulicadoCalificacion(calificacion))
				{
					Calificaciones.Add(calificacion);
					return true;
				}
				else
				{
					return false;
				}
			}
			else
			{
				return false;
			}
		}
		public bool ValidarDuplicadosEnSeleccion(Asignatura asignatura)
		{
			if (Asignaturas.Contains(asignatura))
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		public bool SeleccionarAsignatura(Asignatura asignatura)
        {
			try
			{
				if (ValidarDuplicadosEnSeleccion(asignatura))
				{
					Asignaturas.Add(asignatura);
				}
				else
				{
					return false;
				}
               

                return true;
            }
			catch (Exception)
			{

                return false;
            }
		
        }
	}
}
