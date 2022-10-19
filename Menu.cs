using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
    static class Menu
    {
        static Menu() { }

        public static void MuestraMenuPrincipal() 
        {
            byte option = 1;

            do {

                Console.WriteLine("Menu Principal");
                Console.WriteLine("1.- Vehiculos\n" +
                    "2.- Ventas\n" +
                    "3.- Reportes\n" +
                    "4.- Salir\n");
                Console.Write("Por favor seleccione una opción: ");
                option = byte.Parse(Console.ReadLine());
                Console.Clear();
                

                switch(option){ 
                
                case 1: SubMenuVehiculos(); break;
                case 2: break;
                case 3: break;
                case 4: Console.Write(" Hasta Luego, gracias por usar nuestro sistema!"); break;

                }
            } while (option != 4);
            Console.Read();
            Environment.Exit(0);
        }

        public static void SubMenuVehiculos() 
        {
            Vehiculos V = new Vehiculos();
            byte optionS = 1;

            do
            {

                Console.WriteLine("Submenu Vehiculos");
                Console.WriteLine("1.- Agregar\n" +
                    "2.- Modificar\n" +
                    "3.- Consultar\n" +
                    "4.- Volver al menu principal\n" +
                    "5.- Salir\n");
                Console.Write("Por favor seleccione una opción: ");
                optionS = byte.Parse(Console.ReadLine());
                Console.Clear();
                switch (optionS)
                {
                    case 1: V.AgregarVehiculos(); break;
                    case 2:  break;
                    case 3: V.ConsultarVehiculo(); break;
                    case 4: MuestraMenuPrincipal(); break;
                    case 5: Console.Write("Gracias por haber usado nuestro Sistema!\n" +
                                          "Hasta luego!");
                        Console.Read();
                        break;
                }
            } while (optionS != 5);
            Console.Read();
            Environment.Exit(0);
        }

        public static void SubMenuVentas()
        {
            byte optionS = 1;

            do
            {

                Console.WriteLine("Submenu Ventas");
                Console.WriteLine("1.- Agregar\n" +
                    "2.- Modificar\n" +
                    "3.- Consultar\n" +
                    "4.- Volver al menu principal\n" +
                    "5.- Salir\n");
                Console.Write("Por favor seleccione una opción: ");
                optionS = byte.Parse(Console.ReadLine());
                Console.Clear();
                switch (optionS)
                {
                    case 1: break;
                    case 2: break;
                    case 3: break;
                    case 4: MuestraMenuPrincipal(); break;
                    case 5:
                        Console.Write("Gracias por haber usado nuestro Sistema!\n" +
                                          "Hasta luego!");
                        Console.Read();
                        break;
                }
            } while (optionS != 5);
            Console.Read();
            Environment.Exit(0);
        }
    }
}
