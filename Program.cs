using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Desarrollar una aplicación que lea desde teclado un número e imprima todos los números para los cuales es divisible.
//Ejemplo: 50, es divisble para 1,2,5,10,25,50.

namespace EJERCICIO_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;

            Console.Write("Ingrese un numero mayor a 0: ");
            n = int.Parse(Console.ReadLine());
            while (n <= 0)
            {
                Console.Write("El numero debe ser mayor a 0: ");
                n = int.Parse(Console.ReadLine());
            }

            Divisores(n);

            Console.ReadKey();
        }
        static void Divisores(int x)
        {
            if (x == 1)
            {
                Console.WriteLine("El numero es divisible para 1");
            }
            else
            {
                Console.Write($"{x} es divisible para: ");
                for (int i = 1; i <= x; i++)
                {
                    if (x % i == 0)
                    {
                        Console.Write(i);
                    }
                    if (i != x && x % i == 0)
                    {
                        Console.Write(", ");
                    }
                    if (i == x && x % i == 0)
                    {
                        Console.Write(". ");
                    }
                }
            }
        }
    }
}
