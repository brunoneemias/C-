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
    public partial class Form1 : Form
    {
        Thread nt; 
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            nt = new Thread(novoForm);
            this.Close();
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();

        }

        private void novoForm()
        {
            Application.Run(new Tela2()); 
        }
    }
}
