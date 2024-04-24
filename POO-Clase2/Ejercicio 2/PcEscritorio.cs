using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_2
{
    public class PcEscritorio : Maquina
    {
        private Boolean Refactorizada;

        public PcEscritorio()
        {
            SetMarca( "Ele Nuevo" );
            SetRefactorizada( true );
            Console.WriteLine( "Especificaciones de la PC:" );
            Console.WriteLine( "La Marca es " + GetMarca() );
            Console.WriteLine( "Es refactorizada: " + GetRefactorizada() );
        }

        public Boolean GetRefactorizada() { return Refactorizada; }

        private void SetRefactorizada(Boolean refactor)
        {
            this.Refactorizada = refactor;
        }

        public string GetMarca() { return this.Marca; }

        private void SetMarca(string marca)
        {
            this.Marca = marca;
        }
    }
}
