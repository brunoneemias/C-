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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Num, Soma_par, Soma_impar;
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

  

        private void btnResult_Click_1(object sender, EventArgs e)
        {
            listImpar.Visible = true;
            listPar.Visible = true;
            lblQtdNum.Text = Convert.ToString(listImpar.Items.Count + listPar.Items.Count);

            lblQP.Text = Convert.ToString(listPar.Items.Count);
            lblQI.Text = Convert.ToString(listImpar.Items.Count);
            lblSI.Text = Convert.ToString(Soma_impar);
            lblSP.Text = Convert.ToString(Soma_par);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void lblSI_Click(object sender, EventArgs e)
        {

        }

        private void lblQI_Click(object sender, EventArgs e)
        {

        }

        private void lblQtdNum_Click(object sender, EventArgs e)
        {

        }

        private void lblSP_Click(object sender, EventArgs e)
        {

        }

        private void lblQP_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            fibonacci next = new fibonacci();
            next.ShowDialog();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Verificar();

            if (Num % 2 == 0)
            {
                listPar.Items.Add("•" + Num);
                Soma_par = Soma_par + Num;
            }
            else
            {
                listImpar.Items.Add("• " + Num);
                Soma_impar = Soma_impar + Num;
            }
        }

       

            public void Verificar()
            {
                try
                {
                    Num = Convert.ToInt32(txtNumero.Text);
                txtNumero.Text = "";
                txtNumero.Focus(); 
                }
                catch (Exception)
                {
                    MessageBox.Show("O valor digitado não é válido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtNumero.Focus();
                }
            }


        }
    }

