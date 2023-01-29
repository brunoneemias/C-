using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int Num;
        
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void Verificar()
        {
            try
            {
                Num = Convert.ToInt32(txtNumero.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNumero.Focus();
            }
        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Num = 0;
            txtNumero.Text = "";
            listBox1.Items.Clear(); 
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Verificar(); 
            for (int i = 1; i <= 10; i++)
            {
                listBox1.Items.Add(i + "X" + Num + " = " + (i * Num)); 
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
