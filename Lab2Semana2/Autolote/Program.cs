using Autolote.Models;
using System;

namespace Autolote
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto A1;
            int option = 0;

            Console.WriteLine("---Autolote---");
            Console.Write("\nElija una opcion:\n[1] Ingresar Vehiculos\n[2] Ver todos los vehiculos disponibles" +
                "\n[3] Ver todos los vehiculos vendidos\n[4] Vender vehiculo\n[5] Salir\n");
            Console.Write("--->");
            option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    break;

                case 2:
                    break;

                case 3:
                    break;

                case 4:
                    break;

                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Entrada no valida");
                    break;
            }

        }
    }
}
