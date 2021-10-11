using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, multi = 0;

            while (num <= 0 || num >= 16)
            {
                Console.Write("Ingrese la tabla de multiplicar del 1 al 15: ");
                num = Int32.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= 15; i++)
            {

                multi = num * i;

                Console.WriteLine(num + " * " + i + " = " + multi);

            }
        }
    }
}
