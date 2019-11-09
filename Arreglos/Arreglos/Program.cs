using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se da una nota de bienvenida y el menú de opciones a escoger.
            Console.WriteLine("Bienvenido. Tenemos una serie de ejercicios a realizar. \n"
                + "\t 1) Programa que llene un arreglo con los números \n"
                + "\t    enteros comprendidos entre 4 y 14. \n"
                + "\t 2) Programa que llene un arreglo con los números \n"
                + "\t    pares comprendidos entre 1 y 100. \n"
                + "\t 3) Programa que llene un arreglo con los números \n"
                + "\t    comprendidos entre 0 y 100 divisibles por 3. \n"
                + "\t 4) Programa que llene un arreglo de 10 números \n"
                + "\t    enteros aleatorios comprendidos entre 50 y 100, \n"
                + "\t    copie en otro arreglo esos números multiplicados \n"
                + "\t    por 0,5 y muestre ambos arreglos. \n"
                + "\t 5) Programa que llene un arreglo con los veinte \n"
                + "\t    primeros números pares y calcule su suma. \n"
                + "\t 6) Programa que solicite cinco números, \n"
                + "\t    los almacene en un arreglo y luego calcule \n"
                + "\t    la media aritmética de esos números. \n"
                + "\t 7) Programa que tras asignar los números, \n"
                + "\t    -2, 5, 8, -9, 10, 15 y –4 a un arreglo calcule, \n"
                + "\t    independientemente, la suma de los elementos \n"
                + "\t    positivos y negativos. \n"
                + "\t 8) Decir el número de vocales que aparecen en una \n"
                + "\t    frase introducida por el usuario. \n"
                + "\t 9) Programa que compare dos arreglos \n"
                + "\t    de caracteres y nos diga si son idénticos o no. \n\n"
                + "¿Cuál le gustaría realizar?");
            int opc = int.Parse(Console.ReadLine());
            //Depende del número ingresado es la opción que se mostrara.
            switch (opc)
            {
                case 1:
                    //Se manda a llamar a la función "ejercicio1" de la clase Funciones.
                    Funsiones.ejercicio1();
                    break;
                case 2:
                    //Se manda a llamar a la función "ejercicio2" de la clase Funciones.
                    Funsiones.ejercicio2();
                    break;
                case 3:
                    //Se manda a llamar a la función "ejercicio3" de la clase Funciones.
                    Funsiones.ejercicio3();
                    break;
                case 4:
                    //Se manda a llamar a la función "ejercicio4" de la clase Funciones.
                    Funsiones.ejercicio4();
                    break;
                case 5:
                    //Se manda a llamar a la función "ejercicio5" de la clase Funciones.
                    Funsiones.ejercicio5();
                    break;
                case 6:
                    //Se manda a llamar a la función "ejercicio6" de la clase Funciones.
                    Funsiones.ejercicio6();
                    break;
                case 7:
                    //Se manda a llamar a la función "ejercicio7" de la clase Funciones.
                    Funsiones.ejercicio7();
                    break;
                case 8:
                    //Se manda a llamar a la función "ejercicio8" de la clase Funciones.
                    Funsiones.ejercicio8();
                    break;
                case 9:
                    //Se manda a llamar a la función "ejercicio9" de la clase Funciones.
                    Funsiones.ejercicio9();
                    break;
                default:
                    //Se manda a llamar a la función "otra_opcion" de la clase Funciones.
                    Funsiones.otra_opcion();
                    break;
            }
            Console.ReadKey();
        }
    }
}
