using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerPractico_FC250417
{
        public class Estudiante
        {
            public string NomApe  { get; set; }
            public string Carrera { get; set; }
            public string Materia { get; set; }
            public Double Promedio { get; set; }
        public Estudiante(string nombre, string materia, string carrera, Double promedio)
        {
            NomApe = nombre;
            Carrera = carrera;
            Materia = materia;
            Promedio = promedio;
        }
        public bool EsDestacado()
        {
            if (Promedio > 8.0)
            {
                return true;
            }
            else
            {
                return false;
            }


        }
    }
    

}
