using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Conversor_de_Velocidades
{
    internal class Program
    {
        static void Main()
        {
            bool ejecutar = true;
            while (ejecutar)
            {
                string opciones = "\n\n1- Convertir Km/h a m/s\n" +
                                  "2- Convertir m/s a Km/h\n" +
                                  "3- Salir\n" +
                                  "Seleccione una opción >";

                Console.WriteLine(opciones);
                var opcion = Convert.ToInt16(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Velocidades.KilometrosAMetros(); break;

                    case 2: Velocidades.MetrosAKilometros(); break;
                    
                    case 3: ejecutar = false; Console.WriteLine("Ejecucion Finalizada"); break;

                    default: Console.WriteLine("Opcion Invalida"); break;
                }
            }
            Console.ReadKey();
        }

        class Velocidades
        {
            public Velocidades() { }

            private static double velocidad;
            public static void MetrosAKilometros()
            {
                Console.WriteLine("Ingrese la velocidad en m/s");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($">>{velocidad} m/s son {convertirKM()} Km/h");

                double convertirKM() => Math.Round(velocidad * 3.6, 2);
            }

            public static void KilometrosAMetros()
            {
                Console.WriteLine("Ingrese la velocidad en Km/h");
                velocidad = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($">>{velocidad} Km/h son {convertitM()} m/s");

                double convertitM() => Math.Round(velocidad * 1000 / 3600, 2);
            }

        }
    }
}
