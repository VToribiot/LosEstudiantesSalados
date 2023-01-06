using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstudiantes
{
	public class Asignatura
	{
		string Codigo { get; set; }
		string Nombre { get; set; }
		int Creditos { get; set; }

		public Asignatura CrearAsignatura(string codigo, string nombre, int creditos)
		{
			Codigo = codigo;
			Nombre = nombre;
			Creditos = creditos;

			return this;
		}
	}
}
