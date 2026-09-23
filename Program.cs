using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicios2
{
    internal class Program
    {
        static public int[] Generar_aleatorios(int n, int Valmin, int Valmax)
        {
            int[] N = new int[n];
            Random Var_Randon= new Random();
            for (int i = 0; i < N.Length; i++)
            {
                N[i] = Var_Randon.Next(Valmin, Valmax +1);
            }
            return N;
        }
        static public void Escribir(int[] N)
        {
            for (int i = 0; i < N.Length; i++)
            {
                Console.Write("[" + N[i] + "]\t");
            }
            Console.WriteLine();
        }
        static public void Ordenar_Asc(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                for (int j = 0; j < N.Length - 1 - i; j++)
                {
                    if (N[j] > N[j + 1])
                    {
                        aux = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = aux;
                    }
                }
            }
        }
        static public void Ordenar_Des(int[] N)
        {
            int aux;
            for (int i = 0; i < N.Length - 1; i++)
            {
                for (int j = 0; j < N.Length - 1 - i; j++)
                {
                    if (N[j] < N[j + 1])
                    {
                        aux = N[j];
                        N[j] = N[j + 1];
                        N[j + 1] = aux;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************");
            Console.WriteLine("¿Cuatos numeros aleatorios deseas generar?: ");
            Console.WriteLine("**********************************************");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor mínimo: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor máximo: ");
            int max = int.Parse(Console.ReadLine());
            int[] arreglo= Generar_aleatorios(n, min, max);
            Console.WriteLine("**********************************************");
            Console.WriteLine("LISTA DE ALEATORIOS");
            Console.WriteLine("**********************************************");
            Escribir(arreglo);
            Ordenar_Asc(arreglo);
            Console.WriteLine("\n\nORDENAMIENTO ASCENDENTE");
            Escribir(arreglo);
            Ordenar_Des(arreglo);
            Console.WriteLine("\n\nORDENAMIENTO DESCENDENTE");
            Escribir(arreglo);
            Console.ReadKey();
        }
    }
}

