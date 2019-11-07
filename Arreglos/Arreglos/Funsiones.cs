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
            int[] array = new int[15];
            for (int i = 4; i <= 14; i++)
            {
                array[i] = i;
                Console.WriteLine(array[i]);
            }
        }
        public static void ejercicio2()
        {
            Console.WriteLine("\n******* Ejercicio 2 *******");
            int[] array = new int[101];
            for (int i = 1; i <= 100; i++)
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
            Console.WriteLine("\n******* Ejercicio 5 *******");
            int suma = 0;
            int[] numeros = new int[41];
            for (int i = 1; i <= 40; i++)
            {
                numeros[i] = i;
                if (numeros[i] % 2 == 0)
                {
                    Console.WriteLine(numeros[i]);
                    suma = suma + numeros[i];
                }
            }
            return suma;
        }
        public static void ejercicio6()
        {
            Console.WriteLine("\n******* Ejercicio 6 *******");
            int[] numeros = new int[5];
            int suma = 0;
            double media;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame un número:");
                numeros[i] = int.Parse(Console.ReadLine());
                suma = suma + numeros[i];
            }
            media = (double)suma / 5;
            Console.WriteLine("La media aritmetica es: " + media);
        }
        public static void ejercicio7()
        {
            Console.WriteLine("\n******* Ejercicio 7 *******");
            int suma_p = 0, suma_n = 0;
            int[] numeros = new int[7];
            numeros[0] = -2;
            numeros[1] = 5;
            numeros[2] = 8;
            numeros[3] = -9;
            numeros[4] = 10;
            numeros[5] = 15;
            numeros[6] = -4;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(numeros[i]);
                if (numeros[i] < 0)
                {
                    suma_n = suma_n + numeros[i];
                }
                else
                {
                    suma_p = suma_p + numeros[i];
                }
            }
            Console.WriteLine("La suma de los positivos es " + suma_p);
            Console.WriteLine("La suma de los negativos es " + suma_n);
        }
        public static void ejercicio8()
        {
            Console.WriteLine("\n******* Ejercicio 8 *******");
            string cadena;
            int i = 0;

            // guardamos las vocales en un array de enteros
            int[] vocales = new int[5];
            vocales[0] = 0;
            vocales[1] = 0;
            vocales[2] = 0;
            vocales[3] = 0;
            vocales[4] = 0;

            Console.WriteLine("Introduce un texto:");
            cadena = Console.ReadLine();

            // recorremos cada uno de los caracteres en busca de las vocales
            for (i = 1; i < cadena.Length; i++)
            {
                switch (cadena.ToUpper())
                {
                    case "a":
                        vocales[0] += vocales[0] + 1;
                        break;
                    case "e":
                        vocales[1] += vocales[1] + 1;
                        break;
                    case "i":
                        vocales[2] += vocales[2] + 1;
                        break;
                    case "o":
                        vocales[3] += vocales[3] + 1;
                        break;
                    case "u":
                        vocales[4] += vocales[4] + 1;
                        break;
                }
            }
            Console.WriteLine("Existen " + vocales[0] + " vocales A");
            Console.WriteLine("Existen " + vocales[1] + " vocales E");
            Console.WriteLine("Existen " + vocales[2] + " vocales I");
            Console.WriteLine("Existen " + vocales[3] + " vocales O");
            Console.WriteLine("Existen " + vocales[4] + " vocales U");
        }
    }
}
