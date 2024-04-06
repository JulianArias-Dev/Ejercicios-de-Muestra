using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de enteros \n");

            int numero1 = LectorEntrada.inputInt("Ingrese el primer numero entero: ");
            int numero2 = LectorEntrada.inputInt("Ingrese el segundo numero entero: ");

            //Definimos un valor inicial para la variable ejecutar
            bool ejecutar = true;
            
            while (ejecutar)
            {
                Console.WriteLine("Operaciones Disponibles: \n");
                Console.WriteLine("1-Suma");
                Console.WriteLine("2-Resta");
                Console.WriteLine("3-Multiplicacion");
                Console.WriteLine("4-Division");
                Console.WriteLine("5- Finalizar \n");

                int llamarFuncion = LectorEntrada.inputInt("Seleccione una opcion del menu: ");

                switch (llamarFuncion)
                {
                    case 1: 
                        suma(numero1, numero2);
                        break;
                    case 2:
                        resta(numero1, numero2);
                        break;
                    case 3:
                        multiplicacion(numero1, numero2);
                        break;
                    case 4:
                        division(numero1, numero2);
                        break;
                    case 5:
                        Console.WriteLine("Ejecucion Finalizada");
                        ejecutar=false;
                        break;

                    default:
                        Console.WriteLine("No se reconoce la opcion [¿?]");
                        break;
                }
            }
            Console.Read();
        }

        public static void suma(int x, int y)
        {
            int adicion = x+y;
            Console.WriteLine($"El resultado de la suma es: {adicion}");
        }

        private static void resta(int x, int y)
        {
            int diferencia = Math.Abs(x-y);
            Console.WriteLine($"La diferencia entre los dos numeros es: {diferencia}");
        }

        private static void multiplicacion(int x, int y)
        {
            int producto = x*y;
            Console.WriteLine($"El producto de la multiplicacion es: {producto}");
        }

        private static void division(int x, int y)
        {
            double cociente = x/y;
            Console.WriteLine($"El cociente de la division es: {cociente}");
        }
    }
}
