using System;

namespace EJ8
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            int numero;
            int sumatoria = 0;

            do
            {
                Console.Write("Ingresa un numero (0 para terminar): ");
                numero = int.Parse(Console.ReadLine());

                sumatoria += numero;

            } while (numero != 0);

            Console.WriteLine("La sumatoria de los numeros ingresados es: {0}", sumatoria);
        }
    }
}