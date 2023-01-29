using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImparesAndpares
{
    public partial class formPar : Form
    {
        public formPar()
        {
            InitializeComponent();
        }

        double[] Numeros = new double[10]; //Array de 10 posíções 
        int count = 0, impar = 0, par = 0;
        List<double> Impares = new List<double>();
        List<double> Pares = new List<double>();
        double TotalImpares = 0, TotalPares = 0, Total = 0;
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            
            Verificar();
            count = count + 1;
            
            
            if (count == 10) {
                //Descobrir se o número é ímpar ou par
                for(int i = 0; i < 10; i++)
                {
                    if (Numeros[i] % 2 == 0) {
                        par = par + 1;
                        Pares.Add(Numeros[i]);
                    } 
                    else
                    {
                        impar = impar + 1;
                        Impares.Add(Numeros[i]); 
                    }
                    
                }

                //Total de impares
                for (int i = 0; i<impar; i++)
                {
                    TotalImpares = TotalImpares + Impares[i];  
                }

                //Total de pares 
                for (int i = 0; i<par; i++)
                {
                    TotalPares = TotalPares + Pares[i]; 
                }

                //Soma total 
                for (int i = 0; i<10; i++)
                {
                    Total = Total + Numeros[i]; 
                }

                MessageBox.Show(" Impares: " + impar + "\n Pares: " + par +"\n Soma Impares: " + TotalImpares +
                    "\n Soma Pares: " + TotalPares + "\n Soma total: " + Total,"Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            
        }
 
        public void Verificar()
        {
            try
            {
                Numeros[count] = Convert.ToDouble(txtNum.Text);
                txtNum.Clear();
                txtNum.Focus(); 
            }
            catch (Exception)
            {
                MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum.Focus();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumero_Click(object sender, EventArgs e)
        {

        }

        private void btnEraser_Click(object sender, EventArgs e)
        {
            txtNum.Clear();
            txtNum.Focus(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit(); 
        }
    }
}
