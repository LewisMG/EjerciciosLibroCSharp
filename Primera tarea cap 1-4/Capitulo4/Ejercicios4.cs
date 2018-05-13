using System;
using System.Collections.Generic;
using System.Text;

namespace Capitulo4
{
    public class Ejercicios4
    {
        private static string entrada = string.Empty;
        public static void Ejercicio4_1()
        {
            int n = 0, r = 0;

            Console.WriteLine("Ingrese un numero:");
            entrada = Console.ReadLine();
            n = Convert.ToInt32(entrada);

            for(int x=1; x<=10; x++)
            {
                r = n * x;
                Console.WriteLine(n + "x" + x + " = " + r);
            }
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio4_2()
        {
            int b = 0, p = 0, e = 0;

            Console.WriteLine("Ingrese un numero:");
            entrada = Console.ReadLine();
            b = Convert.ToInt32(entrada);
            
            Console.WriteLine("Ingrese La Potencia a la cual sera elevado:");
            entrada = Console.ReadLine();
            p = Convert.ToInt32(entrada);

            e = b;
            while(p > 1)
            {
                b = b * e;
                p--;
            }
            Console.WriteLine("El resultado es: "+b);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }

        public static void Ejercicio4_5()
        {
            int edad = 0, cantedad = 0, acumulador = 0;
            int c = 0, mayor = 0, menor = 200, promedio = 0;

            Console.WriteLine("Ingrese Cantidad de personas:");
            entrada = Console.ReadLine();
            cantedad = Convert.ToInt32(entrada);
            c = cantedad;

            while (cantedad>0)
            {
                Console.WriteLine("Ingrese edad:");
                entrada = Console.ReadLine();
                edad = Convert.ToInt32(entrada);

                acumulador += edad;

                if (edad > mayor)
                    mayor = edad;
                if (edad < menor)
                    menor = edad;

                cantedad--;
            }
            promedio = acumulador / c;

            Console.WriteLine("Edad menor: " + menor);
            Console.WriteLine("Edad mayor: " + mayor);
            Console.WriteLine("Edad promedio: " + promedio);
            Console.WriteLine("Precione enter para continuar \n");
            Console.ReadKey();
        }
    }
}
