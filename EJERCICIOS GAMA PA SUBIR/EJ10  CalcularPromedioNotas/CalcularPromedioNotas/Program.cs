using System;

namespace CalcularPromedioNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            CalcularNota();
        }

        static void CalcularNota()
        {
            Console.WriteLine("Bienvenido a ToDaKi");

            Console.WriteLine("\nInserta la primera nota:");
            double nota1 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInserta la segunda nota:");
            double nota2 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInserta la tercera nota:");
            double nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("\nInserta la cuarta nota:");
            double nota4 = double.Parse(Console.ReadLine());

            double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

            if (promedio >= 70)
            {
                Console.WriteLine("Este estudiante ha pasado el año escolar.");
            }
            else
            {
                Console.WriteLine("Este estudiante ha reprobado.");
            }

            Console.WriteLine($"Con un promedio de {promedio:F2}");
        }
    }
}
