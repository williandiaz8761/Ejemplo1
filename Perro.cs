using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class Perro : IAnimal, IMamifero
    {
        public void HacerSonido()
        {
            Console.WriteLine("El perro ladra: ¡Guau!");
        }

        public void Amamantar()
        {
            Console.WriteLine("El perro está amamantando a sus cachorros.");
        }
    }
}
