using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matricez
{
    class Matricez
    {
        public static void ejercicio1()
        {
            Console.WriteLine("***\t***\t Ejercicio 1 \t***\t***");
            string[] empleados = new string[4];
            int[,] sueldos = new int[4, 3];
            int[] total = new int[4];
            for (int i = 0; i < 4; i++)
            {
                int suma = 0;
                Console.WriteLine("\nIngrese el nombre del empleado:");
                empleados[i] = Console.ReadLine();
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Ingresa el sueldo " + (j + 1) + ":");
                    sueldos[i, j] = int.Parse(Console.ReadLine());
                    suma = suma + sueldos[i, j];
                }
                total[i] = suma;
            }
            int mayor = total[0];
            string nombre = empleados[0];
            Console.WriteLine("\nTotal de sueldos pagados por empleado:");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine(empleados[i] + "\t\t" + total[i]);
                if (total[i] > mayor)
                {
                    mayor = total[i];
                    nombre = empleados[i];
                }
            }
            Console.WriteLine("El empleado con mayor sueldo es " + nombre + ", con un sueldo de " + mayor);
        }
        public static void ejercicio2()
        {

        }
        public static void ejercicio3()
        {

        }
        public static void ejercicio4()
        {

        }
        public static void ejercicio5()
        {

        }
        public static void ejercicio6()
        {

        }
        public static void otra_opcion()
        {
            // Abre una nueva ventana donde iniciar otra vez el programa.
            System.Diagnostics.Process.Start(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //Cierra el programa actual.
            Environment.Exit(0);
        }
    }
}
