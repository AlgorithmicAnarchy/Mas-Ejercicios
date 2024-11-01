using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre ()
        {
            for (int i = 1; i < 30; i++)
            {
                numerosImpares = i;

                if (numerosImpares % 2 == 1) { Console.WriteLine(numerosImpares); }
                else Console.WriteLine();
            }

        }

        static int numerosImpares;
    }
}