using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
     class Vehiculos
    {
        Tipo tipos = new Tipo();
        protected int detieneAgregar = 0;
        protected int[] arrayCodigo = new int[5];
        protected string[] arrayMarca = new string[5];
        protected float[] arrayCosto = new float[5];
        protected string[] arrayModelo = new string[5];


        public Vehiculos(){}
        public void AgregarVehiculos()
        {
            

            if (detieneAgregar < 5) {

                Console.WriteLine("Ingrese código del vehiculo #" + (detieneAgregar + 1));
                arrayCodigo[detieneAgregar] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese marca del vehiculo #" + (detieneAgregar + 1));
                arrayMarca[detieneAgregar] = (Console.ReadLine());
                Console.WriteLine("Ingrese costo del vehiculo #" + (detieneAgregar + 1));
                arrayCosto[detieneAgregar] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese modelo del vehiculo #" + (detieneAgregar + 1));
                arrayModelo[detieneAgregar] = (Console.ReadLine());
                detieneAgregar++;
                Console.WriteLine("\nGracias por ingresar los datos del vehiculo #" + detieneAgregar);
                Console.WriteLine("Oprima enter para regresar al sub menu Vehiculos\n");
                Console.ReadLine();
                Console.Clear();


            }
            if (detieneAgregar >= 5)
            {
                Console.Clear();
                Console.WriteLine(" Usted ha ingresado la información de los 5 vahiculos permitidos");
                Console.WriteLine(" Oprima enter para regresar al submenu vehiculos\n");
                Console.ReadLine();
                Console.Clear();
            }

            /*Console.WriteLine(" Esta es la informacion que usted ha ingresado:\n");

            for (int i = 0; i < arrayCodigo.Length; i++) 
            {
                Console.WriteLine("Info del vehiculo #" + (i+1));
                Console.WriteLine(arrayCodigo[i] + " " + arrayMarca[i] + " " + arrayCosto[i] + " " + arrayModelo[i]);
            }
            Console.WriteLine("\nOprima enter para regresar al sub menu Vehiculos\n");
            Console.ReadLine();
            Console.Clear();*/

        }//Fin de agregarVehiculo

        public void ModificarVehiculo()
        {
            int codigo;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el código del vehículo que desea modificar: ");
            codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {

                if (codigo == arrayCodigo[i])
                {
                    Console.WriteLine("Ingrese marca del vehiculo código #" + (i + 1));
                    arrayMarca[i] = (Console.ReadLine());
                    Console.WriteLine("Ingrese costo del vehiculo código #" + (i + 1));
                    arrayCosto[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese modelo del vehiculo código #" + (i + 1));
                    arrayModelo[i] = (Console.ReadLine());
                    Console.WriteLine("Se han modificado los datos del vehiculo código #" + (i + 1));
                    Console.ReadLine();
                    Console.Clear();
                }//Fin de if


            }//Fin de for
        }//Fin de Consultar vehiculo
        public void ConsultarVehiculo() 
        {
            int codigo;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el código del vehículo que desea consultar: ");
            codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {

                if (codigo == arrayCodigo[i])
                {
                Console.WriteLine("Marca: " + arrayMarca[i]);
                Console.WriteLine("Modelo: " + arrayModelo[i]);
                Console.WriteLine("Costo: " + arrayCosto[i]);
                Console.ReadLine();
                Console.Clear();
                Existe = true;
                }//Fin de if
            }//Fin de for
            

            if (!Existe)
            { Console.WriteLine("El vehículo consultado no existe en el sistema ");
                Console.ReadLine();
                Console.Clear();}


        }//Fin de Consultar vehiculo


        public void VenderVehiculo()
        {
            int codigo;
            Boolean Existe = false;
            Console.WriteLine("Ingrese el código del vehículo que desea vender: ");
            codigo = int.Parse(Console.ReadLine());
            for (int i = 0; i < 5; i++)
            {

                if (codigo == arrayCodigo[i])
                {
                    Console.WriteLine("Marca: " + arrayMarca[i]);
                    Console.WriteLine("Modelo: " + arrayModelo[i]);
                    Console.WriteLine("Costo: " + arrayCosto[i]);
                    Console.WriteLine("Ingrese el tipo de vehiculo: ");
                    if (tipos.BuscarTipo(Console.ReadLine())) 
                    {
                    Console.WriteLine("El tipo Existe ");
                    }
                    else { Console.WriteLine("El tipo no existe"); }

                    Console.ReadLine();
                    Console.Clear();
                    Existe = true;
                }//Fin de if
            }//Fin de for


            if (!Existe)
            {
                Console.WriteLine("El vehículo consultado no existe en el sistema ");
                Console.ReadLine();
                Console.Clear();
            }


        }//Fin de Consultar vehiculo


    }
}
