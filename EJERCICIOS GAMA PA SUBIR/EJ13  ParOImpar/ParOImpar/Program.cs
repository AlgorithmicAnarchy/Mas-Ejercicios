using System;

namespace ParOImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            ParOImpar();
        }

        static void ParOImpar()
        {
            Console.WriteLine("Introduce un numero");
            int numero = int.Parse(Console.ReadLine());

            string resultado = (numero % 2 == 0) ? "Es par" : "Es impar";
            Console.WriteLine(resultado);
        }
    }
}