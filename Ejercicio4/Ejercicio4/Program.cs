using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) // Bucle infinito para permitir múltiples intentos
            {
                Console.Write("Ingrese un número para verificar si es primo o digite cualquier letra para salir: ");
                string input = Console.ReadLine();

                // Verificar si la entrada es un número válido
                if (int.TryParse(input, out int num))
                {
                    if (EsPrimo(num))
                    {
                        Console.WriteLine($"{num} es un número primo.");
                    }
                    else
                    {
                        Console.WriteLine($"{num} no es un número primo.");
                    }
                }
                else
                {
                    Console.WriteLine("Saliendo del programa.");
                    break; // Salir del bucle si la entrada no es un número
                }

                Console.WriteLine(); // Salto de línea para mejor legibilidad
            }

            Console.WriteLine("Presione cualquier tecla para salir.");
            Console.ReadKey(); // Esperar a que el usuario presione una tecla antes de cerrar la consola
        }

        static bool EsPrimo(int num)
        {
            // Los números menores o iguales a 1 no son primos
            if (num <= 1)
            {
                return false;
            }

            // Verificar si el número es divisible por algún número desde 2 hasta la raíz cuadrada del número
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false; // No es primo si se encuentra un divisor
                }
            }

            return true; // Si no se encontraron divisores, es primo
        }
    }
}
