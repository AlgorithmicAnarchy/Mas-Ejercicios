using System;

namespace EJ3
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {

            while (sumatoria < 100)
            {
                Console.WriteLine($"Ingresa el numero: ");
                contarNum = int.Parse(Console.ReadLine());

                sumatoria = sumatoria + contarNum;
            }

            Console.WriteLine("La sumatoria es igual o mayor a 100");


        }

        static int contarNum = 0;
        static int sumatoria = 0;
    }
}