using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_1
{
    public class Gato : Animal
    {
        private static string Maullido = "Miauuu!";

        public override void EmitirSonido()
        {
            Console.WriteLine( "Se escucha a un gato a lo lejos... " + "'" + getMaullido() + "'");
        }

        public string getMaullido() { return Maullido; }

    }
}
