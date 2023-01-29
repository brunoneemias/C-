using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fatorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double i, num, fatorial, test;

        public void Verificar()
        {
            try
            {
                num = Convert.ToDouble(txtNum.Text);
                test = 1; 
            }
            catch (Exception)
            {
                MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtNum.Focus();
            num = 0;
            fatorial = 0;
            i = 0; 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Verificar();
            if (test == 1)
            {
                if (num == 0)
                {
                    fatorial = 1;
                }
                else
                {
                    fatorial = num;
                    for (i = num - 1; i >= 1; i--)
                    {
                        fatorial = fatorial * i;
                    }
                }

                MessageBox.Show("O fatorial de " + num + " é " + fatorial, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
