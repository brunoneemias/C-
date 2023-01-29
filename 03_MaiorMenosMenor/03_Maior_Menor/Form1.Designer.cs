
namespace _03_Maior_Menor
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
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
            this.bntOK.Location = new System.Drawing.Point(167, 349);
            this.bntOK.Name = "bntOK";
            this.bntOK.Size = new System.Drawing.Size(64, 64);
            this.bntOK.TabIndex = 11;
            this.bntOK.UseVisualStyleBackColor = false;
            this.bntOK.Click += new System.EventHandler(this.bntOK_Click);
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
            this.btnSair.Location = new System.Drawing.Point(273, 349);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(83, 33);
            this.btnSair.TabIndex = 12;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.AutoSize = true;
            this.btnLimpar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLimpar.CausesValidation = false;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnLimpar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Location = new System.Drawing.Point(273, 388);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(83, 33);
            this.btnLimpar.TabIndex = 13;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtV1
            // 
            this.txtV1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtV1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtV1.ForeColor = System.Drawing.Color.IndianRed;
            this.txtV1.Location = new System.Drawing.Point(286, 198);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(53, 22);
            this.txtV1.TabIndex = 15;
            this.txtV1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtV2
            // 
            this.txtV2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.txtV2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtV2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtV2.ForeColor = System.Drawing.Color.IndianRed;
            this.txtV2.Location = new System.Drawing.Point(286, 250);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(53, 22);
            this.txtV2.TabIndex = 16;
            this.txtV2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(487, 664);
            this.ControlBox = false;
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntOK);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntOK;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
    }
}

