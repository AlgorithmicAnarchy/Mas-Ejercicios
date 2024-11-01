using System;

namespace EJ14
{
    class Program
    {
        static void Main(string[] args) { Nombre(); }

        static void Nombre()
        {
            char[] caracteres = { 'g', 'e', 'a', 'd', 'f', 'c', 'b' };

            Console.WriteLine("Arreglo original:");
            MostrarArreglo(caracteres);

            Array.Sort(caracteres);

            Console.WriteLine("\nArreglo ordenado:");
            MostrarArreglo(caracteres);
        }

        static void MostrarArreglo(char[] arr)
        {
            foreach (char c in arr)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();
        }
    }
}