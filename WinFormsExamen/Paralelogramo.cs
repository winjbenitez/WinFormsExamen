using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsExamen
{
    internal class Paralelogramo : FiguraGeometrica, IPoligono
    {
        private double v_base;
        private double v_altura;
        public Paralelogramo():base()
        {
            Nombre = "Paralelogramo";
        }
        public double V_base { get => v_base; set => v_base = value; }
        public double V_altura { get => v_altura; set => v_altura = value; }

        public double Area(double valor1, double valor2)
        {
            
            return valor1 * valor2;
        }
        override public string ToString()
        {
            return Nombre + " Area:" + Area(v_base, v_altura);
        }
    }
}
