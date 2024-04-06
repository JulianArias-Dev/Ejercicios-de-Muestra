using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class LectorEntrada
    {
        public static int inputInt(string label)
        {
            try
            {
                Console.WriteLine(label);
                string entrada = Console.ReadLine();
                int numeroEntero = int.Parse(entrada);
                return numeroEntero;
            }catch (Exception)
            {
                Console.WriteLine("El formato de los datos de entrada no es compatible (x_x)");
                return inputInt(label);
            }
            
        }

        public static string inputString(string label)
        {
            try
            {
                Console.WriteLine(label);
                string entrada = Console.ReadLine();
                return entrada;
            }
            catch(Exception)
            {
                Console.WriteLine("El formato de los datos de entrada no es compatible (x_x)");
                return inputString(label);
            }
        }

        public static char inputChar(string label) {
            try
            {
                Console.WriteLine(label);
                char entrada = char.ToUpper(Console.ReadKey().KeyChar);
                return entrada;
            }
            catch
            {
                Console.WriteLine("El formato de los datos de entrada no es compatible (x_x)");
                return inputChar(label);
            }
        }
    }
}
