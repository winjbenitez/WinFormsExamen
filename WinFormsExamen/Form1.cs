using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsExamen
{
    public partial class Form1 : Form
    {
        Stack<object> pila_poligono;
        Rectangulo rec;
        Triangulo tri;
        Paralelogramo par;
        public Form1()
        {
            InitializeComponent();
            pila_poligono = new Stack<object>();//last in,First Out(LIFO)
        }

        private void btn_push_rectangulo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_R_base.Text) || String.IsNullOrEmpty(txt_R_altura.Text))
            {
                MessageBox.Show("Ingrese Valor Numerico");
                return;
            }
            try
            {
                double val1 = double.Parse(txt_R_base.Text);
                double val2 = double.Parse(txt_R_altura.Text);
                rec = new Rectangulo();
                rec.V_base = val1;
                rec.V_altura = val2;
                pila_poligono.Push(rec);
            }
            catch {
                MessageBox.Show("Debe ingresar un Valor Numerico");
            }




        }

        private void btn_push_Triangulo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty (txt_T_base.Text) || String.IsNullOrEmpty(txt_T_altura.Text)) {
                MessageBox.Show("Ingrese Valor Numerico");
            }
            else
            {
                try
                {
                    tri = new Triangulo();
                    tri.V_base = double.Parse(txt_T_base.Text);
                    tri.V_altura = double.Parse(txt_T_altura.Text);
                    pila_poligono.Push(tri);
                }
                catch
                {
                    MessageBox.Show("Debe ingresar un Valor Numerico");
                }
            }


        }

        private void btn_push_paralelogramo_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txt_P_base.Text) || String.IsNullOrEmpty(txt_P_altura.Text))
            {
                MessageBox.Show("Ingrese Valor Numerico");
                return;
            }
            try
            {
                par = new Paralelogramo();
                par.V_base = double.Parse(txt_P_base.Text);
                par.V_altura = double.Parse(txt_P_altura.Text);
                pila_poligono.Push(par);
            }
            catch
            {
                MessageBox.Show("Debe ingresar un Valor Numerico");
            }
        }

        private void btn_Mostrar_Click(object sender, EventArgs e)
        {
            lbl_stack.Text = "";

            foreach( object elemento in pila_poligono)
            {
                try
                {
                    rec = (Rectangulo)elemento;
                    lbl_stack.Text += rec.ToString() + "\n";
                }
                catch  {

                    try
                    {
                        tri = (Triangulo)elemento;
                        lbl_stack.Text += tri.ToString() + "\n";
                       
                    }
                    catch{
                        try
                        {
                            par = (Paralelogramo)elemento;
                            lbl_stack.Text += par.ToString() + "\n";
                        }
                        catch
                        {

                        }
                    }
                }
            }
        }
    }
}
