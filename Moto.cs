using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    
    public class Moto : VehiculoAbstract
    {
        private int ruedas =  2;
        private Color color;

        public int Ruedas { get => ruedas; set => ruedas = value; }
        public Color Color { get => color; set => color = value; }
        public Moto(Color color) {
            this.color = color;
            this.ColorConCodigo = ColorEstructura.Blanco;
        }

        public override void conducir()
        {
            Console.WriteLine("En prura en la motico ");
        }

        public override Color getColor()
        {
            return Color;
        }

        public override int numeroRuedas()
        {
            return Ruedas;
        }
       
    }
}
