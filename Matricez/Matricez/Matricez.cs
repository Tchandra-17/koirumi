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
                Console.WriteLine("\nIngrese el nombre del empleado " + (i + 1) + ":");
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
            Console.WriteLine("\n***\t Total de sueldos pagados por empleado en los ultimos 3 meses \t***");
            Console.WriteLine("Empleado:\t" + "1er mes \t" + "2do mes \t" + "3er mes \t" + "Total \n");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(empleados[i] + "\t\t");
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(sueldos[i,j]  + "\t\t");
                }
                Console.WriteLine(total[i] + "\n");
                if (total[i] > mayor)
                {
                    mayor = total[i];
                    nombre = empleados[i];
                }
            }
            Console.WriteLine("\nEl empleado con mayor sueldo es " + nombre + ", con un sueldo de " + mayor);
            Console.WriteLine("\n\nEscriba 1 para regresar al menú y 2 para salir.");
            int reg = int.Parse(Console.ReadLine());
            if (reg == 1)
            {
                otra_opcion();
            }
            else
            {
                Environment.Exit(0);
            }

        }
        public static void ejercicio2()
        {
            Console.WriteLine("***\t***\t Ejercicio 2 \t***\t*** \n");
            int F = 0; int C = 0; int N = 0; int MI = 0; string linea;
            Console.WriteLine("Tamaño de la matriz, haga el favor de ingresar un número impar:");
            linea = Console.ReadLine();
            N = int.Parse(linea);
            N = (N % 2 == 0 ? N + 1 : N);
            string[,] MAT = new string[N + 1, N + 1];
            Console.Clear();
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    MAT[F, C] = " ";
                }
            }
            MI = N / 2 + 1;
            for (F = 1; F <= N; F++)
            {
                MAT[F, 1] = "|";
                if (F < 5)
                {
                    MAT[F, N] = "/";

                }
                else if (N > 3)
                {
                    MAT[F, (N-2)] = "/";
                    

                }
                MAT[MI, F] = "-";
                MAT[1, (F-1)] = "-/";
            }
            for (F = 1; F <= N; F++)
            {
                for (C = 1; C <= N; C++)
                {
                    Console.SetCursorPosition(C, F);
                    Console.Write(MAT[F, C]);
                }
            }
            Console.WriteLine();
            
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
