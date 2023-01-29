using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_Nadador
{
    public partial class Nadador : Form
    {
        public Nadador()
        {
            InitializeComponent();
        }
        // Declarações das variaveis 
        string name;
        bool test; // Teste for the function verificar. 
        TimeSpan datanascimento;
        Single idade; 
       

        public void verificar() // Function that verify the correct information give from user. 
        {
            if (dtbNascimento.Value < DateTime.Now) // verifica se a data digitada é válida. 
            {
                datanascimento = (DateTime.Now.Date - dtbNascimento.Value); // Faz o calculo de dias vividos
                idade = datanascimento.Days / 30 / 12; // Faz o cálculo da idade atual 


                try
                {
                    name = Convert.ToString(txtName.Text);
                    test = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro na conversão de valores! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtName.Focus();

                    test = false;
                }
            }
            else // If teh date is invalid
            {

                MessageBox.Show("Data incorreta! ", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtbNascimento.Focus();
                test = false;
            } 


        }

        

        private void btnCalculaIdade_Click(object sender, EventArgs e) // Botão limpar
        {
            txtName.Clear();
            idade = 0;
            dtbNascimento.Value = DateTime.Now;
            txtName.Focus(); 

        }

        private void button2_Click(object sender, EventArgs e) // Button Exit
        {
            Application.Exit(); 
        }

        private void btnOk_Click(object sender, EventArgs e) // Button Ok 
        {
            verificar(); // Call the function verificar
            if (test == true) // if the function verificar return the value true the code below is executed. 
            {
                if (idade >= 5 & idade <= 7)
                {
                    MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Infantil A ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 8 & idade <= 10)
                {
                    MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Infantil B ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 11 & idade <= 13)
                {
                    MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Juvenil A ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 14 & idade <= 17)
                {
                    MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Juvenil B ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade >= 18 & idade <= 25)
                {
                    MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Sênior ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (idade < 5 || idade > 25)
                {
                    if (idade == 1)
                    {
                        MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Ano" + "\n" + "Classificação: Fora da faixa etária ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Nome: " + name + "\n" + "Idade: " + idade + " Anos" + "\n" + "Classificação: Fora da faixa etária ", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                } 
            }
        }
    }
}
