using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            do
            {
                Console.Write("Ingrese un número para determinar si es positivo o negativo, presione 0 para salir: ");
                num = int.Parse(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("El número {0} es positivo.", num);
                }
                else if (num < 0)
                {
                    Console.WriteLine("El número {0} es negativo.", num);
                }

            } while (num != 0);
        }
    }
}
