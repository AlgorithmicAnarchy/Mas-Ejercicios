using System;

namespace PromedioDe5Numeros
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculadora de promedios");

            Console.WriteLine("Ingrese el primer numero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el segundo numero");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el tercero numero");
            double num3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el cuarto numero");
            double num4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el quinto numero");
            double num5 = Convert.ToDouble(Console.ReadLine());


            double promedioNum = (num1 + num2 + num3 + num4 + num5) / 5;

            Console.WriteLine("Tu promedio es de: {0}", promedioNum);

        }
    }
}