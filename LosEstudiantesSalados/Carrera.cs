using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LosEstudiantesSalados
{
    public class Carrera
    {
        string idCarrera { get; set; }
        string nombreCarrera { get; set; }
        int MaxCredito { get; set; }

        public bool CrearCarrera(string idCarrera, string nombreCarrera, int MaxCredito)
        {
            return true;
        }
    }
}
