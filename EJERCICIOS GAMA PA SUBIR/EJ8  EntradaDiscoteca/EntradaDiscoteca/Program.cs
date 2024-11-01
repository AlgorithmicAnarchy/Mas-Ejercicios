using System;

namespace EntradaDiscoteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Entrada();   
        }

        static void Entrada()
        {
            Console.WriteLine("Bienvenido a ToDaKi 32");

            Console.Write("\nIngresa tu edad: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.Write("\nIngresa tu genero (M/F): ");
                genero = Console.ReadLine().ToLower();

                if (genero == "m") Console.WriteLine("Puedes pasar pagando");
                else Console.WriteLine("Puedes pasa totalmente gratis");
            }
            else
            {
                Console.WriteLine("Eres menor de edad. No puedes pasar!");
            }

        }

        static int edad;
        static string genero;
    }
}