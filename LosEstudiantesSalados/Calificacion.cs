using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
    public class Calificacion
    {
        public Asignatura asignatura;
        public string? CalificacionLiteral { get; set; }
        public int? CalificacionNumerica { get; set; }

        public Calificacion(Asignatura asignaturaV, string CalificacionLiteralV, int CalificacionNumericaV)
        {
			asignatura = asignaturaV;
            CalificacionLiteral = CalificacionLiteralV;
            CalificacionNumerica = CalificacionNumericaV;

		}

	}
}
