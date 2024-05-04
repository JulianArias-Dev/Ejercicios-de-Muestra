using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_APP
{
    public class Estudiante
    {
        public Estudiante() { }

        public Estudiante(string name, string course, int yearsOld)
        {
            Nombre = name;
            Curso = course;
            Edad = yearsOld;
        }

        public String Nombre { get;}
        public String Curso { get;}
        public int Edad { get;}

        public string DatosBusqueda()
        {
            return $"Nombre: {Nombre}\n" +
                   $"Edad: {Edad}\n" +
                   $"Curso: {Curso}";
        }
        public string DatosLista()
        {
            return $"Nombre: {Nombre} --  Edad: {Edad} -- Curso: {Curso}";
        }
    }
}
