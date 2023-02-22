using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsExamen
{
    internal class Triangulo : FiguraGeometrica, IPoligono
    {
        private double v_base;
        private double v_altura;

        public Triangulo():base()
        {
            Nombre = "Triangulo";
        }

        public double V_base { get => v_base; set => v_base = value; }
        public double V_altura { get => v_altura; set => v_altura = value; }

        public double Area(double valor1, double valor2)
        {
            //valor1 base
            //valor2 altura
            return (valor1 * valor2) /2;
        }
        override public string ToString()
        {
            return Nombre + " Area:" + Area(v_base, v_altura);
        }

    }
}
