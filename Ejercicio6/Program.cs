using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y, num = 0;


            while (num <= 0)
            {
                Console.Write("Ingrese el número de asteriscos para la base del rombo: ");
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
                for (x = 0; x <= num - 2; x++)
                {
                    Console.WriteLine("");
                    for (y = 0; y <= x; y++)
                    {
                        Console.Write(" ");
                    }
                    for (y = num - x - 2; y > 0; y--)
                    {
                        Console.Write("**");
                    }
                    Console.Write("*");
                }

            }
        }
    }
}
