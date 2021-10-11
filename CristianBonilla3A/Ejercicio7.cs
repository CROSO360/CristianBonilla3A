using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CristianBonilla3A
{
    class Ejercicio7
    {

        static void sabe(string[] args)
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
