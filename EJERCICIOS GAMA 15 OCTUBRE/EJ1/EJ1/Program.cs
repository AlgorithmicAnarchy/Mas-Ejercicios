using System;

namespace EJ1
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            Console.WriteLine("Cuantos numeros quieres?");
            numerosIng = int.Parse(Console.ReadLine());

            int[] numerosE = new int[numerosIng];

            for (int i = 0; i < numerosIng; i++)
            {
                Console.WriteLine($"\nInserta el numero {i + 1}:");
                numerosE[i] = int.Parse(Console.ReadLine());

                if (numerosE[i] > 0) numerosPositivos++;
                else numerosNegativos++;

                if (numerosE[i] % 2 == 1) numerosPares++;
                else numerosImpares++;
            }

            Console.WriteLine("Cantidad total de numeros: {0}", numerosIng);
            Console.WriteLine("Cantidad de numeros pares: {0}", numerosPares);
            Console.WriteLine("Cantidad de numeros impares: {0}", numerosImpares);
            Console.WriteLine("Cantidad de numeros positivos: {0}", numerosPositivos);
            Console.WriteLine("Cantidad de numeros negativos: {0}", numerosNegativos);

        }

        static int numerosIng;

        static int numerosPositivos = 0;
        static int numerosNegativos = 0;

        static int numerosPares = 0;
        static int numerosImpares = 0;
    }
}