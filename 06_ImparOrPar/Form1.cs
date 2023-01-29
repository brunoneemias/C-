using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _06_ImparOrPar
{
    public partial class ImparorPar : Form
    {
        public ImparorPar()
        {
            InitializeComponent();
        }

        int number, result;
        bool test; 

        public void verificar()
        {
            try
            {
                number = Convert.ToInt32(txtNumber.Text);
                test = true; 
            }
            catch
            {
                MessageBox.Show("Erro na conversão de valores! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumber.Focus();
                test = false; 
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); 

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtNumber.Clear();
            result = 0;
            test = false;
            txtNumber.Focus(); 

        }

        private void btnLamp_Click(object sender, EventArgs e)
        {
            verificar();

            if (test == true)
            {
                result = number % 2;
                if (result == 0)
                {
                    MessageBox.Show("O número " + number + " é Par!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("O número " + number + " é Ímpar!", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            } 
        }
    }
}
