
namespace Par_Impar
{
    partial class fibonacci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Button btnSair;
            System.Windows.Forms.Button btnCalcular;
            System.Windows.Forms.Button btnLimpar;
            this.txtNum = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            btnSair = new System.Windows.Forms.Button();
            btnCalcular = new System.Windows.Forms.Button();
            btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum
            // 
            this.txtNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.txtNum.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNum.Location = new System.Drawing.Point(201, 131);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(78, 24);
            this.txtNum.TabIndex = 0;
            this.txtNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSair
            // 
            btnSair.BackColor = System.Drawing.Color.Transparent;
            btnSair.Cursor = System.Windows.Forms.Cursors.Cross;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSair.ForeColor = System.Drawing.Color.DarkRed;
            btnSair.Location = new System.Drawing.Point(12, 3);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(108, 56);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 25;
            this.listBox1.Location = new System.Drawing.Point(201, 209);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(123, 175);
            this.listBox1.TabIndex = 2;
            this.listBox1.Visible = false;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = System.Drawing.Color.Transparent;
            btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnCalcular.ForeColor = System.Drawing.Color.Transparent;
            btnCalcular.Location = new System.Drawing.Point(112, 423);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new System.Drawing.Size(116, 42);
            btnCalcular.TabIndex = 3;
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            btnLimpar.BackColor = System.Drawing.Color.Transparent;
            btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            btnLimpar.Location = new System.Drawing.Point(277, 423);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(122, 42);
            btnLimpar.TabIndex = 4;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // fibonacci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Par_Impar.Properties.Resources.adsad;
            this.ClientSize = new System.Drawing.Size(468, 477);
            this.ControlBox = false;
            this.Controls.Add(btnLimpar);
            this.Controls.Add(btnCalcular);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(btnSair);
            this.Controls.Add(this.txtNum);
            this.Name = "fibonacci";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.ListBox listBox1;
    }
}