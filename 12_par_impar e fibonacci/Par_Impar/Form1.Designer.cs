
namespace Par_Impar
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblQP = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnResult = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSP = new System.Windows.Forms.Label();
            this.lblQI = new System.Windows.Forms.Label();
            this.lblSI = new System.Windows.Forms.Label();
            this.listImpar = new System.Windows.Forms.ListBox();
            this.listPar = new System.Windows.Forms.ListBox();
            this.lblQtdNum = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(143)))), ((int)(((byte)(41)))));
            this.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumero.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtNumero.Location = new System.Drawing.Point(326, 43);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(156, 36);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblQP
            // 
            this.lblQP.AutoSize = true;
            this.lblQP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblQP.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQP.Location = new System.Drawing.Point(196, 340);
            this.lblQP.Name = "lblQP";
            this.lblQP.Size = new System.Drawing.Size(32, 31);
            this.lblQP.TabIndex = 1;
            this.lblQP.Text = "...";
            this.lblQP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQP.Click += new System.EventHandler(this.lblQP_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(679, 12);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 67);
            this.btnSair.TabIndex = 7;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnResult.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Location = new System.Drawing.Point(433, 120);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(205, 56);
            this.btnResult.TabIndex = 8;
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(169, 120);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(205, 56);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSP
            // 
            this.lblSP.AutoSize = true;
            this.lblSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblSP.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSP.Location = new System.Drawing.Point(196, 427);
            this.lblSP.Name = "lblSP";
            this.lblSP.Size = new System.Drawing.Size(32, 31);
            this.lblSP.TabIndex = 10;
            this.lblSP.Text = "...";
            this.lblSP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSP.Click += new System.EventHandler(this.lblSP_Click);
            // 
            // lblQI
            // 
            this.lblQI.AutoSize = true;
            this.lblQI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblQI.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQI.Location = new System.Drawing.Point(617, 340);
            this.lblQI.Name = "lblQI";
            this.lblQI.Size = new System.Drawing.Size(32, 31);
            this.lblQI.TabIndex = 11;
            this.lblQI.Text = "...";
            this.lblQI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQI.Click += new System.EventHandler(this.lblQI_Click);
            // 
            // lblSI
            // 
            this.lblSI.AutoSize = true;
            this.lblSI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblSI.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSI.Location = new System.Drawing.Point(617, 427);
            this.lblSI.Name = "lblSI";
            this.lblSI.Size = new System.Drawing.Size(32, 31);
            this.lblSI.TabIndex = 12;
            this.lblSI.Text = "...";
            this.lblSI.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSI.Click += new System.EventHandler(this.lblSI_Click);
            // 
            // listImpar
            // 
            this.listImpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.listImpar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listImpar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listImpar.ForeColor = System.Drawing.Color.Transparent;
            this.listImpar.FormattingEnabled = true;
            this.listImpar.ItemHeight = 22;
            this.listImpar.Location = new System.Drawing.Point(516, 548);
            this.listImpar.Name = "listImpar";
            this.listImpar.Size = new System.Drawing.Size(208, 154);
            this.listImpar.TabIndex = 13;
            this.listImpar.Visible = false;
            // 
            // listPar
            // 
            this.listPar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.listPar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPar.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPar.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.listPar.FormattingEnabled = true;
            this.listPar.ItemHeight = 22;
            this.listPar.Location = new System.Drawing.Point(76, 548);
            this.listPar.Name = "listPar";
            this.listPar.Size = new System.Drawing.Size(208, 154);
            this.listPar.TabIndex = 14;
            this.listPar.Visible = false;
            // 
            // lblQtdNum
            // 
            this.lblQtdNum.AutoSize = true;
            this.lblQtdNum.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.lblQtdNum.Font = new System.Drawing.Font("Gadugi", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdNum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQtdNum.Location = new System.Drawing.Point(393, 218);
            this.lblQtdNum.Name = "lblQtdNum";
            this.lblQtdNum.Size = new System.Drawing.Size(32, 31);
            this.lblQtdNum.TabIndex = 15;
            this.lblQtdNum.Text = "...";
            this.lblQtdNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblQtdNum.Click += new System.EventHandler(this.lblQtdNum_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(548, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "fibonacci";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Par_Impar.Properties.Resources.difinitivo;
            this.ClientSize = new System.Drawing.Size(755, 749);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblQtdNum);
            this.Controls.Add(this.listPar);
            this.Controls.Add(this.listImpar);
            this.Controls.Add(this.lblSI);
            this.Controls.Add(this.lblQI);
            this.Controls.Add(this.lblSP);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblQP);
            this.Controls.Add(this.txtNumero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label lblQP;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSP;
        private System.Windows.Forms.Label lblQI;
        private System.Windows.Forms.Label lblSI;
        private System.Windows.Forms.ListBox listImpar;
        private System.Windows.Forms.ListBox listPar;
        private System.Windows.Forms.Label lblQtdNum;
        private System.Windows.Forms.Button button1;
    }
}

