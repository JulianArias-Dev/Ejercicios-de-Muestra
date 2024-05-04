using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escuela_APP
{
    internal class Program
    {
        static void Main()
        {
            Escuela school = new Escuela();

            #region Crear y Agregar Estudiantes
            Estudiante estudiante = new Estudiante("Juan Marquez","3a",7);
            Estudiante estudiante1 = new Estudiante("Ana Blanco", "3a", 8);
            Estudiante estudiante2 = new Estudiante("Mario Rodriguez", "3b", 8);
            Estudiante estudiante3 = new Estudiante("Juan Valencia", "3b", 8);
            Estudiante estudiante4 = new Estudiante("Andrea Sandoval", "4b", 8);
            Estudiante estudiante5 = new Estudiante("Manuel Velazquez", "4b", 9);
            Estudiante estudiante6 = new Estudiante("Carlos Fuentes", "4a", 8);
            Estudiante estudiante7 = new Estudiante("Carla Santana", "4a", 9);
            Estudiante estudiante8 = new Estudiante("Estiven Hernandez", "4a", 8);
            Estudiante estudiante9 = new Estudiante("Sebastian Lopez", "4a", 10);
            Estudiante estudiante10 = new Estudiante("Brayan Duque", "5a", 10);
            Estudiante estudiante11 = new Estudiante("Elena Perez", "5a", 10);
            Estudiante estudiante12 = new Estudiante("Wendy Osorio", "5a", 11);

            school.agregarEstudiante(estudiante);
            school.agregarEstudiante(estudiante1);
            school.agregarEstudiante(estudiante2);
            school.agregarEstudiante(estudiante3);
            school.agregarEstudiante(estudiante4);
            school.agregarEstudiante(estudiante5);
            school.agregarEstudiante(estudiante6);
            school.agregarEstudiante(estudiante7);
            school.agregarEstudiante(estudiante8);
            school.agregarEstudiante(estudiante9);
            school.agregarEstudiante(estudiante10);
            school.agregarEstudiante(estudiante11);
            school.agregarEstudiante(estudiante12);
            #endregion
            
            Console.WriteLine();
            var student = school.buscarEstudianteNombre("Ana Blanco");
            if (student!=null)
            {
                Console.WriteLine(student.DatosBusqueda());
            }
            else
            {
                Console.WriteLine("No se han encontrado similares");
            }

            Console.WriteLine();
            var curso = "3b";
            var students = school.estudiantesPorCurso(curso);
            if (students.Count==0)
            {
                Console.WriteLine("No se han encontrado estudiantes para el curso: "+curso);
            }
            else
            {
                Console.WriteLine("Estudiantes en el curso: "+curso);
                foreach (var item in students)
                {
                    Console.WriteLine(item.DatosLista());
                }
            }

            Console.WriteLine();
            int edad = 9;
            students = school.estudiantesPorEdad(edad);
            if (students.Count==0)
            {
                Console.WriteLine("No se han encontrado estudiantes con la edad de: "+edad);
            }
            else
            {
                Console.WriteLine($"Estudiantes con {edad} años: " );
                foreach (var item in students)
                {
                    Console.WriteLine(item.DatosLista());
                }
            }

            Console.ReadKey();
        }
    }
}
