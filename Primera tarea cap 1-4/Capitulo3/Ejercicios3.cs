using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo3
{
    public class Ejercicios3
    {
        private static string entrada = string.Empty;

        public static void Ejercicio3_1()
        {
            int n = 0;

            Console.WriteLine("Ingrese un numero entero:");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            if (n % 2 == 0)
            {
                Console.WriteLine("El Numero es Par");
            }
            else
            {
                Console.WriteLine("El Numero No es Par");
            }
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio3_4()
        {
            int n = 0;

            Console.WriteLine("Ingrese un Numero del 1 al 7");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            if (n == 1) { Console.WriteLine("Lunes"); }
            if (n == 2) { Console.WriteLine("Martes"); }
            if (n == 3) { Console.WriteLine("Miercoles"); }
            if (n == 4) { Console.WriteLine("Jueves"); }
            if (n == 5) { Console.WriteLine("Viernes"); }
            if (n == 6) { Console.WriteLine("Sabado"); }
            if (n == 7) { Console.WriteLine("Domingo"); }
            if (n > 7) { Console.WriteLine("Ingrese un numero valido"); }
            if (n < 1) { Console.WriteLine("Ingrese un numero valido"); }
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio3_5()
        {
            int opcion = 0, lados = 0;
            float Vlado = 0, Apotema = 0, resultado = 0;
            Console.WriteLine("1 - Perimetro");
            Console.WriteLine("2 - Area");
            Console.Write("Que operación deseas hacer: ");
            entrada = Console.ReadLine();
            opcion = Convert.ToInt32(entrada);

            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese Cantidad de lados: \n");
                    entrada = Console.ReadLine();
                    lados = Convert.ToInt32(entrada);

                    Console.WriteLine("Ingrese el valor de un lado:");
                    entrada = Console.ReadLine();
                    Vlado = Convert.ToSingle(entrada);

                    resultado = lados * Vlado;

                    Console.WriteLine("El Perimetro es: {0}", resultado);
                    break;
                case 2:
                    Console.WriteLine("Ingrese el valor de un lado:");
                    entrada = Console.ReadLine();
                    Vlado = Convert.ToSingle(entrada);

                    Console.WriteLine("Ingrese el Apotema:");
                    entrada = Console.ReadLine();
                    Apotema = Convert.ToSingle(entrada);

                    resultado = (Apotema * Vlado) / 2;
                    Console.WriteLine("El Area es: {0}", resultado);
                    break;
                default:
                    Console.WriteLine("Opción no valida");
                    break;
            }
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }
    }
}
