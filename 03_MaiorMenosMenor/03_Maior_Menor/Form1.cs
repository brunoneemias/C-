using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Maior_Menor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
          
            InitializeComponent();
        }

        Single v1, v2, resultado;
        bool test;

        private void txtV1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtV1.Clear();
            txtV2.Clear();
            v1 = 0;
            v2 = 0;
            txtV1.Focus(); 
        }

        public void verificar()
        {
            try
            {
                v1 = Convert.ToSingle(txtV1.Text);
                v2 = Convert.ToSingle(txtV2.Text); 
                test = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na conversão de valores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtV1.Focus();

                test = false;
            }

        }

        private void bntOK_Click(object sender, EventArgs e)
        {
            verificar();
            if (test == true)
            {
                if (v1 > v2)
                {
                    resultado = v1 - v2;
                }
                else
                {
                    resultado = v2 - v1;
                }

                MessageBox.Show("O resultado é: " + resultado, "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

    }
    }

