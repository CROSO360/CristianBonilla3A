using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0, num = 0, acum = 0, facto = 1;

            while (true)
            {
                Console.WriteLine("\n--------------------");
                Console.WriteLine("MENU");
                Console.WriteLine("1) Salir");
                Console.WriteLine("2) Sumatorio");
                Console.WriteLine("3) Factorial");
                Console.WriteLine("--------------------\n");

                Console.Write("Elige una opción: ");
                opcion = Int32.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Saliendo del programa...\n");
                    break;
                }
                else if (opcion == 2)
                {


                    while (num <= 0)
                    {
                        Console.Write("Ingresa un número para sacar el sumatorio: ");
                        num = Int32.Parse(Console.ReadLine());
                    }

                    for (int i = num; i >= 1; i--)
                    {
                        acum += i;


                    }

                    Console.Write("El sumatorio de " + num + " es: " + acum + "\n");

                    acum = 0;
                    num = 0;


                }
                else if (opcion == 3)
                {

                    while (num <= 0)
                    {
                        Console.Write("Ingresa un número para sacar el factorial: ");
                        num = Int32.Parse(Console.ReadLine());
                    }

                    for (int i = num; i >= 1; i--)
                    {
                        facto *= i;


                    }

                    Console.Write("El factorial de " + num + " es: " + facto + "\n");

                    facto = 1;
                    num = 0;


                }
                else
                {
                    Console.Write("Elige una opción correcta\n");
                }

            }
        }
    }
}
