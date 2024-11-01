using System;

namespace EnteroOPositivo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumeroPositivoNegativo();
        }

        static void NumeroPositivoNegativo()
        {
            Console.WriteLine("Es positivo o negativo..?");

            Console.WriteLine("\nInserta el numero:");
            int numeroPoN = int.Parse(Console.ReadLine());

            if (numeroPoN > 0) Console.WriteLine("El numero es positivo");
            else if (numeroPoN < 0) Console.WriteLine("El numero es negativo");
            else Console.WriteLine("El 0 es un numero neutro!");
        }
    }
}