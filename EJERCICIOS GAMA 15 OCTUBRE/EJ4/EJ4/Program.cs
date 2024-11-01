using System;

namespace EJ4
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"Cargando... {i + 1}");
                sumatoria += i;
            }

            Console.WriteLine("Sumatoria total: {0}", sumatoria);
        }

        static int sumatoria = 0;
    }
}