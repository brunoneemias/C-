﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalarioLiquido
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string parametro
        {
            get { return txtNome.text; }
        }
        public Form2(string parametro) :this()
        {
            lblNome.Text = parametro;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
