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

            Console.WriteLine("\nIntroduce el tercer numero");
            int num3 = int.Parse(Console.ReadLine());

            if (num1 > num2 && num1 > num3) Console.WriteLine("El numero 1 es mayor");
            else if (num1 < num2 && num2 > num3) Console.WriteLine("El numero 2 es mayor");
            else if (num1 < num2 && num2 < num3) Console.WriteLine("El numero 3 es mayor");
            else Console.WriteLine("Los tres numeros son iguales");

        }
    }
}