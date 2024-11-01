using System;

namespace CualEsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            DeterminarMayor();
        }

        static void DeterminarMayor()
        {
            Console.WriteLine("Cual es mayor?");

            Console.WriteLine("\nIntroduce el primer numero");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nIntroduce el segundo numero");
            int num2 = int.Parse(Console.ReadLine());

            if (num1 > num2) Console.WriteLine("El numero 1 es mayor");
            else if (num1 < num2) Console.WriteLine("El numero 2 es mayor");
            else Console.WriteLine("No hay mayor! Los dos son iguales");

        }
    }
}