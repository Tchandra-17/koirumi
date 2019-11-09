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
            //Se crea un arreglo donde guardar los números
            int[] array = new int[11];
            
            //Se crea un ciclo for para asignar el número del arreglo
            for (int i = 0; i < 11; i++)
            {
                //Al valor del arreglo se le asigna el valor de i
                //y se le suman 4 en cada repetición para conseguir
                //los número deseados
                array[i] = i + 4;
                
                //Se manda a imprimir el arreglo
                Console.WriteLine(array[i]);
            }
        }
        public static void ejercicio2()
        {
            Console.WriteLine("\n******* Ejercicio 2 *******");
            //Se crea un arreglo donde guardar los números
            int[] array = new int[101];
            
            //Se crea un ciclo for para asignar el número del arreglo
            for (int i = 1; i <= 100; i++)
            {
                //Al valor del arreglo se le asigna el valor de i
                array[i] = i;

                //Se agraga un if con una condicion para saber si es
                //divisible entre 2 hasta llegar a 0 y, por lo tanto,
                //saber si es un número par
                if (array[i] % 2 == 0)
                {
                    //En el caso de que si sea par, se manda a imprimir
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void ejercicio3()
        {
            Console.WriteLine("\n******* Ejercicio 3 *******");
            //Se crea un arreglo donde guardar los números
            int[] array = new int[102];
            
            //Se crea un ciclo for para asignar el número del arreglo
            for (int i = 0; i <= 100; i++)
            {
                //Al valor del arreglo se le asigna el valor de i
                array[i] = i;
                
                //Se agraga un if con una condicion para saber si es
                //divisible entre 3 hasta llegar a 0
                if (array[i] % 3 == 0)
                {
                    //En el caso de que si se cumpla la condició,
                    //se manda a imprimir.
                    Console.WriteLine(array[i]);
                }
            }
        }
        public static void ejercicio4()
        {
            Console.WriteLine("\n******* Ejercicio 4 *******");
            //Se crea un arreglo donde guardar los números aleatorios
            int[] n_al = new int[10];
            
            //Se crea un arreglo donde guardar los números
            //resultantes de los aleatorios multiplicados por 0.5
            double[] n_m = new double[10];
            
            //Se crea un random
            Random aleatorios = new Random();
            
            //Se crea un ciclo for para asignar el número de los arreglos
            for (int i = 0; i < 10; i++)
            {
                //Al valor del arreglo se le asigna un número aleatorio
                //en el rango de 50 a 100
                n_al[i] = aleatorios.Next(50, 100);

                //Al valor del arreglo se le asigna el resultado del 
                //número aleatorio por 0.5
                n_m[i] = n_al[i] * 0.5;

                //Se mandan a imprimir ambos arreglos
                Console.WriteLine(n_al[i] + "\t" + n_m[i]);
            }
        }
        public static void ejercicio5()
        {
            Console.WriteLine("\n******* Ejercicio 5 *******");
            //Se crea un contador de números enteros con el
            //nombre de suma y un valor de 0
            int suma = 0;

            //Se crea un arreglo donde guardar los números
            int[] numeros = new int[41];

            //Se crea un ciclo for para asignar el número de los arreglos
            for (int i = 1; i <= 40; i++)
            {
                //Al valor del arreglo se le asigna el valor de i
                numeros[i] = i;

                //Se agraga un if con una condicion para saber si es
                //divisible entre 2 hasta llegar a 0 y, por lo tanto,
                //saber si es un número par
                if (numeros[i] % 2 == 0)
                {
                    //En el caso de que si sea par, se manda a imprimir
                    Console.WriteLine(numeros[i]);

                    //Se le suma al cantador el valor del arreglo que
                    //cumple la condición para tener la suma total de
                    //estos hasta que se acabe el ciclo
                    suma = suma + numeros[i];
                }
            }
            //Se manda a imprimir un mensaje y el valor del contador al
            //finalizar el ciclo
            Console.WriteLine("La suma de los primeros 20 números es " + suma);
        }
        public static void ejercicio6()
        {
            Console.WriteLine("\n******* Ejercicio 6 *******");
            //Se crea un arreglo donde guardar los números
            int[] numeros = new int[5];

            //Se crea un contador de números enteros con el
            //nombre de suma y un valor de 0
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
        public static void ejercicio9()
        {
            Console.WriteLine("\n******* Ejercicio 9 *******");
            string texto1, texto2;
            int cont = 0;
            Console.WriteLine("Introduce el primer texto:");
            texto1 = Console.ReadLine();
            int[] letras_t1 = new int[texto1.Length];
            Console.WriteLine("Introduce el segundo texto:");
            texto2 = Console.ReadLine();
            int[] letras_t2 = new int[texto2.Length];
            if (texto1.Length == texto2.Length)
            {
                for (int i = 0; i < texto1.Length; i++)
                {
                    letras_t2[i] = texto2[i];
                    letras_t1[i] = texto1[i];
                    if (letras_t1[i] == letras_t2[i])
                    {
                        cont = cont + 1;
                    }
                }
                if (cont == texto1.Length)
                {
                    Console.WriteLine("La frase es la misma.");
                }
                else
                {
                    Console.WriteLine("La frase no es la misma.");
                }
            }
        }
        public static void otra_opcion()
        {
            //Abre una nueva ventana donde iniciar otra vez el programa.
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Cierra el programa actual.
            Environment.Exit(0);
        }
    }
}
