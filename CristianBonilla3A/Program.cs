using System;

namespace CristianBonilla3A
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int n = 0;
            int mayor = 0;

            

            while (num <= 0)
            {
                Console.Write("Ingrese la cantidad de números: ");
                num = Int32.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= num; i++)
            {
                Console.Write("Ingrese el número " + i + ": ");
                n = Int32.Parse(Console.ReadLine());

                if (n > mayor)
                {
                    mayor = n;
                }
            }

            Console.WriteLine("El número mayor es: " + mayor);

        }
    }
}
