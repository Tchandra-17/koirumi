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
            Console.WriteLine("Bienvenido. Tenemos una serie de ejercicios a realizar. \n"
                + " 1) Programa que llene un arreglo con los números enteros comprendidos entre 4 y 14. \n"
                + " 2) Programa que llene un arreglo con los números pares comprendidos entre 1 y 100. \n"
                + " 3) Programa que llene un arreglo con los números comprendidos entre 0 y 100 divisibles por 3. \n"
                + " 4) Programa que llene un arreglo de 10 números enteros aleatorios comprendidos entre 50 y 100, "
                + "copie en otro arreglo esos números multiplicados por 0,5 y muestre ambos arreglos. \n"
                + " 5) Escribir un programa que llene un arreglo con los veinte primeros números pares y calcule su suma. \n"
                + " 6) Escribir un programa que solicite cinco números, los almacene en un arreglo y luego calcule la media aritmética de esos números. \n"
                + " 7) Escribir un programa que tras asignar los números, -2, 5, 8, -9, 10, 15 y –4 a un arreglo calcule, "
                + "independientemente, la suma de los elementos positivos y negativos. \n"
                + " 8) Decir el número de vocales que aparecen en una frase introducida por el usuario. \n"
                + " 9) Escribir un programa que compare dos arreglos de caracteres y nos diga si son idénticos o no. \n"
                + "¿Cuál le gustaría realizar?");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Funsiones.ejercicio1();
                    break;
                case 2:
                    Funsiones.ejercicio2();
                    break;
                case 3:
                    Funsiones.ejercicio3();
                    break;
                case 4:
                    Funsiones.ejercicio4();
                    break;
                case 5:
                    int suma = Funsiones.ejercicio5();
                    Console.WriteLine("La suma de los primeros 20 números es " + suma);
                    break;
                case 6:
                    Funsiones.ejercicio6();
                    break;
                case 7:
                    Funsiones.ejercicio7();
                    break;
                case 8:
                    Funsiones.ejercicio8();
                    break;
                case 9:

                    break;
                default:

                    break;
            }
            Console.ReadKey();
        }
    }
}
