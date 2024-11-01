using System;

namespace EJ5
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            for (int i = 0; i < 100; i++)
            {
                sumatoria += i;
            }

            Console.WriteLine($"Promedio de lo primeros 100 numeros naturales: {sumatoria / 100}");
        }

        static int sumatoria = 0;
    }
}