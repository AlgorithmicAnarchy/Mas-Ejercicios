using System;

namespace EJ10
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            int[] numeros = new int[10];
            int sumatoria = 0;

            for (int i = 0; i < numeros.Length; i++)
            {   
                Console.Write($"Ingresa el numero {i + 1}: ");
                numeros[i] = int.Parse(Console.ReadLine());
                sumatoria += numeros[i];
            }

            Console.WriteLine($"La suma de los 10 numeros es: {sumatoria}");
        }
    }
}