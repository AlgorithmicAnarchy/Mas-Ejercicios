using System;

namespace EJ13
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int contadorImpares = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                if (numeros[i] % 2 != 0)
                {
                    contadorImpares++;
                }
            }

            Console.WriteLine($"Cantidad de numeros impares: {contadorImpares}");
        }
    }
}