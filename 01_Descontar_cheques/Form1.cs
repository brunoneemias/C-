using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Descontar_cheques
{
    public partial class Contas : Form
    {
        public Contas()
        {
            InitializeComponent();
        }
        // Variveis 
        Single saldo_atual, saldo_final, cheque1, cheque2, cheque3;
        int test, qtd;

        private void bnbLimpar_Click(object sender, EventArgs e)
        {
            saldo_atual = 0;
            saldo_final = 0;
            cheque1 = 0;
            cheque2 = 0;
            cheque3 = 0;
            test = 0;
            qtd = 0;
            txtCheque1.Clear();
            txtCheque2.Clear();
            txtCheque3.Clear();
            txtSaldo.Clear();
            txtSaldo.Focus();

            
        }

        public void Verificar()
        {
            try
            { 
                  test = 1; 
                saldo_atual = Convert.ToSingle(txtSaldo.Text);
                  test = 2; 
                cheque1 = Convert.ToSingle(txtCheque1.Text);
                  test = 3; 
                cheque2 = Convert.ToSingle(txtCheque2.Text);
                  test = 4;
                cheque3 = Convert.ToSingle(txtCheque3.Text);
                test = 5; 
            
            }
            catch (Exception)
            {
                
                if (test == 1)
                {
                    MessageBox.Show("Valor digitado em SALDO ATUAL inválido! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSaldo.Focus(); 
                } else if (test == 2)
                {
                    MessageBox.Show("Valor digitado em CHEQUE 1 inválido! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheque1.Focus();
                } else if (test == 3)
                {
                    MessageBox.Show("Valor digitado em CHEQUE 2 inválido! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheque2.Focus();
                } else if (test == 4)
                {
                    MessageBox.Show("Valor digitado em CHEQUE 3 inválido! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCheque3.Focus();
                }
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void bnbSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bnbDescontar_Click(object sender, EventArgs e)
        {
            Verificar(); 

            if (test == 5)
            {
                qtd = 0; 

                if (saldo_atual >= cheque1 )
                {
                    saldo_final = saldo_atual - cheque1;
                    qtd = qtd + 1; 
                }else{
                    MessageBox.Show("O CHEQUE 1 no valor de R$" + cheque1 + " Não pode ser descontado por saldo insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    saldo_final = saldo_atual; 
                }

                if (saldo_final >= cheque2) { 

                    saldo_final = saldo_final - cheque2;
                    qtd = qtd + 1;

                }
                else{
                    MessageBox.Show("O CHEQUE 2 no valor de R$" + cheque2 + " Não pode ser descontado por saldo insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } 

                if (saldo_final >= cheque3)
                {
                    saldo_final = saldo_final - cheque3;
                    qtd = qtd + 1;           
                    }
                else{
                    MessageBox.Show("O CHEQUE 3 no valor de R$" + cheque3 + " Não pode ser descontado por saldo insuficiente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
                if (qtd > 1)
                {
                    MessageBox.Show("Foram descontados " + qtd + " Cheques e o saldo atual é R$" + saldo_final, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if  (qtd == 1) {

                    MessageBox.Show("Foi descontado " + qtd + " Cheque e o saldo atual é R$" + saldo_final, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if  (qtd == 0) {
                    MessageBox.Show("Nenhum cheque foi descontado o saldo atual é de R$" + saldo_final, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
