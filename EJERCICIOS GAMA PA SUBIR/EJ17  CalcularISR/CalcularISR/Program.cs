    using System;

    namespace CalcularISR
    {
        class Program
        {
            static void Main(string[] args)
            {
                CalcularISR();
            }

            static void CalcularISR()
            {
                Console.WriteLine("Ingrese el sueldo bruto mensual del empleado:");
                double sueldoBruto = Convert.ToDouble(Console.ReadLine());

                double afp = sueldoBruto * 0.0287;
                double sfs = sueldoBruto * 0.0304;

                double salarioAnual = sueldoBruto * 12;

                double isr = 0;
                if (salarioAnual > 867123.01)
                {
                    isr = 79776 + 0.25 * (salarioAnual - 867123.01);
                }
                else if (salarioAnual > 624329.01)
                {
                    isr = 31216 + 0.20 * (salarioAnual - 624329.01);
                }
                else if (salarioAnual > 416220.01)
                {
                    isr = 0.15 * (salarioAnual - 416220.01);
                }

                if (salarioAnual <= 416220)
                {
                    Console.WriteLine("ISR: No Aplica");
                    isr = 0;
                }
                else
                {
                    Console.WriteLine("ISR anual: RD$" + isr);
                }

                double sueldoNeto = sueldoBruto - (afp + sfs + isr / 12);

                Console.WriteLine("Sueldo Bruto: RD$" + sueldoBruto);
                Console.WriteLine("AFP: RD$" + afp);
                Console.WriteLine("SFS: RD$" + sfs);
                Console.WriteLine("Sueldo Neto: RD$" + sueldoNeto);
            }
        }
    }