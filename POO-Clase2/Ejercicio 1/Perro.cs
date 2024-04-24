using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_1
{
    public class Perro : Animal
    {
        private static string Ladrido = "Wof WOF!";

        public override void EmitirSonido()
        {
            Console.WriteLine("Se escucha a un perro a lo lejos... " + "'" + getLadrido() + "'");
        }

        public string getLadrido() {  return Ladrido; }

    }
}
