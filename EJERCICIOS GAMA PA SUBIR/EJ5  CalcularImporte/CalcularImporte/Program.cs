using System;

namespace CalcularImporte
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the iunaire steis!");

            Console.WriteLine("Ingresa la cantidad del artículo");
            int cantidadArticulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa el precio del artículo");
            double precioArticulo = double.Parse(Console.ReadLine());

            double importe = cantidadArticulo * precioArticulo;

            Console.WriteLine("Importe: {0}", importe);

        }
    }
}