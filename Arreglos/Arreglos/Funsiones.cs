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
            Console.WriteLine("La suma de los primeros 20 números es " + suma);
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
            string frase;
            int vocales = 0;
            Console.WriteLine("Introduce una frase:");
            frase = Console.ReadLine();
            int[] letras = new int[frase.Length];
            for (int i = 0; i < frase.Length; i++)
            {
                letras[i] = frase[i];
                if ((letras[i] == 'a') || (letras[i] == 'e') || (letras[i] == 'i') || (letras[i] == 'o') || (letras[i] == 'u'))
                {
                    vocales = vocales + 1;
                }
                else if ((letras[i] == 'A') || (letras[i] == 'E') || (letras[i] == 'I') || (letras[i] == 'O') || (letras[i] == 'U'))
                {
                    vocales = vocales + 1;
                }
            }
            Console.WriteLine("Su frase tiene " + vocales + " vocales.");
        }
    }
}
