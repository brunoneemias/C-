using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_MaioreMenor
{
    public partial class Form1 : Form
    {
        Single n1, n2, n3;
        bool test;

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtN1.Clear();
            txtN2.Clear();
            txtN3.Clear();
            txtN1.Focus();
        }

        public void verificar()
        {
            try
            {
                n1 = Convert.ToSingle(txtN1.Text);
                n2 = Single.Parse(txtN2.Text);
                n3 = Single.Parse(txtN3.Text);
                test = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na conversão de valores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtN1.Focus();

                test = false;
            }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void bnbSoma_Click(object sender, EventArgs e)
        {
            verificar();
            if (test == true)
            {
                if ((n1 > n2) & (n1 > n3))
                {
                    MessageBox.Show("O maior número é: " + n1, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (n2 > n3)
                {
                    MessageBox.Show("O maior número é: " + n2, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("O maior número é: " + n3, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        public Form1()
        {
            InitializeComponent();
        }

  }

}
