using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public abstract class VehiculoAbstract : IVehiculo
    {
        private ColorEstructura colorConCodigo;

        public ColorEstructura ColorConCodigo { get => colorConCodigo; set => colorConCodigo = value; }

        public abstract void conducir();
        public abstract int numeroRuedas();
        public abstract Color getColor();
    }
}
