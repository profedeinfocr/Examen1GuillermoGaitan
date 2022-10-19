using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
    internal class Vendedores
    {
        Dictionary<int, string> Vendedor = new Dictionary<int, string>() //Punto 4 inciso a
        {
            {1, "Raquel" },
            {2, "Magdalena" }

        };
        
        public Vendedores() { }//Punto 4 inciso b

        public void ListadoVendedores() 
        {
        foreach (var item in Vendedor) { Console.WriteLine("Código: " + item.Key + "  Nombre: " + item.Value); }
        Console.ReadLine();
        }




    }
}
