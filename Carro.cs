using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Carro : IVehiculo
    {
        private int ruedas { get; set; }
        void IVehiculo.conducir()
        {
            Console.WriteLine("Conduciendo mi carro");
        }

        int IVehiculo.numeroRuedas()
        {
            ruedas = 4;
            return ruedas;
        }
    }
}
