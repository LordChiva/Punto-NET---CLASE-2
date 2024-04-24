using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public class Notebook : Maquina
    {
        private int Peso;

        public Notebook()
        {
            SetMarca( "AchePe" );
            SetPeso( 10 );
            Console.WriteLine( "Especificaciones de la Notebook:");
            Console.WriteLine( "La Marca es " + GetMarca() );
            Console.WriteLine( "El peso es " + GetPeso() );
        }

        public int GetPeso() { return this.Peso; }

        private void SetPeso(int peso) 
        {
            this.Peso = peso;
        }

        public string GetMarca() { return this.Marca; }

        private void SetMarca(string marca)
        {
            this.Marca = marca;
        }

    }
}
