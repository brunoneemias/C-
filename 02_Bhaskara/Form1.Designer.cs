
namespace _02_Bhaskara
{
    partial class Bhaskara
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bhaskara));
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.bnbCalcular = new System.Windows.Forms.Button();
            this.bnbLimpar = new System.Windows.Forms.Button();
            this.bnbSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.txtA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.txtA.Location = new System.Drawing.Point(346, 147);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(54, 31);
            this.txtA.TabIndex = 0;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.txtB.Location = new System.Drawing.Point(346, 203);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(54, 31);
            this.txtB.TabIndex = 1;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtC
            // 
            this.txtC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(77)))), ((int)(((byte)(57)))));
            this.txtC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(239)))), ((int)(((byte)(198)))));
            this.txtC.Location = new System.Drawing.Point(346, 270);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(54, 31);
            this.txtC.TabIndex = 2;
            this.txtC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bnbCalcular
            // 
            this.bnbCalcular.BackColor = System.Drawing.Color.Transparent;
            this.bnbCalcular.FlatAppearance.BorderSize = 0;
            this.bnbCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbCalcular.Location = new System.Drawing.Point(523, 179);
            this.bnbCalcular.Name = "bnbCalcular";
            this.bnbCalcular.Size = new System.Drawing.Size(231, 36);
            this.bnbCalcular.TabIndex = 3;
            this.bnbCalcular.UseVisualStyleBackColor = false;
            this.bnbCalcular.Click += new System.EventHandler(this.bnbCalcular_Click);
            // 
            // bnbLimpar
            // 
            this.bnbLimpar.BackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatAppearance.BorderSize = 0;
            this.bnbLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbLimpar.Location = new System.Drawing.Point(555, 252);
            this.bnbLimpar.Name = "bnbLimpar";
            this.bnbLimpar.Size = new System.Drawing.Size(155, 36);
            this.bnbLimpar.TabIndex = 4;
            this.bnbLimpar.UseVisualStyleBackColor = false;
            this.bnbLimpar.Click += new System.EventHandler(this.bnbLimpar_Click);
            // 
            // bnbSair
            // 
            this.bnbSair.BackColor = System.Drawing.Color.Transparent;
            this.bnbSair.FlatAppearance.BorderSize = 0;
            this.bnbSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.bnbSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.bnbSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bnbSair.Location = new System.Drawing.Point(720, 34);
            this.bnbSair.Name = "bnbSair";
            this.bnbSair.Size = new System.Drawing.Size(50, 54);
            this.bnbSair.TabIndex = 5;
            this.bnbSair.UseVisualStyleBackColor = false;
            this.bnbSair.Click += new System.EventHandler(this.bnbSair_Click);
            // 
            // Bhaskara
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.bnbSair);
            this.Controls.Add(this.bnbLimpar);
            this.Controls.Add(this.bnbCalcular);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Bhaskara";
            this.Text = "Bhaskara";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Button bnbCalcular;
        private System.Windows.Forms.Button bnbLimpar;
        private System.Windows.Forms.Button bnbSair;
    }
}

