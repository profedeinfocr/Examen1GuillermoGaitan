using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
     class Vehiculos
    {
        int detieneAgregar = 0;
        int[] arrayCodigo = new int[5];
        string[] arrayMarca = new string[5];
        float[] arrayCosto = new float[5];
        string[] arrayModelo = new string[5];


        public Vehiculos(){}
        public void AgregarVehiculos()
        {
            

            if (detieneAgregar > 5) {
                Console.Clear();
                Console.WriteLine(" Usted ha ingresado la información de los 5 vahiculos permitidos\n");
            }
                Console.WriteLine("Ingrese código del vehiculo #" + (detieneAgregar+1));
                arrayCodigo[detieneAgregar] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese marca del vehiculo #" + (detieneAgregar + 1));
                arrayMarca[detieneAgregar] = (Console.ReadLine());
                Console.WriteLine("Ingrese costo del vehiculo #" + (detieneAgregar + 1));
                arrayCosto[detieneAgregar] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese modelo del vehiculo #" + (detieneAgregar + 1));
                arrayModelo[detieneAgregar] = (Console.ReadLine());
                detieneAgregar++;
                Console.WriteLine("\nGracias por ingresar los datos del vehiculo #" + detieneAgregar + "\n");
                Console.WriteLine("Oprima enter para regresar al sub menu Vehiculos\n");
                Console.ReadLine();
                Console.Clear();

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
                }//Fin de if


            }//Fin de for
        }

    }
}
