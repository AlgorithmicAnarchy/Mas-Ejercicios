using System;

namespace CalculadoraRaristica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora de 3 números");

            Console.WriteLine("Ingrese los 3 números");

            // Console.WriteLine("Ingrese el primero");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Ingrese el segundo");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Console.WriteLine("Ingrese el tercero");
            double num3 = Convert.ToDouble(Console.ReadLine());

            double resultadoSuma = num1 + num2 + num3;
            double resultadoMulti = num1 * num2 * num3;
            double resultadoDiv = num1 / num2 / num3;
            double resultadoResta = num1 - num2 - num3;

            Console.WriteLine("Resultado suma: {0}", resultadoSuma);
            Console.WriteLine("Resultado multiplicación: {0}", resultadoMulti);

            if (num2 == 0 || num3 == 0) Console.WriteLine("No se puede dividir por 0");
            else Console.WriteLine("Resultado división: {0}", resultadoDiv);

            Console.WriteLine("Resultado resta: {0}", resultadoResta);


        }
    }
}