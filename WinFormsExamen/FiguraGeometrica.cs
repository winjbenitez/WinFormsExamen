using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsExamen
{
    public class FiguraGeometrica
    {
        private string _nombre;

        public FiguraGeometrica()
        {
            this._nombre = "";
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
    }
}
