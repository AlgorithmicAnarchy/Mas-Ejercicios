using System;

namespace EJ9
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            Console.Write("Ingresa el numero de filas para el triangulo: ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= filas; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}