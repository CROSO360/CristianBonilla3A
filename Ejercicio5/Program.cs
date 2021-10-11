using System;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, num = 0;


            while (num <= 0)
            {
                Console.Write("Ingrese el número de asteriscos para la base del triángulo: ");
                num = Int32.Parse(Console.ReadLine());

                for (x = 1; x <= num; x++)
                {
                    Console.WriteLine("");
                    for (y = num - x; y > 0; y--)
                    {
                        Console.Write(" ");
                    }
                    for (y = 1; y < x; y++)
                    {
                        Console.Write("**");
                    }
                    Console.Write("*");
                }

            }
        }
    }
}
