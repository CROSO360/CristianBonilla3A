using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int colum1 = 1, colum2 = 100;

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(colum1 + " | " + colum2);
                colum1++;
                colum2--;

            }
        }
    }
}
