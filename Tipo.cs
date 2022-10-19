using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Examen1GuillermoGaitan
{
    internal class Tipo
    {
        
        public Tipo() { } //Constructor de Tipo
        public virtual void Tipo_Vehiculo() { Console.WriteLine("Existen diferentes tipos de vehiculos");}//Punto 3 inciso a
        
        List<string> TipoList = new List<string>() { "Motocicleta", "Automovil" , "Dron"};//Punto 3 inciso b

        public void Listado() { 
        
        TipoList.ForEach(tip=> Console.WriteLine(tip + ", "));
            Console.ReadLine();
            Console.Clear();
        }

        public void ListadoVehiculos() { } //Punto 3 inciso c
        
        public Boolean BuscarTipo(string valor) //Punto 3 inciso d
        { Boolean result = TipoList.Contains(valor);
            return result; } //Fin de buscarTipo

    }
}
