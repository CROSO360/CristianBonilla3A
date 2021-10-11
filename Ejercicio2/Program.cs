using System;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 0;

            Console.Write("Ingrese el número de asteriscos para el cuadrado: ");

            while (num1 <= 0)
            {
                num1 = Int32.Parse(Console.ReadLine());
            }

            for (int i = 0; i < num1; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();

            for (int i = 0; i < num1 - 2; i++)
            {
                Console.Write("* ");

                for (int j = 0; j < num1 - 2; j++)
                {
                    Console.Write("  ");
                }

                Console.WriteLine("* ");
            }

            for (int i = 0; i < num1; i++)
            {
                Console.Write("* ");
            }

            Console.WriteLine();
        }
    }
}
