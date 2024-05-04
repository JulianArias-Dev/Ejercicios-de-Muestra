using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_de_Métodos
{
    internal class Program
    {
        #region Tipos de Metodos
        /// <summary>
        /// Sobrecarga de Metodos
        /// </summary>
        internal Program() { }
        internal Program(string Cadena) {
            cadena = Cadena;
            n = cadena.Length;
        }

        internal Program(string Cadena, int numero, bool ejecutar)
        {
            if (ejecutar)
            {
                Console.WriteLine($"Este constructor contiene un mensaje: {cadena}");
                Console.WriteLine($"Y un numero asociado: {numero}");
            }
        }

        internal Program(string Cadena, bool ejecutar, int numero)
        {
            if (ejecutar)
            {
                Console.WriteLine($"Este constructor contiene un mensaje: {cadena}");
                Console.WriteLine($"Y un numero asociado: {numero}");
            }
        }

        private string cadena;
        private int n;
        
        private string VerMayusculas()
        {
            StringBuilder verMayusculas = new StringBuilder();
            string[] Mayusculas = {};
            string tempMy ="";

            for (int i = 0; i < n ; i++)
            {
                if (char.IsLetter(cadena[i]) && char.IsUpper(cadena[i]))
                {
                    tempMy += Convert.ToString(cadena[i]);
                }                
            }
            for (int i  = 0; i < tempMy.Length; i ++)
            {
                verMayusculas.Append($"{tempMy[i]},");
            }
            return verMayusculas.ToString();
        }
        private string VerMinusculas()
        {
            StringBuilder verMinusculas = new StringBuilder();
            string[] Minusculas = { };
            string tempMn = "";

            for (int i = 0; i < n; i++)
            {
                if (char.IsLetter(cadena[i]) && char.IsLower(cadena[i]))
                {
                    tempMn += Convert.ToString(cadena[i]);
                }
            }
            for (int i = 0; i < tempMn.Length; i++)
            {
                verMinusculas.Append($"{tempMn[i]},");
            }
            return verMinusculas.ToString();
        }

        #endregion

        
        static void Main()
        {
            /*
             Console.WriteLine("Ingrese una Frase: ");
             var dato = Console.ReadLine();

             var subProgram = new Program(dato);
             var mayusculas = subProgram.VerMayusculas();
             var minusculas = subProgram.VerMinusculas();
             Console.WriteLine($"Mayusculas ({mayusculas.Length/2}): {mayusculas}");
             Console.WriteLine($"Minusculas ({minusculas.Length/2}): {minusculas}");
             Console.ReadKey();
            //*/

            #region Parametros de Metodos

            /*
            //Parametros De objetos
            Console.WriteLine("Parametros De objetos");
            Object[] parametros = { "Marcos", 24, true };

            MetodoConObjeto(parametros);

            Console.WriteLine();

            MetodoConObjeto("Pedro", 34, false);

            //Parametros Inmutables
            //Console.WriteLine("Parametros Inmutables");
            //string name = "Mario";
            //int number = 67;
            //MetodoInmutable(name, number);
            

            //Palabras clave 'out' & 'ref'
            Console.WriteLine("Palabras clave 'out' & 'ref'");
            int dato; //No declaramos valor inicial
            MetodosPalabrasClave(out dato);
            dato += 15; //Agregamos +15
            Console.WriteLine("2. Dato: " + dato);
            Console.ReadKey();
            //*/

            #endregion

            #region Funciones
            /*
            int number = 35;
            bool dato;
            VerificarNumero(number, out dato);
            string resultado = dato ? "El numero es mayor que 50" : "El numero no es mayor que 50";
            
            void imprimir() => Console.WriteLine(resultado);

            imprimir();
            //*/
            #endregion

            //DatosDuplicados();

            #region Datos Opcionales
            /*
            Console.WriteLine("Ingrese el valor del prestamo");
            var valorPrestamo = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de cuotas");
            var cuotas = Convert.ToInt32(Console.ReadLine());
            
            char decision; 
            do
            {
                Console.WriteLine("¿Desea modificar el porcentaje de intereses? Y/N");
                var input = Convert.ToString(Console.ReadLine()).ToUpper();
                decision = Convert.ToChar(input[0]);
               
            } while (decision!='Y' && decision!='N');

            decimal valorTotal=0;

            if (decision == 'Y')
            {
                Console.WriteLine("Ingrese el porcentaje de intereses");
                var interes = Convert.ToDecimal(Console.ReadLine());
                valorTotal = calcularValorPrestamo(prestamo:valorPrestamo, intereses:interes, meses: cuotas);
                Console.WriteLine($"Con un porcentaje de intereses de: {interes*100}%\n" +
                                  $"En {cuotas} cuotas, el cliente deberá pagar: {valorTotal}\n" +
                                  $"Por su prestamo de: {valorPrestamo}");
            }
            else if(decision == 'N')
            {
                valorTotal = calcularValorPrestamo(valorPrestamo, cuotas);
                Console.WriteLine($"Con un porcentaje de intereses de: 2.05%\n" +
                                  $"En {cuotas} cuotas, el cliente deberá pagar: {valorTotal}\n" +
                                  $"Por su prestamo de: {valorPrestamo}");
            }

            Console.WriteLine($"Valor cuotas: {valorCuotas()}");

            decimal valorCuotas() => valorTotal/cuotas;
            //*/
            #endregion
            
            Console.ReadKey();
        }

        private static decimal calcularValorPrestamo(decimal prestamo, int meses, decimal intereses=0.0205m)
        {

            decimal calcularIntereses() => prestamo*intereses*meses;

            return prestamo + calcularIntereses(); 
        }
        private static void DatosDuplicados()
        {
            int[] array = { 4,5,2,3,5,4,3,2,4,7,8,9,6,3,4,6,7,8,5,3,3,2,2,3,6,5,3,6,3};
            int[] list = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                int count=0;
                for(int j=0; j<list.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                        if (!numero(array[i]))
                        {
                            list[i] = array[i];
                        }
                    }
                }
                if (list[i]!=0)
                {
                    Console.WriteLine($"El numero {list[i]} se repite {count} veces");
                }
            }

            bool numero(int num) => list.Contains(num);
        }
        private static void VerificarNumero(int numero, out bool data)
        {
            data = funcion();

            bool funcion() => numero > 50 ? true : false;
        }
        private static void MetodosPalabrasClave(out int value)
        {
            value = 50;
            Console.WriteLine("1. Valor: " + value);
        }
        private static void MetodoInmutable(in string Nombre, in int Numero)
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Numero: " + Numero);
        }
        private static void MetodoConObjeto(params Object[] datos)
        {
            var cadena = (string)datos[0];
            var num = (int)datos[1];
            var booleano = (bool)datos[2];

            Console.WriteLine("Cadena: "+cadena); 
            Console.WriteLine("Numero: "+num); 
            Console.WriteLine("Booleano: "+booleano);
        }

    }
}
