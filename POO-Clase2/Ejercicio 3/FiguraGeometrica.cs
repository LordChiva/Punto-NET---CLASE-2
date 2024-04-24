using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    public abstract class FiguraGeometrica
    {
        public virtual void CalcularArea() { Console.WriteLine("El area es..."); }

        public virtual void CalcularPerimetro() { Console.WriteLine("El perimetro es..."); }
    }
}
