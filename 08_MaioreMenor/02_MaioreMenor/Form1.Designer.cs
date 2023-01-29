
namespace _02_MaioreMenor
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bntOK = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntOK
            // 
            this.bntOK.AutoSize = true;
            this.bntOK.BackColor = System.Drawing.Color.Transparent;
            this.bntOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntOK.CausesValidation = false;
            this.bntOK.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.bntOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntOK.FlatAppearance.BorderSize = 0;
            this.bntOK.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntOK.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntOK.Location = new System.Drawing.Point(335, 270);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(49, 32);
            this.bntOK.TabIndex = 10;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bnbSoma_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.AutoSize = true;
            this.bntLimpar.BackColor = System.Drawing.Color.Transparent;
            this.bntLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bntLimpar.CausesValidation = false;
            this.bntLimpar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.bntLimpar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bntLimpar.FlatAppearance.BorderSize = 0;
            this.bntLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bntLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bntLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntLimpar.Location = new System.Drawing.Point(293, 337);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(135, 32);
            this.bntLimpar.TabIndex = 11;
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.AutoSize = true;
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSair.CausesValidation = false;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(319, 406);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(81, 35);
            this.btnSair.TabIndex = 12;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtN1
            // 
            this.txtN1.AcceptsReturn = true;
            this.txtN1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(174, 273);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(73, 24);
            this.txtN1.TabIndex = 13;
            this.txtN1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN2
            // 
            this.txtN2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(174, 340);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(73, 24);
            this.txtN2.TabIndex = 14;
            this.txtN2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtN3
            // 
            this.txtN3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(174, 412);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(73, 24);
            this.txtN3.TabIndex = 15;
            this.txtN3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(501, 499);
            this.ControlBox = false;
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntOK);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
    }
}

