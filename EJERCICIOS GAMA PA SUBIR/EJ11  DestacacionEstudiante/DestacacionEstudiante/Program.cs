using System;

namespace DestacacionEstudiante
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

            Console.WriteLine($"Promedio: {promedio:F2}");

            string situacion;

            if (promedio >= 90 && promedio <= 100) situacion = "Excelente";
            else if (promedio >= 80 && promedio <= 89) situacion = "Muy bueno";
            else if (promedio >= 75 && promedio <= 79) situacion = "Bueno";
            else if (promedio >= 70 && promedio <= 74) situacion = "Regular";
            else situacion = "Deficiente";

            Console.WriteLine($"Situación del estudiante: {situacion}");
        }
    }
}
