using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace SOPA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int n = rnd.Next(6,16);
            int m = rnd.Next(6,16);
            char[,] matriz = new char[n,m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matriz[i, j] = (char) rnd.Next(97, 123);
                }
            }

            Console.WriteLine($"La matriz generada de tamaño {n}x{m} es:");
            int cc = 0;
            foreach (char i in matriz)
            {
                Console.Write(i+"  ");
                cc++;
                if (cc == m)
                {
                    Console.WriteLine();
                    cc=0;
                }
            }

            Console.Write("Ingrese una frase: ");
            string frase = Console.ReadLine();
            frase = frase.ToLower();
            string[] palabraseparada=frase.Split(' ');

            Console.Write("Una de las palabras de la frase se encuentran en las filas: ");
            BuscadorFilas(n,m,palabraseparada,matriz);
            Console.WriteLine();
            Console.Write("Una de las palabras de la frase se encuentran en las columnas: ");
            BuscadorColumnas(n, m, palabraseparada, matriz);
            Console.WriteLine();

            Console.ReadKey();
        }
        static void BuscadorFilas(int x,int y,string[] palabras, char[,] mat)
        {
            int iniciofila = 0;
            string fila = "";
            
            while (iniciofila < x)
            {
                for (int i = 0;i < y; i++)
                {
                    fila += mat[iniciofila,i];
                }
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (fila.IndexOf(palabras[i]) != -1)
                    {
                        Console.Write(iniciofila+1);
                        if (iniciofila < x)
                        {
                            Console.Write(" - ");
                        }
                        break;
                    }
                }
                iniciofila++;
                fila = "";
            }

        }
        static void BuscadorColumnas(int x, int y, string[] palabras, char[,] mat)
        {
            int iniciocolumnas = 0;
            string columna = "";

            while (iniciocolumnas < y)
            {
                for (int i = 0; i < x; i++)
                {
                    columna += mat[i, iniciocolumnas];
                }
                for (int i = 0; i < palabras.Length; i++)
                {
                    if (columna.IndexOf(palabras[i]) != -1)
                    {
                        Console.Write(iniciocolumnas + 1);
                        if (iniciocolumnas < y)
                        {
                            Console.Write(" - ");
                        }
                        break;
                    }
                }
                iniciocolumnas++;
                columna = "";
            }

        }
    }
}
