using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Par_Impar
{
    public partial class fibonacci : Form
    {
        public fibonacci()
        {
            InitializeComponent();
        }

        int i, num, num1, num2, num3;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void Verificar()
        {
            try
            {
                num = Convert.ToInt32(txtNum.Text);
                
            }
            catch (Exception)
            {
                MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Verificar();

            listBox1.Visible = true;
            num1 = 1;
            num2 = 1;
            num3 = 0;

            listBox1.Items.Add(num1);
            listBox1.Items.Add(num2);

            for (i = 3; i <= num; i++){
                num3 = num1 + num2;
                listBox1.Items.Add(num3);
                num1 = num2;
                num2 = num3; 
            }



        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Text = "";
            txtNum.Focus();
            listBox1.Items.Clear();
            listBox1.Visible = false; 
        }
    }
}
