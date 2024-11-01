using System;

namespace EJ7
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            Console.Write("Ingresa el numero para el cual deseas ver la tabla de multiplicar: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Tabla de multiplicar del {numero}:");

            for (int i = 1; i <= 12; i++)
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");
            }
        }

    }
}