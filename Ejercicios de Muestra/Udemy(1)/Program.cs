using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Udemy_1_
{
    internal class Program
    {
        static void Main()
        {
            Menu();
            /*int opcion = 4;
            var resultado = opcion switch
            {
                1 => "Julian",
                2 => "Pedro",
                3 => "Maria",
                4 => "Alex",
            };*/

        }

        static void Menu()
        {
            // Menu utilizando Switch y While
            int opcion;
            string opciones = "Ver Resultados\n" +
                              "1- Operadores\n" +
                              "2- Estructura If - Else\n" +
                              "3- Trinagulo de Pascal\n" +
                              "4- Switch Expressions\n" +
                              "5- Wile\n" +
                              "6- String\n" +
                              "7- String Builder\n" +
                              "8- Salir\n";
            bool ejecutar = true;

            while (ejecutar)
            {
                Console.Clear();
                Console.WriteLine(opciones);
                Console.WriteLine("Escoja una Opcion:");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: Operadores(); break;

                    case 2: EstructuraIfElse(); break;

                    case 3: TrianguloDePaskal(); break;

                    case 4: SwitchExpresion(); break;

                    case 5: While(); break;

                    case 6: strings(); break;

                    case 7: ClaseStringBuilder(); break;

                    case 8: ejecutar = false; Console.WriteLine("Ejecucion FInalizada"); break;

                    default: Console.WriteLine("Opcion Invalida"); break;
                }
                Console.ReadKey();
            }
        }
        static void Operadores()
        {
            // operadores aritmeticos
            Console.WriteLine("*  *  *  Operadores Aritmeticos  *  *  *");
            double valor1 = 33.5;
            int valor2 = 3;

            var suma = valor1 + valor2; // 36.5
            var resta = valor1 - valor2; // 30.5
            var multiplicacion = valor1 * valor2; // 100.5
            var division = valor1 / valor2; // 11.1666...

            Console.WriteLine($"Suma : {suma}"); // Suma : 36,5
            Console.WriteLine($"Resta : {resta}"); // Resta : 30,5
            Console.WriteLine($"Multiplicacion : {multiplicacion}"); // Multiplicacion : 100,5
            Console.WriteLine($"Division : {division}"); // Division : 11,1666...

            //Operadores de asignacion
            Console.WriteLine("\n*  *  *  Operadores de Asignacion  *  *  *");
            int valor3 = 5;

            for (int i = 0; i<3; i++)
            {
                valor3+=valor3; //5+5=10 => 10+10=20 => 20+20=40
            }
            Console.WriteLine($"Acumulador (Suma): {valor3}"); // Acumulador(Suma): 40

            valor3 = 5;

            for (int i = 0; i<2; i++)
            {
                valor3*=valor3; // 5*5=25 => 25*25=625
            }
            Console.WriteLine($"Acumulador (Multiplicacion): {valor3}"); // Acumulador (Multiplicacion): 625;


            //Operadores de comprobacion y de desigualdad
            Console.WriteLine("\n*  *  *  Operadores de Comprobación y de Desigualdad  *  *  *");
            var num1 = 12;
            var num2 = 34;
            var num3 = 33.4;

            var operacion1 = num1 < num2; // true
            var operacion2 = num2 > num3; // true
            var operacion3 = num1 >= num2; // false
            var operacion4 = num2 <= num3; // false
            var operacion5 = num3==num2; // false
            var operacion6 = num3!=num2; // true

            Console.WriteLine($"{operacion1}-{operacion2}-{operacion3}-{operacion4}-{operacion5}-{operacion6}");
            // true-true-false-false-false-true

        }
        static void EstructuraIfElse()
        {
            int num1;
            int num2;
            //Estructura if, else, y operadores condicionales
            Console.WriteLine("\n*  *  *  Estructura if, else, y operadores condicionales  *  *  *");
            double resultado = 0;
            num1 = 5;
            num2 = 8;
            if (num1 > num2) //false
            {
                resultado = num1-num2;
            }
            else
            {
                if (num1<num2) //Verdadero
                {
                    resultado = num2-num1; //resultado = 3
                }
            }
            Console.WriteLine($"Resultado: {resultado}");
            //Resultado: 3

            // Con operador condicional
            num1 = 9;
            num2 = 5;
            resultado = num1>num2 ? num1-num2 : num2-num1; //resultado = 4

            Console.WriteLine($"Resultado: {resultado}");
            //Resultado: 4
        }
        static void TrianguloDePaskal()
        {
            //Triangulo de pascal
            Console.WriteLine("\n*  *  *  Triangulo de Pascal  *  *  *");
            int pisos;
            int[] arreglo = new int[1];

            Console.WriteLine("Ingrese el numero de pisos");
            pisos = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i<=pisos; i++)
            {
                for (int j = pisos; j>i; j--)
                {
                    Console.Write("  ");
                }

                int[] paskal = new int[i];

                for (int k = 0; k < i; k++)
                {
                    if (k==0 || k== (i-1))
                    {
                        paskal[k] = 1;
                    }
                    else
                    {
                        paskal[k] = arreglo[k] + arreglo[k-1];
                    }
                    Console.Write($" [{paskal[k]}]");
                }
                Console.WriteLine(" ");
                arreglo = paskal;
            }
        }
        static void SwitchExpresion()
        {
            //Switch expessions
            var (a, b, opcion) = (4, 7, "=");
            string resultado;
            switch (opcion)
            {
                case "=":
                    resultado = a==b ? "A es igual a B" : "A y B no son iguales";
                    break;
                case ">":
                    resultado = a>b ? "A es mayor que B" : "A no es Mayor que B";
                    break;
                case "<":
                    resultado = a<b ? "A es menor que B" : "A no es menor que B";
                    break;
                default:
                    resultado = "Opción no válida";
                    break;
            }
            Console.WriteLine("Resultado: "+ resultado); // Resultado: A y B no son iguales
        }
        static void While()
        {
            //While
            Console.WriteLine("Adivine el Numero!!!");
            Random random = new Random();
            int numero = random.Next(1, 101);
            bool ganar = false;
            int vidas = 5;
            Console.WriteLine(numero);
            while (!ganar)
            {
                Console.WriteLine("Ingrese un numero entre 1 y 100");
                var number = Convert.ToInt32(Console.ReadLine());
                var resultado = number==numero ? "El numero es corrrecto! Felicidades ha ganado" : "Numero Errado. Pista: ";

                if (!(numero==number))
                {
                    resultado += numero>number ? "El numero es mayor" : "El numero es menor";
                    vidas--;
                    resultado += $"\nTe quedan {vidas} intentos";

                    resultado = vidas==0 ? "Ya no tienes mas vidas, has perdido" : resultado;
                    ganar = vidas==0 ? true : false;
                }
                else
                {
                    ganar = true;
                }

                Console.WriteLine(resultado);
            }
        }
        static void DoWhile()
        {
            //do while
            Console.WriteLine("Adivine el Numero!!!");
            Random random = new Random();
            int numero = random.Next(1, 101);
            bool ganar;
            int vidas = 5;
            do {
                Console.WriteLine("Ingrese un numero entre 1 y 100");
                var number = Convert.ToInt32(Console.ReadLine());
                var resultado = number==numero ? "El numero es corrrecto! Felicidades ha ganado" : "Numero Errado. Pista: ";

                if (!(numero==number))
                {
                    resultado += numero>number ? "El numero es mayor" : "El numero es menor";
                    vidas--;
                    resultado += $"\nTe quedan {vidas} intentos";

                    resultado = vidas==0 ? "Ya no tienes mas vidas, has perdido" : resultado;
                    ganar = vidas==0 ? true : false;
                }
                else
                {
                    ganar = true;
                }

                Console.WriteLine(resultado);
            } while(!ganar);
        }
        static void strings()
        {
            //Manipulacion de Strings
            string frase = "Mi primer: ";
            string frase2 = "Hola Mundo!";
            string frase3 = frase;
            frase += frase2;
            Console.WriteLine(frase);
            //Mi primer: Hola Mundo!
            Console.WriteLine(frase2);
            //Hola Mundo!
            Console.WriteLine(frase3);
            //Mi primer: 

            Console.WriteLine();
            var persona = (nombre: "Julian", apellido: "Arias", edad:19);
            Console.WriteLine("Nombre: {0}\nApellido: {1}\nEdad: {2}",  persona.nombre, persona.apellido, persona.edad);
            //Nombre: Julian
            //Apellido: Arias
            //Edad: 19

            Console.WriteLine();
            frase = "Simon Dice: Todos, busquen una hoja de un arbol";
            Console.WriteLine("Simon dijo:{0}", frase.Substring(11));
            // Simon dijo: Todos, busqyen una hoja de un arbol
            Console.WriteLine("{0} Traiganme una fruta", frase.Substring(0, 11));
            //Simon Dice: Traiganme una fruta
            var frasemodificada = frase.Replace("Todos, busquen una hoja de un arbol", "Suban y bajen la colina");
            Console.WriteLine(frasemodificada);
            //Simon Dice: Suban y bajen la colina
            frasemodificada = frase.Remove(0,11);
            Console.WriteLine(frasemodificada);
            // Todos, busquen una hoja de un arbol

            Console.WriteLine();
            Console.WriteLine(frase.IndexOf(':')); //10
            Console.WriteLine(frase.IndexOf("hoja")); //31
            var datos = frase.ToCharArray();
            Console.WriteLine(datos); //Simon Dice: Todos, busquen una hoja de un arbol
            Console.WriteLine(frase.ToLower()); //simon dice: todos, busquen una hoja de un arbol
            Console.WriteLine(frase.ToUpper()); //SIMON DICE: TODOS, BUSQUEN UNA HOJA DE UN ARBOL

            frase2 = frase;
            var result = frase2.Equals(frase);
            Console.WriteLine(result); // True

            Console.WriteLine();
            var array = "Hola Mundo";
            foreach(var item in array)
            {
                Console.Write(item + "-");
            }
            //H-o-l-a- -M-u-n-d-o-
        }
        static void ClaseStringBuilder()
        {
            //Clase StringBuilder
            var dato = new StringBuilder("Mi nombre es: ");
            Console.WriteLine(dato.ToString()); //Mi nombre es: 
            dato[0] = 'm';
            Console.WriteLine(dato.ToString()); //mi nombre es: 
            dato[0] = 'M';
            dato.Append("Julian");
            Console.WriteLine(dato.ToString()); //Mi nombre es: Julian
            dato.AppendLine(); dato.Append("Tengo 19 años");
            Console.WriteLine(dato.ToString());
            //Mi nombre es: Julian
            //Tengo 19 años

        }
    }

}
