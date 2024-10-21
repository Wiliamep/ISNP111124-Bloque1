using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            int suma = 0;

            Console.WriteLine("Este programa suma números positivos.");
            Console.WriteLine("Presione 0 para obtener la suma.");

            while (true) // Bucle infinito que se detendrá cuando se ingrese 0
            {
                Console.Write("Ingrese un número positivo: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    suma += num; // Sumar solo si el número es positivo
                }
                else if (num == 0)
                {
                    break; // Salir del bucle si se ingresa 0
                }
                else
                {
                    Console.WriteLine("Solo se permiten números positivos. Intente de nuevo.");
                }
            }

            // Mostrar la suma después de que se finaliza el ingreso de números
            Console.WriteLine($"La suma de los números ingresados es: {suma}");
            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }
    }
}
