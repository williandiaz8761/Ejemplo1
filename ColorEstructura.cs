using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejemplo1
{
    public struct ColorEstructura
    {
        public string Nombre { get; }
        public string CodigoHex { get; }

        // Constructor
        public ColorEstructura(string nombre, string codigoHex)
        {
            Nombre = nombre;
            CodigoHex = codigoHex;
        }

        // Método para mostrar información del color
        public void MostrarInformacion()
        {
            Console.WriteLine($"Color: {Nombre}, Código Hex: {CodigoHex}");
        }

        // Métodos estáticos para algunos colores comunes
        public static ColorEstructura Rojo => new ColorEstructura("Rojo", "#FF0000");
        public static ColorEstructura Verde => new ColorEstructura("Verde", "#00FF00");
        public static ColorEstructura Azul => new ColorEstructura("Azul", "#0000FF");
        public static ColorEstructura Amarillo => new ColorEstructura("Amarillo", "#FFFF00");
        public static ColorEstructura Negro => new ColorEstructura("Negro", "#000000");
        public static ColorEstructura Blanco => new ColorEstructura("Blanco", "#FFFFFF");

    }
}
