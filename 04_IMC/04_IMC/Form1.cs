using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Single peso, altura, imc;
        bool test;

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            peso = 0;
            altura = 0;
            imc = 0;
            txtAltura.Clear();
            txtPeso.Clear();
            txtPeso.Focus(); 

        }

        public void verificar()
        {
            try
            {
                peso = Convert.ToSingle(txtPeso.Text);
                altura = Single.Parse(txtAltura.Text);
                test = true;
            }
            catch (Exception)
            {
                MessageBox.Show("Erro na conversão de valores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPeso.Focus();

                test = false;
            }

        }
        private void btnOk_Click(object sender, EventArgs e)
        {
            verificar();
            if (test == true)
            {
                imc = peso / (altura * altura);

                if (imc < 18.5)
                {
                    MessageBox.Show(imc.ToString("N2") + " MAGRO!", "MAGRO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                } else if (imc >= 18.5 & imc < 25) {

                    MessageBox.Show(imc.ToString("N2") + " NORMAL!", "NORMAL", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }else if (imc >= 25 & imc < 30)
                {
                    MessageBox.Show(imc.ToString("N2") + " OBESO!", "OBESO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else 
                {
                    MessageBox.Show(imc.ToString("N2") + " OBESO MÓRBIDO!", "OBESO MÓRBIDO", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                
            }
        }
        }
    }

