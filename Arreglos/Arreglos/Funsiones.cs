﻿using System;
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
        public static void ejercicio2()
        {
            Console.WriteLine("\n******* Ejercicio 2 *******");
            int[] array = new int[101];
            for (int i=1; i <=100; i++)
            {
                array[i] = i;
                if (array[i] % 2 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void ejercicio3()
        {
            Console.WriteLine("\n******* Ejercicio 3 *******");
            int[] array = new int[102];
            for (int i = 0; i <= 100; i++)
            {
                array[i] = i;
                if (array[i] % 3 == 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void ejercicio4()
        {
            Console.WriteLine("\n******* Ejercicio 4 *******");
            int[] n_al = new int[10];
            double[] n_m = new double[10];
            Random aleatorios = new Random();
            for (int i = 0; i < 10; i++)
            {
                n_al[i] = aleatorios.Next(50, 100);
                n_m[i] = n_al[i] * 0.5;
                Console.WriteLine(n_al[i] + "\t" + n_m[i]);
            }
        }
        public static int ejercicio5()
        {

        }
    }
}
