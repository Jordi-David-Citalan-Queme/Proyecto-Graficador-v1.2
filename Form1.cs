using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_graficador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int cadena;
        int i;
        int cantidad;

        private float x1, y1, x2, y2, delta = 0.1f;

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            txtBox1.Clear();
            pictureBox1.Image = null;
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            //cadena = txtBox1.Text();
            //int[] vector new []
                //for int i = cadena; cadena <= i; cadena = ++;
                //{
                //cadena = vector [i];
                    //{
                    //if cadena = ++;
                        //{
                        //cadena += cantidad;
                        //}
                        //else cadena = cantidad;
                         //{
                            
                         //}
                                
                    //}
                //}

            Graphics g = pictureBox1.CreateGraphics();

            float xm, ym;
            xm = pictureBox1.Width / 2;
            ym = pictureBox1.Height / 2;

            g.TranslateTransform(xm, ym);

            g.DrawLine(Pens.Black, -xm, 0, xm, 0);
            g.DrawLine(Pens.Black, 0, -ym, 0, ym);
            g.ScaleTransform(4, 4);
            float x1 = -xm;
            while (x1<xm)
            {
                ym = fx(x1);
                x2 = x1 + delta;
                y2 = fx(x2);
                g.DrawLine(Pens.Blue, x1, y1, x2, y2);
                x1 = x2;
            }
        }

        private float fx(float x)
        {
            float y = (float)Math.Sin(x);
            return y*-1;
        }
    }
}
