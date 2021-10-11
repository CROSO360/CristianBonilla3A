using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            double cantidad = -1, total = 0, multi = 0, precio = 0;


            while (true)
            {

                while (cantidad < 0)
                {
                    Console.Write("Ingrese la cantidad vendida: ");
                    cantidad = Double.Parse(Console.ReadLine());
                }

                if (cantidad == 0)
                {
                    break;
                }

                while (precio <= 0)
                {
                    Console.Write("Ingrese el precio del producto: ");
                    precio = Double.Parse(Console.ReadLine());
                }

                multi = cantidad * precio;

                total += multi;

                cantidad = -1;
                precio = 0;


            }

            Console.WriteLine("El total de la factura es de $" + total);
        }
    }
}
