using System;

namespace AplicarDescuentoArticulo
{
    class Program
    {
        static void Main(string[] args)
        {
            AplicarDescuento();
        }

        static void AplicarDescuento()
        {
            Console.WriteLine("Bienvenido a ToDaKi's Shop");

            Console.WriteLine("\nIngresa el precio del artículo:");
            double precioArticulo = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (precioArticulo >= 1000 && precioArticulo < 5001) descuento = 0.03;
            else if (precioArticulo >= 5001 && precioArticulo < 10001) descuento = 0.05;
            else if (precioArticulo >= 10001 && precioArticulo < 15001) descuento = 0.08;
            else if (precioArticulo >= 15001 && precioArticulo <= 20000) descuento = 0.10;

            double totalAPagar = precioArticulo - (precioArticulo * descuento);

            Console.WriteLine("\nDescuento aplicado: {0}%", descuento * 100);
            Console.WriteLine("Total a pagar: {0}", totalAPagar);
        }
    }
}

