using System;

namespace EJ6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cantidad del artículo:");
            int cantidad = int.Parse(Console.ReadLine());

            Console.WriteLine("Precio del artículo:");
            double precio = double.Parse(Console.ReadLine());

            double importe = cantidad * precio;
            double itbis = importe * 0.18;
            double descuento = importe * 0.10;
            double total = importe - descuento + itbis;

            Console.WriteLine("Importe: {0:F2}", importe);
            Console.WriteLine("ITBIS: {0:F2}", itbis);
            Console.WriteLine("Descuento: {0:F2}", descuento);
            Console.WriteLine("Total: {0:F2}", total);
        }
    }
}
