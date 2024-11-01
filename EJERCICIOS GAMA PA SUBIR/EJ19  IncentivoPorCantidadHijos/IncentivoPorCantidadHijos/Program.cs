using System;

namespace IncentivoPorCantidadHijos
{
    class Program
    {
        static void Main(string[] args)
        {
            IncentivoCantidadH();
        }

        static void IncentivoCantidadH()
        {
            Console.WriteLine("Bienvenido");

            Console.WriteLine("Introduce el sueldo del empleado");
            double sueldoEmpleado = double.Parse(Console.ReadLine());

            Console.WriteLine("Cuantos hijos tienes?");
            int cantidadHijos = int.Parse(Console.ReadLine());

            int aplicarIncentivo = 0; ;

            if (cantidadHijos >= 1) aplicarIncentivo = 500 * cantidadHijos;

            Console.WriteLine("El sueldo del empleado es de {0}", sueldoEmpleado);
            if (cantidadHijos >= 1) Console.WriteLine("El empleado tiene una cantidad de {0} hijo/s", cantidadHijos);
            else Console.WriteLine("El empleado no tiene hijos!");
            
            if (aplicarIncentivo > 0) Console.WriteLine("El empleado tiene un incentivo de {0}", aplicarIncentivo);
            else Console.WriteLine("El empleado no tiene incentivos!");

        }
    }
}