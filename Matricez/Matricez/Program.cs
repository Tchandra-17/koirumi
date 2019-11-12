using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricez
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido. \n"
                + "Tenemos una serie de opciones a realizar: \n"
                + "\t1) Empleados y sueldo. \n"
                + "\t2) Formar la letra R en una matriz de NxN. \n"
                + "\t3) Número mayor y menor en una matriz de NxN. \n"
                + "\t4) Ordenamiento de una matriz de NxN. \n"
                + "\t5) Menores de cada columna de una matriz NxN en un vector. \n"
                + "\t6) Mayores de cada fila de una matriz NxN en un vector. \n"
                + "¿Cuál deseas realizar?");
            int opc = int.Parse(Console.ReadLine());
            switch (opc)
            {
                case 1:
                    Matricez.ejercicio1();
                    break;
                case 2:
                    Matricez.ejercicio2();
                    break;
                case 3:
                    Matricez.ejercicio3();
                    break;
                case 4:
                    Matricez.ejercicio4();
                    break;
                case 5:
                    Matricez.ejercicio5();
                    break;
                case 6:
                    Matricez.ejercicio6();
                    break;
                default:
                    Matricez.otra_opcion();
                    break;
            }
            Console.ReadKey();
        }
    }
}
