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
            vehiculos[1] = new Moto(Color.Negro);

            foreach (IVehiculo v in vehiculos) {             
                v.conducir();
                Console.WriteLine(" voy rodando en " + v.numeroRuedas() + " Ruedas ");
                if (v is Moto) { 
                    Moto moto = v as Moto;
                    Console.WriteLine("es una moto de color " + moto.getColor() +" y una estructura color "+moto.ColorConCodigo.Nombre+" codigo "+moto.ColorConCodigo.CodigoHex);
                }
            }

            Perro perro = new Perro();
            perro.HacerSonido(); 
            perro.Amamantar();
        }
    }
}
