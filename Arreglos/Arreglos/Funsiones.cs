using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Funsiones
    {
        public static void ejercicio1()
        {
            Console.WriteLine("\n******* Ejercicio 1 *******");
            int numeros;
            int[] array = new int[numeros];
            for (int i=0; i<=14; i++)
            {
                if (i >= 4)
                {
                    array[i] = i;
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
