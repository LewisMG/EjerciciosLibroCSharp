using System;

namespace Primera_tarea_cap_1_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada = string.Empty;
            int opcion = 0;
           
            do
            {
                Console.Clear();
                Console.WriteLine("1 - Ejercicio 1.1");
                Console.WriteLine("2 - Ejercicio 1.5");
                Console.WriteLine("3 - Ejercicio 2.1");
                Console.WriteLine("4 - Ejercicio 2.3");
                Console.WriteLine("5 - Ejercicio 2.4");
                Console.WriteLine("6 - Ejercicio 2.5");
                Console.WriteLine("7 - Ejercicio 3.1");
                Console.WriteLine("8 - Ejercicio 3.4");
                Console.WriteLine("9 - Ejercicio 3.5");
                Console.WriteLine("10 - Ejercicio 4.1");
                Console.WriteLine("11 - Ejercicio 4.2");
                Console.WriteLine("12 - Ejercicio 4.5");
                Console.Write("Seleccione el ejercicio del 1 al 12:");
                entrada = Console.ReadLine();
                opcion = Convert.ToInt32(entrada);
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ejercicio 1.1");
                        Capitulo1.Ejercicios1.Ejercicio1_1();
                        break;

                    case 2:
                        Console.WriteLine("Ejercicio 1.5");
                        Capitulo1.Ejercicios1.Ejercicio1_5();
                        break;
                    case 3:
                        Console.WriteLine("Ejercicio 2.1");
                        Capitulo2.Ejercicios2.Ejercicio2_1();
                        break;
                    case 4:
                        Console.WriteLine("Ejercicio 2.3");
                        Capitulo2.Ejercicios2.Ejercicio2_3();
                        break;
                    case 5:
                        Console.WriteLine("Ejercicio 2.4");
                        Capitulo2.Ejercicios2.Ejercicio2_4();
                        break;
                    case 6:
                        Console.WriteLine("Ejercicio 2.5");
                        Capitulo2.Ejercicios2.Ejercicio2_5();
                        break;
                    case 7:
                        Console.WriteLine("Ejercicio 3.1");
                        Capitulo3.Ejercicios3.Ejercicio3_1();
                        break;
                    case 8:
                        Console.WriteLine("Ejercicio 3.4");
                        Capitulo3.Ejercicios3.Ejercicio3_4();
                        break;
                    case 9:
                        Console.WriteLine("Ejercicio 3.5");
                        Capitulo3.Ejercicios3.Ejercicio3_5();
                        break;
                    case 10:
                        Console.WriteLine("Ejercicio 4.1");
                        Capitulo4.Ejercicios4.Ejercicio4_1();
                        break;
                    case 11:
                        Console.WriteLine("Ejercicio 4.2");
                        Capitulo4.Ejercicios4.Ejercicio4_2();
                        break;
                    case 12:
                        Console.WriteLine("Ejercicio 4.5");
                        Capitulo4.Ejercicios4.Ejercicio4_5();
                        break;
                    default:
                        Console.WriteLine("Opción no valida");
                        break;
                }
            } while (opcion != 0);
            Console.ReadKey();
        }
    }
}
