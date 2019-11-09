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

            //Se crea una variable de tipo double
            double media;


            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Dame un número:");

                //Al valor del arreglo se le asigna un número ingresado por teclado
                numeros[i] = int.Parse(Console.ReadLine());

                //Se le suma al cantador el valor del arreglo el número 
                //ingresado por teclado en cada ciclo hasta que este llegue a su fin
                suma = suma + numeros[i];
            }
            //A la variable media se le da el valor del contador dividido
            //entre 5, que es la cantidad veces que se repitio el ciclo y
            //por lo tanto, la cantidad de números ingresados
            media = (double)suma / 5;

            //Se manda a imprimir un mensaje y el valor de la media.
            Console.WriteLine("La media aritmetica es: " + media);
        }
        public static void ejercicio7()
        {
            Console.WriteLine("\n******* Ejercicio 7 *******");
            //Se crean dos contadores, uno para la suma de números
            //positivos y otro para la suma de números negativos
            int suma_p = 0, suma_n = 0;

            //Se crea un arreglo donde guardar los números
            int[] numeros = new int[7];

            //Se asignan valores a cada una de los arreglos
            numeros[0] = -2;
            numeros[1] = 5;
            numeros[2] = 8;
            numeros[3] = -9;
            numeros[4] = 10;
            numeros[5] = 15;
            numeros[6] = -4;

            //Se crea un for para clasificar los números
            for (int i = 0; i < 7; i++)
            {
                //Se imprimen los números
                Console.WriteLine(numeros[i]);

                //Se crea un if con la condición de que si el número que
                //esta en el arreglo indicado es menor a 0, tiene que
                //realizar una acción
                if (numeros[i] < 0)
                {
                    //Se suma el número al valor de suma_n
                    suma_n = suma_n + numeros[i];
                }
                //Si el número no es menor a 0, se realiza una acción
                //diferente
                else
                {
                    //Se suma el número al valor de suma_p
                    suma_p = suma_p + numeros[i];
                }
            }
            //Con un mesaje, se manda a imprimir el valor de suma_p y suma_n
            Console.WriteLine("La suma de los positivos es " + suma_p);
            Console.WriteLine("La suma de los negativos es " + suma_n);
        }
        public static void ejercicio8()
        {
            Console.WriteLine("\n******* Ejercicio 8 *******");
            string frase;
            //Contador de vocales
            int vocales = 0;
            Console.WriteLine("Introduce una frase:");
            frase = Console.ReadLine();
            //Se crea un arreglo donde guardar las letras
            int[] letras = new int[frase.Length];

            //Se crea un for que se repita mientras sea menor a la cantidad
            //de letras de la frase ingresada.
            for (int i = 0; i < frase.Length; i++)
            {
                //Asignamos valores a los arreglos
                letras[i] = frase[i];

                //Ponemos como condición que si la letra es una vocal (a,e,i,o,u),
                //realice una acción
                if ((letras[i] == 'a') || (letras[i] == 'e') || (letras[i] == 'i') || (letras[i] == 'o') || (letras[i] == 'u'))
                {
                    //Se suma uno al valor de vocales
                    vocales = vocales + 1;
                }
                //Este else if es para que tambien identifique a las vocales en mayusculas
                else if ((letras[i] == 'A') || (letras[i] == 'E') || (letras[i] == 'I') || (letras[i] == 'O') || (letras[i] == 'U'))
                {
                    vocales = vocales + 1;
                }
            }
            //Imprimir un mensaje junto al valor del contador vocales
            Console.WriteLine("Su frase tiene " + vocales + " vocales.");
        }
        public static void ejercicio9()
        {
            Console.WriteLine("\n******* Ejercicio 9 *******");
            string texto1, texto2;
            int cont = 0;
            Console.WriteLine("Introduce el primer texto:");
            texto1 = Console.ReadLine();
            //Se crea un arreglo donde guardar las letras del primer texto
            int[] letras_t1 = new int[texto1.Length];

            Console.WriteLine("Introduce el segundo texto:");
            texto2 = Console.ReadLine();
            //Se crea un arreglo donde guardar las letras del segundo texto
            int[] letras_t2 = new int[texto2.Length];
            
            //Si el primer texto y el segundo tienen la misma
            //longitud, se realiza una acción
            if (texto1.Length == texto2.Length)
            {
                //Se abre un ciclo que se repita mientras sea menor a 
                //la longitud del primer texto (dado que si la condición
                //fue cumplida en este paso, también se puede usar
                //el segundo texto como limitante)
                for (int i = 0; i < texto1.Length; i++)
                {
                    //Asignamos valores a los arreglos
                    letras_t2[i] = texto2[i];
                    letras_t1[i] = texto1[i];

                    //Asignamos una condición de si la letra señalada del
                    //primer texto es igual a la que ocupa su lugar en el
                    //segundo texto, realice una acción
                    if (letras_t1[i] == letras_t2[i])
                    {
                        //Se suma uno en el contador (para saber cuantas
                        //letras coinciden)
                        cont = cont + 1;
                    }
                }
                //Si el valor del contador termina resultando ser que la
                //longitud del primer texto, se realiza una acción
                if (cont == texto1.Length)
                {
                    //Se manda un mensaje diciendo que son la misma frase
                    Console.WriteLine("La frase es la misma.");
                }
                //Si el valor del contador no termina resultando ser que la
                //longitud del primer texto, se realiza una acción
                else
                {
                    //Se manda un mensaje diciendo que no son la misma frase
                    Console.WriteLine("La frase no es la misma.");
                }
            }
            //Si el primer texto y el segundo no tienen la misma
            //longitud, se realiza una acción
            else
            {
                //Se manda un mensaje diciendo que no son la misma frase
                Console.WriteLine("La frase no es la misma.");
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
