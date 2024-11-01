using System;

namespace EJ11
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            Console.Write("Ingresa la cantidad de numeros que quieres multiplicar: ");
            int cantidad = int.Parse(Console.ReadLine());

            double[] numeros = new double[cantidad];
            double producto = 1;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Ingresa el numero {i + 1}: ");
                numeros[i] = double.Parse(Console.ReadLine());

                producto *= numeros[i];
            }

            Console.WriteLine($"El producto de los numeros es: {producto}");
        }
    }
}