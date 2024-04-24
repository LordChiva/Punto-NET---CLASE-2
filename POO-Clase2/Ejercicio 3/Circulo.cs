using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Clase2.Ejercicio_3
{
    internal class Circulo
    {
        private static double PI = 3.14;
        private double Diametro;
        private double Area;
        private double Perimetro;
        private double Radio;

        public Circulo()
        {
            Console.WriteLine("CIRCULO");
            SetDiametro(10);
            SetRadio(GetDiametro()/2);
            CalcularArea();
            CalcularPerimetro();
        }

        public void CalcularArea()
        {
            SetArea(GetPI() * (GetRadio() * GetRadio()) );
            Console.WriteLine("El area es: " + GetArea());
        }

        public void CalcularPerimetro()
        {
            SetPerimetro(GetPI() * GetDiametro());
            Console.WriteLine("El perimetro es: " + GetPerimetro());
        }

        public double GetPI() { return PI; }

        public double GetDiametro() { return this.Diametro; }

        private void SetDiametro(int diametro)
        {
            this.Diametro = diametro;
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

        public double GetRadio() { return this.Radio; }

        private void SetRadio(double radio)
        {
            this.Radio = radio;
        }
    }
}
