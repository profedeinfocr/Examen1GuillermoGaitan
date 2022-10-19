using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
    internal class Vehiculos
    {

        public void agregarVehiculos()
        {
            string[] arrayCodigo = new string[5];
            string[] arrayMarca = new string[5];
            float[] arrayCosto = new float[5];
            string[] arrayModelo = new string[5];
            for (int x = 0; x < arrayCodigo.Length; x++)
            {
                Console.WriteLine("Ingrese código del vehiculo #" + (x+1));
                arrayCodigo[x] = (Console.ReadLine());
                Console.WriteLine("Ingrese marca del vehiculo #" + (x + 1));
                arrayMarca[x] = (Console.ReadLine());
                Console.WriteLine("Ingrese costo del vehiculo #" + (x + 1));
                arrayCosto[x] = float.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese modelo del vehiculo #" + (x + 1));
                arrayModelo[x] = (Console.ReadLine());
             }
            Console.Clear();
            Console.WriteLine(" Usted ha ingresado la información de los 5 vahiculos permitidos\n");
            Console.WriteLine(" Esta es la informacion que usted ha ingresado:\n");

            for (int i = 0; i < arrayCodigo.Length; i++) 
            {
                Console.WriteLine("Info del vehiculo #" + (i+1));
                Console.WriteLine(arrayCodigo[i] + " " + arrayMarca[i] + " " + arrayCosto[i] + " " + arrayModelo[i]);
            }
            Console.WriteLine(" Oprima enter para regresar al sub menu Vehiculos\n");
            Console.ReadLine();
            Console.Clear();

        }//Fin de agregarVehiculo



    }
}
