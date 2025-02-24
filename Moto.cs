using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    
    internal class Moto : IVehiculo
    {
        int ruedas =  2;

        public int Ruedas { get => ruedas; set => ruedas = value; }

        void IVehiculo.conducir()
        {
            Console.WriteLine("en pura en la motico");
        }

        int IVehiculo.numeroRuedas()
        {
           return ruedas;
        }
    }
}
