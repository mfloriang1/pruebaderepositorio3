using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareauno
{
    class Program
    {
        static void Main(string[] args)

        {
            //color de fondo y fuente de nuestro programa en consola
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            //titulo
            Console.WriteLine("\n\t|MATRIZ DADA|");
            //declafracion de las variables que utilizaremos en nuestro programa
            int fila = 4;
            int columna = 4;
            int[,] matriz = { { 1, 1, 1, 1 },
                              { 1, 1, 1, 1},
                              { 1, 1, 0, 1},
                              { 1, 1, 1, 1} };

            
            int[,] matriz2 = new int[fila, columna];
            int f = 0;
            int c = 0;
            for (int i = 0; i < fila; i++)
            {
                for (int j = 0; j < columna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                    if (matriz[i, j] == 0)
                    {
                        f = i;
                        c = j;
                        
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("\n\t|MATRIZ RESULTANTE|");
            for (int a = 0; a < fila; a++)
            {
                for (int b = 0; b < columna; b++)
                {
                    if (a == f || b == c)
                    {
                        matriz2[a, b] = 0;
                    }
                    else
                    {
                        matriz2[a, b] = 1;
                    }
                    Console.Write(matriz2[a, b] + " ");
                }
               
                Console.WriteLine();
            }
            //Console.WriteLine(p1 + " " + p2);
            
            Console.ReadLine();
        }
    }
}
