using System;

namespace SueldoNetoEmpleado
{
    class Program
    {


        // pph: pago por hora
        // htb: horas trabajadas

        static void Main(string[] args)
        {
            CalcularSueldoNeto();
        }

        static void CalcularSueldoNeto()
        {

            Console.WriteLine("------------------------------------");
            Console.WriteLine("Bienvenido a ToDaKi's Center");
            Console.WriteLine("------------------------------------");


            Console.WriteLine("Ingresa cuanto ganas por hora");

            double pph = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n\nIngresa cuantas horas trabajaste");
            double htb = Convert.ToDouble(Console.ReadLine());

            // DESCUENTOS XD
            double descuentoAFP = 2.87;
            double descuentoSFS = 3.04;
            double descuentoAFPxSFS = descuentoAFP + descuentoSFS;


            double sueldoBruto = pph * htb;

            double sueldoNeto = sueldoBruto - (sueldoBruto * (descuentoAFPxSFS / 100));


            Console.WriteLine("\nEl sueldo neto del empleado es de {0}", sueldoNeto);
        }
    }
}