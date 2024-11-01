using System;

namespace EJ2
{

    /*
     2.- Crear un programa que lea una contraseña, si es incorrecta, mostrar un mensaje
que lo indique y tenga como máximo 3 intentos, luego después de esos intentos,
mostrar un mensaje indicando que ha agotado el numero de intentos y el programa
debe terminar

*/
    class Program
    {
        static void Main(string[] args)
        {
            Contrasena();
        }

        static void Contrasena()
        {

            Console.WriteLine("Ingresa tu contrasena");
            string contrasenaPuesta = Console.ReadLine();
            int contador = 0;


            while (contrasenaPuesta != contrasenaUs && contador < 2)
            {
                contador++;
                Console.WriteLine("Contrasena incorrecta ingresela nuevamente!");
                contrasenaPuesta = Console.ReadLine();
            }


            bool v = (contador == 2);
            string contadorCondicion = v ? "Intentos acabados. Vuelva mas tarde" : "Contrasena correcta. Ingresando..";
            Console.WriteLine(contadorCondicion);


        }

        static string contrasenaUs = "1234";
    }
}