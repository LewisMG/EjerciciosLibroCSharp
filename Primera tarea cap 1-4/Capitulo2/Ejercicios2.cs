using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo2
{
    public class Ejercicios2
    {
        private static string entrada = string.Empty;
           
        public static void Ejercicio2_1()
        {
            int lados = 0;
            float Vlado = 0, resultado = 0;
            Console.Write("Ingrese Cantidad de lados: \n");
            entrada = Console.ReadLine();
            lados = Convert.ToInt32(entrada);

            Console.WriteLine("Ingrese el valor de un lado:");
            entrada = Console.ReadLine();
            Vlado = Convert.ToSingle(entrada);

            resultado = lados * Vlado;

            Console.WriteLine("El Perimetro es: {0}", resultado);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio2_3()
        {
            const double radian = 0.0174533;
            double grados = 0, resultado = 0;
            Console.WriteLine("Ingrese Cantidad de Grados:");
            entrada = Console.ReadLine();
            grados = Convert.ToDouble(entrada);
            resultado = grados * radian;

            Console.WriteLine("La Cantidad de radianes es {0}", resultado);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio2_4()
        {
            float Centigrados = 0, r = 0;

            Console.WriteLine("Ingrese Grados Centigrados:");
            entrada = Console.ReadLine();
            Centigrados = Convert.ToSingle(entrada);

            if(Centigrados == 0)
            {
                r = 32;
            }
            else
            {
                r = ((9 * Centigrados) / 5) + 32;
            }
            Console.WriteLine("La Cantidad de Grados Fahrenheit: {0}", r);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio2_5()
        {
            float dolares = 0, Teuro = 0, cambio = 0;

            Console.WriteLine("Ingrese Cantidad de Dolares:");
            entrada = Console.ReadLine();
            dolares = Convert.ToSingle(entrada);

            Console.WriteLine("Ingrese la Tasa del Euro:");
            entrada = Console.ReadLine();
            Teuro = Convert.ToSingle(entrada);

            cambio = dolares / Teuro;

            Console.WriteLine("Total de euros: {0}", cambio);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }
    }
}
