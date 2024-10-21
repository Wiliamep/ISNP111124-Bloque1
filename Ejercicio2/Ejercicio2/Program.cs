using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.Write("Ingrese un número entre 1 y 10 para ver su tabla de multiplicar (0 para salir): ");
                num = int.Parse(Console.ReadLine());

                if (num >= 1 && num <= 10)
                {
                    Console.WriteLine($"\nTabla de multiplicar del {num}:");
                    for (int i = 1; i <= 10; i++)
                    {
                        Console.WriteLine($"{num} x {i} = {num * i}");
                    }
                }
                else if (num != 0)
                {
                    Console.WriteLine("Número fuera del rango. Intente de nuevo.");
                }

                Console.WriteLine(); // Línea en blanco para mejor legibilidad
            } while (num != 0);
        }
    }
}
