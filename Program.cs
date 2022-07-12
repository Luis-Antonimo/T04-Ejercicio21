using System;

namespace T04Ejercicio21
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Escriba el día de la semana:");
            String dia = Console.ReadLine();
            switch (dia)
            {
                case "lunes":
                    Console.WriteLine("Es día laboral.");
                    break;
                case "martes":
                    Console.WriteLine("Es día laboral.");
                    break;
                case "miercoles":
                    Console.WriteLine("Es día laboral.");
                    break;
                case "jueves":
                    Console.WriteLine("Es día laboral.");
                    break;
                case "viernes":
                    Console.WriteLine("Es día laboral.");
                    break;
                case "sábado":
                    Console.WriteLine("No es día laboral.");
                    break;
                case "domingo":
                    Console.WriteLine("No es día laboral.");
                    break;
                //default se utiliza para indicar si ha habido un error 
                default:
                    Console.WriteLine("Lo que ha escrito no corresponde con un día de la semana.");
                    break;
            }
        }
    }
}