using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_Bhaskara
{
    public partial class Bhaskara : Form
    {
        public Bhaskara()
        {
            InitializeComponent();
        }

        double b, c, x1, x2, a, delta;

        private void bnbLimpar_Click(object sender, EventArgs e)
        {
            b = 0;
            c = 0;
            x1 = 0;
            x2 = 0;
            a = 0;
            delta = 0;
            txtA.Clear();
            txtB.Clear();
            txtC.Clear();
            txtA.Focus();
        }

        int test;

        public void Verificar()
        {
            try
            {
                test = 1;
                a = Convert.ToDouble(txtA.Text);
                test = 2;
                b = Convert.ToDouble(txtB.Text);
                test = 3;
                c = Convert.ToDouble(txtC.Text);
                test = 4;

            }
            catch (Exception)
            {
                if (test == 1)
                {
                    MessageBox.Show("O valor de A não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtA.Focus();
                }
                else if (test == 2)
                {
                    MessageBox.Show("O valor de B não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtB.Focus();
                }
                else if (test == 3)
                {
                    MessageBox.Show("O valor de C não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtC.Focus();
                }

            }
        }

        private void bnbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void bnbCalcular_Click(object sender, EventArgs e)
        {
            Verificar();

            if (test == 4)
            {
                delta = b * b - (4 * a * c);

                if (delta < 0)
                {
                    MessageBox.Show("A EQUAÇÃO NÃO POSSUI RESULTADOS REAIS!", "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (delta == 0)
                {

                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show("Delta = " + delta + "  \n Raiz = " + x1, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (delta > 0)
                {
                    x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show("Delta = " + delta + " \n    Raizes  \n   X1 = " + x1 + " \n   X2 = " + x2, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}


