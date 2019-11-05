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
            int[] array = new int [15];
            for (int i=4; i<=14; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
        }
    }
}
