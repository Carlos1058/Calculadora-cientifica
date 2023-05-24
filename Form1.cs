using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }
        int operacion = 0;
        decimal primero, segundo;
        private void b0_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 0;
            
        }

        private void b1_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 1;
        }

        private void b2_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 2;
        }

        private void b3_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 3;
        }

        private void b4_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 4;
        }

        private void b5_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 5;
        }

        private void b6_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 6;
        }

        private void b7_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 7;
        }

        private void b8_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 8;
        }

        private void b9_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + 9;
        }

        private void bpunto_Click(object sender, EventArgs e)
        {
            resultado.Text = resultado.Text + ".";
        }

        private void borrartodo_Click(object sender, EventArgs e)
        {
            resultado.Clear();
            preview.Text = "";
            operacion = 0;
        }

        private void restar_Click(object sender, EventArgs e)
        {
            operacion = 2;
            primero = Convert.ToDecimal(resultado.Text);
            resultado.Clear();
            preview.Text = primero.ToString() + " - ";
        }

        private void multiplicar_Click(object sender, EventArgs e)
        {
            operacion = 3;
            primero = Convert.ToDecimal(resultado.Text);
            resultado.Clear();
            preview.Text = primero.ToString() + " x ";
        }

        private void sumar_Click(object sender, EventArgs e)
        {
            operacion = 4;
            primero = Convert.ToDecimal(resultado.Text);
            resultado.Clear();
            preview.Text = primero.ToString() + " + ";
        }

        private void modulo_Click(object sender, EventArgs e)
        {
            operacion = 5;
            primero = Convert.ToDecimal(resultado.Text);
            resultado.Clear();
            preview.Text = primero.ToString() + " % ";
        }

        private void factorial_Click(object sender, EventArgs e)
        {
            double factorial = 1;
            int numero = Convert.ToInt32(resultado.Text);
            resultado.Clear();
            for(int i = 1; i<=numero; i++)
            {
                factorial = factorial * i;
            }
            resultado.Text = factorial.ToString();
            
        }

        private void sumatoria_Click(object sender, EventArgs e)
        {
            int sumatoria = 0;
            double numero = Convert.ToInt32(resultado.Text);
            resultado.Clear();
            for(int i = 0; i<=numero; i++)
            {
                sumatoria = sumatoria + i;
            }
            resultado.Text=sumatoria.ToString();
        }



        private void borrar_Click(object sender, EventArgs e)
        {
            resultado.Clear();
        }

        private void dividir_Click(object sender, EventArgs e)
        {
            operacion = 1;
            primero = Convert.ToDecimal(resultado.Text);
            resultado.Clear();
            preview.Text = primero.ToString() + " / ";

        }

        private void científicaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(700, 530);
        }

        private void estándarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Size = new Size(317, 530);
        }

        private void seno_Click(object sender, EventArgs e)
        {
            double seno;
            double numero = Convert.ToInt32(resultado.Text);
            resultado.Clear();
            seno = Math.Sin(numero);
            resultado.Text = seno.ToString();

        }

        //----------------------------------------------------------- CALCULAR EL IGUAL -------------------------------------------------

        private void igual_Click(object sender, EventArgs e)
        {
            switch(operacion)
            {
                case 1:
                    segundo = Convert.ToDecimal(resultado.Text);
                    resultado.Clear();
                    resultado.Text = Convert.ToString(primero/segundo);
                    preview.Text = preview.Text + segundo.ToString() + " = ";
                    break;
                case 2:
                    segundo = Convert.ToDecimal(resultado.Text);
                    resultado.Clear();
                    resultado.Text = Convert.ToString(primero - segundo);
                    preview.Text = preview.Text + segundo.ToString() + " = ";
                    break;
                case 3:
                    segundo = Convert.ToDecimal(resultado.Text);
                    resultado.Clear();
                    resultado.Text = Convert.ToString(primero * segundo);
                    preview.Text = preview.Text + segundo.ToString() + " = ";
                    break;
                case 4:
                    segundo = Convert.ToDecimal(resultado.Text);
                    resultado.Clear();
                    resultado.Text = Convert.ToString(primero + segundo);
                    preview.Text = preview.Text + segundo.ToString() + " = ";
                    break;
                case 5:
                    segundo = Convert.ToDecimal(resultado.Text);
                    resultado.Clear();
                    resultado.Text = Convert.ToString((primero * segundo)/100);
                    preview.Text = preview.Text + segundo.ToString() + " = ";
                    break;
            }
        }
    }
}
