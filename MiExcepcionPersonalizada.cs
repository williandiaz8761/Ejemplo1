using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public class MiExcepcionPersonalizada : Exception
    {
        public MiExcepcionPersonalizada(string message) : base(message)
        {
        }
    }
}
