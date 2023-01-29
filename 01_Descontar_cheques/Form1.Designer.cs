
namespace _01_Descontar_cheques
{
    partial class Contas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Contas));
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtCheque1 = new System.Windows.Forms.TextBox();
            this.txtCheque2 = new System.Windows.Forms.TextBox();
            this.txtCheque3 = new System.Windows.Forms.TextBox();
            this.bnbDescontar = new System.Windows.Forms.Button();
            this.bnbSair = new System.Windows.Forms.Button();
            this.bnbLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaldo
            // 
            this.txtSaldo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(84)))));
            this.txtSaldo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtSaldo.Location = new System.Drawing.Point(372, 215);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(154, 31);
            this.txtSaldo.TabIndex = 0;
            this.txtSaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCheque1
            // 
            this.txtCheque1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(84)))));
            this.txtCheque1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheque1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCheque1.Location = new System.Drawing.Point(372, 266);
            this.txtCheque1.Name = "txtCheque1";
            this.txtCheque1.Size = new System.Drawing.Size(154, 31);
            this.txtCheque1.TabIndex = 1;
            this.txtCheque1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCheque2
            // 
            this.txtCheque2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(84)))));
            this.txtCheque2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheque2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCheque2.Location = new System.Drawing.Point(372, 317);
            this.txtCheque2.Name = "txtCheque2";
            this.txtCheque2.Size = new System.Drawing.Size(154, 31);
            this.txtCheque2.TabIndex = 2;
            this.txtCheque2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCheque3
            // 
            this.txtCheque3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(84)))));
            this.txtCheque3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCheque3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCheque3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtCheque3.Location = new System.Drawing.Point(372, 372);
            this.txtCheque3.Name = "txtCheque3";
            this.txtCheque3.Size = new System.Drawing.Size(154, 31);
            this.txtCheque3.TabIndex = 3;
            this.txtCheque3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCheque3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bnbDescontar
            // 
            this.bnbDescontar.BackColor = System.Drawing.Color.Transparent;
            this.bnbDescontar.FlatAppearance.BorderSize = 0;
            this.bnbDescontar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbDescontar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbDescontar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbDescontar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnbDescontar.Location = new System.Drawing.Point(299, 484);
            this.bnbDescontar.Name = "bnbDescontar";
            this.bnbDescontar.Size = new System.Drawing.Size(153, 35);
            this.bnbDescontar.TabIndex = 4;
            this.bnbDescontar.UseVisualStyleBackColor = false;
            this.bnbDescontar.Click += new System.EventHandler(this.bnbDescontar_Click);
            // 
            // bnbSair
            // 
            this.bnbSair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.bnbSair.BackColor = System.Drawing.Color.Transparent;
            this.bnbSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bnbSair.Cursor = System.Windows.Forms.Cursors.Cross;
            this.bnbSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bnbSair.FlatAppearance.BorderSize = 0;
            this.bnbSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbSair.ForeColor = System.Drawing.Color.Transparent;
            this.bnbSair.Location = new System.Drawing.Point(513, 484);
            this.bnbSair.Name = "bnbSair";
            this.bnbSair.Size = new System.Drawing.Size(61, 35);
            this.bnbSair.TabIndex = 5;
            this.bnbSair.UseVisualStyleBackColor = false;
            this.bnbSair.Click += new System.EventHandler(this.bnbSair_Click);
            // 
            // bnbLimpar
            // 
            this.bnbLimpar.BackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatAppearance.BorderSize = 0;
            this.bnbLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbLimpar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.bnbLimpar.Location = new System.Drawing.Point(140, 484);
            this.bnbLimpar.Name = "bnbLimpar";
            this.bnbLimpar.Size = new System.Drawing.Size(94, 35);
            this.bnbLimpar.TabIndex = 6;
            this.bnbLimpar.UseVisualStyleBackColor = false;
            this.bnbLimpar.Click += new System.EventHandler(this.bnbLimpar_Click);
            // 
            // Contas
            // 
            this.AccessibleName = "z";
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 702);
            this.ControlBox = false;
            this.Controls.Add(this.bnbLimpar);
            this.Controls.Add(this.bnbSair);
            this.Controls.Add(this.bnbDescontar);
            this.Controls.Add(this.txtCheque3);
            this.Controls.Add(this.txtCheque2);
            this.Controls.Add(this.txtCheque1);
            this.Controls.Add(this.txtSaldo);
            this.Name = "Contas";
            this.Text = "Cheque";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtCheque1;
        private System.Windows.Forms.TextBox txtCheque2;
        private System.Windows.Forms.TextBox txtCheque3;
        private System.Windows.Forms.Button bnbDescontar;
        private System.Windows.Forms.Button bnbSair;
        private System.Windows.Forms.Button bnbLimpar;
    }
}

