using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IVehiculo[] vehiculos = new IVehiculo[2];
            vehiculos[0] = new Carro();
            vehiculos[1] = new Moto();

            foreach (IVehiculo v in vehiculos) {             
                v.conducir();
                Console.WriteLine(" voy rodando en " + v.numeroRuedas() + " Ruedas ");
            }
        }
    }
}
