using Autolote.Models;
using System;

namespace Autolote
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Auto[] Autolote = new Auto[0]; ;
            int paAño=0, option = 0,opvender=0;
            string pNP=null, pM=null, pMod=null, pColor=null, pEs=null, opMarca=null, opModelo=null;

            while (true)
            {
            Console.WriteLine("________________________________________________________________");
            Console.WriteLine("---Autolote---");
            Console.Write("\nElija una opcion:\n[1] Ingresar Vehiculos\n[2] Ver todos los vehiculos disponibles" +
                "\n[3] Ver todos los vehiculos vendidos\n[4] Vender vehiculo\n[5] Salir\n");
            Console.Write("--->");

                option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        if (Autolote.Length.Equals(0))
                        {
                            Autolote = new Auto[2];
                            for (int i = 0; i < Autolote.Length; i++)
                            {
                                Console.WriteLine();
                                Console.WriteLine("Vehiculo {0}", i+1);
                                Console.Write("Numero de placas: ");
                                pNP = Console.ReadLine();
                                Console.Write("Marca: ");
                                pM = Console.ReadLine();
                                Console.Write("Modelo: ");
                                pMod = Console.ReadLine();
                                Console.Write("Año: ");
                                paAño = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Color: ");
                                pColor = Console.ReadLine();
                                Console.Write("Estado: ");
                                pEs = Console.ReadLine();

                                Autolote[i] = new Auto(pNP,pM,pMod,paAño,pColor,pEs);
                            }
                        }
                        else if (Autolote.Length > 0)
                        {
                            Auto[] AuxAutolote = new Auto[Autolote.Length +1];
                            for (int j = 0; j < Autolote.Length; j++)
                            {
                                AuxAutolote[j] = Autolote[j];
                            }
                            
                            Console.WriteLine("Ingrese nuevo Auto: ");
                            Console.Write("Numero de placas: ");
                            pNP = Console.ReadLine();
                            Console.Write("Marca: ");
                            pM = Console.ReadLine();
                            Console.Write("Modelo: ");
                            pMod = Console.ReadLine();
                            Console.Write("Año: ");
                            paAño = Convert.ToInt32(Console.ReadLine());
                            while (paAño < 1 || paAño > 2020)
                            {
                                Console.WriteLine("-Numero invalio- Rango entre 1 a 2020");
                                paAño = Convert.ToInt32(Console.ReadLine());
                            }
                            Console.Write("Color: ");
                            pColor = Console.ReadLine();
                            Console.Write("Estado: ");
                            pEs = Console.ReadLine();

                            AuxAutolote[Autolote.Length] = new Auto(pNP,pM,pMod,paAño,pColor,pEs);

                            Autolote = new Auto[AuxAutolote.Length];
                            for (int k = 0; k < Autolote.Length; k++)
                            {
                                Autolote[k] = AuxAutolote[k];
                            }
                        }
                            Console.ReadKey();
                        break;

                    case 2:
                        for (int i = 0; i < Autolote.Length; i++)
                        {
                            if (Autolote[i].Estado == "Disponible" || Autolote[i].Estado == "disponible")
                            {
                                Console.WriteLine("Autos Disponibles son: {0} {1}", Autolote[i].Marca, Autolote[i].Modelo);
                            }
                            
                        }
                        Console.ReadKey();
                        break;

                    case 3:
                        for (int i = 0; i < Autolote.Length; i++)
                        {
                            if (Autolote[i].Estado == "Vendido" || Autolote[i].Estado == "vendido")
                            {
                                Console.WriteLine("Autos Disponibles son: {0} {1}", Autolote[i].Marca, Autolote[i].Modelo);
                            }

                        }
                        Console.ReadKey();
                        break;

                    case 4:
                        for (int i = 0; i < Autolote.Length; i++)
                        {
                            if (Autolote[i].Estado == "Disponible" || Autolote[i].Estado == "disponible")
                            {
                                Console.WriteLine("Autos Disponibles son: {0} {1}", Autolote[i].Marca, Autolote[i].Modelo);
                            }
                        }
                        Console.Write("Escriba la Marca: ");
                        opMarca = Console.ReadLine();
                        Console.Write("Escriba Modelo: ");
                        opModelo = Console.ReadLine();


                        for (int i = 0; i < Autolote.Length; i++)
                        {
                            if (opMarca.Equals(Autolote[i].Marca) && opModelo.Equals(Autolote[i].Modelo))
                            {
                                Autolote[i].Estado = "Vendido";
                                Console.WriteLine("El auto {0} {1} ha sido {2}", Autolote[i].Marca, Autolote[i].Modelo, Autolote[i].Estado);
                            }
                            
                        }
                        Console.ReadKey();
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
        }
    
