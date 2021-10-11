using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, colum1 = 1, colum2 = 1, colum3 = 1;
            string mensaje = colum1 + " | " + colum2 + " | " + colum3;

            while (num <= 0)
            {
                Console.Write("Ingrese un número: ");
                num = Int32.Parse(Console.ReadLine());
            }

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine(mensaje);
                mensaje = "";

                if (true)
                {
                    colum1++;
                    mensaje += colum1 + " | ";
                }

                if (colum2 < num - 1)
                {
                    colum2 += 2;
                    mensaje += colum2 + " | ";
                }
                else
                {
                    mensaje += "  | ";
                }

                if (colum3 < num - 1)
                {
                    colum3 += 3;
                    mensaje += colum3;
                }
                else
                {
                    mensaje += "";
                }


            }
        }
    }
}
