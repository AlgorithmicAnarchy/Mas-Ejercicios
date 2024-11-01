using System;

namespace CorrespondenciaIncentivo
{
    class Program
    {
        static void Main(string[] args)
        {
            Incentivo();
        }

        static void Incentivo()
        {
            Console.WriteLine("Ingrese la producción del lunes:");
            int lunes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del martes:");
            int martes = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del miércoles:");
            int miercoles = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del jueves:");
            int jueves = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la producción del viernes:");
            int viernes = Convert.ToInt32(Console.ReadLine());

            int totalProduccion = lunes + martes + miercoles + jueves + viernes;
            double promedio = totalProduccion / 5.0;

            if (promedio >= 20000)
            {
                Console.WriteLine("Incentivo: RD$3000");
            }
            else
            {
                Console.WriteLine("Incentivo: N/A");
            }

            Console.WriteLine("Total de la producción: " + totalProduccion);
            Console.WriteLine("Promedio de la producción: " + promedio);

        }
    }
}