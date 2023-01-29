using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<int> Resultado = new List<int>();
        int Num, y = 0, x = 1, res=0;

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNum.Text = ""; 
            Num = 0;
            y = 0;
            x = 1;
            res = 0;
            txtNum.Focus(); 


        }

        public void Verificar()
        {
            try
            {
                Num = Convert.ToInt32(txtNum.Text); 
            }
            catch (Exception)
            {
                MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Resultado.Add(res);
            Resultado.Add(x);
            Verificar();
            for(int i=0; i<Num-2; i++)
            {
                res = x + y;
                y = x;
                x = res;
                Resultado.Add(res); 
                
            }

            for (int i = 0; i < Resultado.Count; i++)
            {
                MessageBox.Show("" + Resultado[i], "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
        }
    }
}
