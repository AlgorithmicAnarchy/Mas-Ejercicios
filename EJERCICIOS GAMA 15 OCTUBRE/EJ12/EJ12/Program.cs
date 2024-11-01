using System;
    
namespace EJ12
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int contadorPares = numeros.Count(n => n % 2 == 0);

            Console.WriteLine($"Cantidad de numeros pares: {contadorPares}");
        }
    }
}