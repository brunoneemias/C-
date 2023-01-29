using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SalarioLiquido
{
    public partial class Tela2 : Form
    {
        Thread nt1;
        public Tela2()
        {
            InitializeComponent();
            
        }

        public double aulas, preco, dependentes, salario_b, salario_liquido, INSS,IR;
        public string faixaINSS, faixaIRRF;

        private void txtAulas_TextChanged(object sender, EventArgs e)
        {

        }

        int test; 
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            salario_b = preco * aulas * 4.5;
            
            //INSS 

            if (salario_b <= 1100)
            {
                faixaINSS = "7.5%";
                INSS = 0; 
                
            }else if((salario_b > 1100)  && (salario_b <= 2203.48)){
                faixaINSS = "9%";
                INSS = salario_b * 0.09;
                
            }else if((salario_b >2203.48) && (salario_b <= 3305.22))
               {
                faixaINSS = "12%";
                INSS = salario_b * 0.12;  
            }else if ((salario_b > 3305.22) && (salario_b <= 6433.57))
                    {
                faixaINSS = "14%";
                INSS = salario_b * 0.14;

            }
            else
            {
                faixaINSS = "Teto"; 
                INSS = 751.98;
            }

            salario_b = salario_b - INSS; 

            //DEPENDENTES 
            dependentes = Convert.ToDouble(txtDepend.Text);
            dependentes = dependentes * 189.59;

            salario_b = -dependentes; 

            //IRRF 

            if (salario_b <= 1903.98) {
                faixaIRRF = "Isento";
            } else if ((salario_b > 1903.98) && (salario_b <= 2826.65)) {
                faixaIRRF = "7.5%";
                IR = salario_b * 0.075;
            } else if ((salario_b > 2826.65) && (salario_b <= 3751.05)) {
                faixaIRRF = "15%";
                IR = salario_b * 0.15;
            } else if ((salario_b > 3751.05) && (salario_b <= 4664.68)){
                IR = salario_b * 0.225;
                faixaIRRF = "22.5%";
            }
            else
            {
                faixaIRRF = "27.5";
                IR = salario_b * 0.275; 
            }
            salario_liquido = salario_b - IR;

            nt1 = new Thread(novoForm);
            this.Close();
            nt1.SetApartmentState(ApartmentState.STA);
            nt1.Start();


        }

       private void novoForm()
        {
            using (var form2 = new Form2(txtNome.Text))
            {
                form2.ShowDialog(); 
                txtNome.Text = form2.Parent
            }
        } 

        private void verificar()
        {
            try
            {
          
                aulas = Convert.ToDouble(txtAulas.Text);
                test = 1; 
                preco = Convert.ToDouble(txtValor.Text);
                test = 2;
                dependentes = Convert.ToDouble(txtDepend.Text);
                test = 3;
            } catch
            {
                if (test == 1)
                {
                    MessageBox.Show("QUANTIDADE DE AULA INCORRETA!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtAulas.Focus();
                }else if(test == 2)
                {
                    MessageBox.Show("VALOR DAS AULAS INCORRETO!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtValor.Focus();
                }
                else
                {
                    MessageBox.Show("QUANTIDADE DENPENDENTES ICORRETO! ", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtDepend.Focus();
                }
            }
        }
        
    }
    }

