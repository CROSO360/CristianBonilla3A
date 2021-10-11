using System;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int hora = 0, empl = 0, total = 0;

            while (empl <= 0)
            {
                Console.Write("Ingrese el número de trabajadores: ");
                empl = Int32.Parse(Console.ReadLine());
            }

            for (int i = 1; i < empl + 1; i++)
            {

                while (hora <= 0)
                {
                    Console.Write("\nTRABAJADOR No. " + i + "\nIngrese la cantidad de horas trabajadas: ");
                    hora = Int32.Parse(Console.ReadLine());
                }

                if (hora > 35)
                {
                    total = hora * 22;
                }
                else
                {
                    total = hora * 15;
                }

                Console.Write("El salario semanal de el trabajador No. " + i + " es $" + total + "\n");

                hora = 0;



            }
        }
    }
}
