using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoEstudiantes
{
    public class Persona
    {
        int Cedula { get; set; }
        string Nombres { get; set; }
        string Apellidos { get; set; }
        int Edad { get; set; }
        public string GetEdad()
        {
            return "Tengo 18 años";
        }
    }

}
