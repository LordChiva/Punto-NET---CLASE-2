using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Rectangulo
    {
        //       private double Area { get; set; } <--- no entiendo cómo utilizar el set y get de esta forma
        private double Base;
        private double Altura;
        private double Area;
        private double Perimetro;

        public Rectangulo()
        {
            Console.WriteLine("RECTANGULO");
            SetBase( 6 );
            SetAltura( 4 );
            CalcularArea();
            CalcularPerimetro();
        }

        public void CalcularArea()
        {
            SetArea(GetBase() * GetAltura());
            Console.WriteLine("El area es: " + GetArea() );
        }

        public void CalcularPerimetro()
        {
            SetPerimetro( (GetBase() * 2) + (GetAltura() * 2) );
            Console.WriteLine("El perimetro es: " + GetPerimetro() );
        }

        public double GetBase() { return this.Base; }

        //Qué significa 'base'? al querer poner 'int base' me marcaba base como no valido o que le faltaba algo
        private void SetBase(int vase)
        {
            this.Base = vase;
        }
        public double GetAltura() { return this.Altura; }

        private void SetAltura(int altura) 
        {
            this.Altura = altura;
        }

        public double GetArea() { return this.Area; }

        private void SetArea(double area)
        {
            this.Area = area;
        }

        public double GetPerimetro() { return this.Perimetro; }

        private void SetPerimetro(double perimetro)
        {
            this.Perimetro = perimetro;
        }
    }
}
