using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Escuela_APP
{
    public class Escuela
    {
        private readonly List<Estudiante> estudiantes;
        public Escuela()
        {
            estudiantes = new List<Estudiante>();
        }
        public void agregarEstudiante(Estudiante student)
        {
            estudiantes.Add(student);
        }
        public Estudiante buscarEstudianteNombre(String name)
        {
            return estudiantes.Count==0 ? null : buscar();

            Estudiante buscar(){
                foreach (var item in estudiantes)
                {
                    if (item.Nombre.Equals(name)) 
                        return item;
                }
                return null;
            }
        }
        public List<Estudiante> estudiantesPorCurso(String course)
        {
            return estudiantes.Count==0 ? null : filtrar();

            List<Estudiante> filtrar()
            {
                return estudiantes.Where(e => e.Curso.Equals(course)).ToList();
            }
        }
        public List<Estudiante> estudiantesPorEdad(int edad)
        {
            return estudiantes.Count==0 ? null : filtrar();

            List<Estudiante> filtrar()
            {
                return estudiantes.Where(e => e.Edad==edad).ToList();
            }
        }

    }
}
