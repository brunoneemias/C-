
namespace _05_Nadador
{
    partial class Nadador
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
            System.Windows.Forms.Button btnLimpar;
            System.Windows.Forms.Button btnOk;
            System.Windows.Forms.Button btnSair;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Nadador));
            this.txtName = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dtbNascimento = new System.Windows.Forms.DateTimePicker();
            btnLimpar = new System.Windows.Forms.Button();
            btnOk = new System.Windows.Forms.Button();
            btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLimpar
            // 
            btnLimpar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            btnLimpar.BackColor = System.Drawing.Color.Transparent;
            btnLimpar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            btnLimpar.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnLimpar.FlatAppearance.BorderSize = 0;
            btnLimpar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnLimpar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpar.ForeColor = System.Drawing.Color.Transparent;
            btnLimpar.Location = new System.Drawing.Point(255, 321);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new System.Drawing.Size(101, 41);
            btnLimpar.TabIndex = 8;
            btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnLimpar.UseVisualStyleBackColor = false;
            btnLimpar.Click += new System.EventHandler(this.btnCalculaIdade_Click);
            // 
            // btnOk
            // 
            btnOk.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            btnOk.BackColor = System.Drawing.Color.Transparent;
            btnOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnOk.Cursor = System.Windows.Forms.Cursors.Hand;
            btnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnOk.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnOk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnOk.ForeColor = System.Drawing.Color.Transparent;
            btnOk.Location = new System.Drawing.Point(428, 321);
            btnOk.Name = "btnOk";
            btnOk.Size = new System.Drawing.Size(39, 41);
            btnOk.TabIndex = 9;
            btnOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnOk.UseVisualStyleBackColor = false;
            btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnSair
            // 
            btnSair.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            btnSair.BackColor = System.Drawing.Color.Transparent;
            btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            btnSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnSair.ForeColor = System.Drawing.Color.Transparent;
            btnSair.Location = new System.Drawing.Point(548, 321);
            btnSair.Name = "btnSair";
            btnSair.Size = new System.Drawing.Size(64, 41);
            btnSair.TabIndex = 10;
            btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtName.Location = new System.Drawing.Point(330, 122);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(326, 22);
            this.txtName.TabIndex = 11;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(125)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(330, 204);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(326, 22);
            this.textBox2.TabIndex = 12;
            // 
            // dtbNascimento
            // 
            this.dtbNascimento.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNascimento.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtbNascimento.CalendarTitleForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dtbNascimento.CalendarTrailingForeColor = System.Drawing.Color.Green;
            this.dtbNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtbNascimento.Location = new System.Drawing.Point(330, 202);
            this.dtbNascimento.Name = "dtbNascimento";
            this.dtbNascimento.Size = new System.Drawing.Size(324, 24);
            this.dtbNascimento.TabIndex = 13;
            // 
            // Nadador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(871, 493);
            this.ControlBox = false;
            this.Controls.Add(this.dtbNascimento);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(btnSair);
            this.Controls.Add(btnOk);
            this.Controls.Add(btnLimpar);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Nadador";
            this.Text = "Faixa etária";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DateTimePicker dtbNascimento;
    }
}

