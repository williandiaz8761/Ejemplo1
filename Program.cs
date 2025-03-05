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

            //Ejemplo manejo de excepciones 

            int numerator = 10;
            int denominator = 0;

            try
            {
                // Vamos a Dividir por cero, esto lanzará una excepción nombrada DivideByZeroException
                int result = numerator / denominator; 
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                Console.WriteLine(ex.Message);
            }

            // int otraVez = numerator / denominator;

            try
            {
                // Vamos a combertir letras en números, esto lanzará una excepción nombrada FormatException
                string input = "abc"; 
                int number = int.Parse(input); 
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: El formato del número es incorrecto.");
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Vamos a tratar de hacer una operación accediendo a un objeto nulo, esto lanzará una excepción nombrada NullReferenceException
                string text = null;
                int tam = text.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Error: Se intentó acceder a un objeto nulo.");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) // Captura otras excepciones que no sean NullReferenceException
            {
                Console.WriteLine("Se ha producido una excepción no controlada:");
                Console.WriteLine(ex.Message);
            }

            try
            {
                // Vamos a probar colocando la excepción padre o genérica
                string text = null;
                Console.WriteLine(text.Length);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ocurrio una excepción : " + ex.Message);
                Console.WriteLine("   EXception String      "+ex.ToString());
                Console.WriteLine("   Exception Type       "+ex.GetType().ToString());
            }

            try
            {
                throw new MiExcepcionPersonalizada("Con esta Excepción si ganamos el año");
            }
            catch (MiExcepcionPersonalizada ex)
            {
                Console.WriteLine("Se ha capturado una excepción personalizada:");
                Console.WriteLine(ex.Message);
            }
            finally
            {   // Este bloque se ejecutará siempre, sin importar si se lanzó una excepción
                Console.WriteLine("Se Ejecuta el bloque finally.");               
            }

        }
    }
}
