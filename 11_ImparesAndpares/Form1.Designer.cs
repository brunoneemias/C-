
namespace ImparesAndpares
{
    partial class formPar
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
            this.txtNum = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(91)))), ((int)(((byte)(196)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(180, 178);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(132, 33);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNum.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Location = new System.Drawing.Point(138, 281);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.Color.Transparent;
            this.btnEraser.FlatAppearance.BorderSize = 0;
            this.btnEraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEraser.Location = new System.Drawing.Point(263, 281);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(92, 23);
            this.btnEraser.TabIndex = 2;
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(389, 325);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 3;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // formPar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ImparesAndpares.Properties.Resources.Blue_Pink_Mobile_App_Pitch_Deck_Presentation__1_;
            this.ClientSize = new System.Drawing.Size(513, 382);
            this.ControlBox = false;
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnEraser);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtNum);
            this.Name = "formPar";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnExit;
    }
}

