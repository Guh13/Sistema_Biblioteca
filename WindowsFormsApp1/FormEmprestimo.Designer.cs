namespace WindowsFormsApp1
{
    partial class FormEmprestimo
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
            this.comboBoxLivros = new System.Windows.Forms.ComboBox();
            this.buttonEmprestimo = new System.Windows.Forms.Button();
            this.textBoxNomeUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxLivros
            // 
            this.comboBoxLivros.FormattingEnabled = true;
            this.comboBoxLivros.Location = new System.Drawing.Point(35, 131);
            this.comboBoxLivros.Name = "comboBoxLivros";
            this.comboBoxLivros.Size = new System.Drawing.Size(185, 21);
            this.comboBoxLivros.TabIndex = 0;
            this.comboBoxLivros.SelectedIndexChanged += new System.EventHandler(this.comboBoxLivros_SelectedIndexChanged_1);
            // 
            // buttonEmprestimo
            // 
            this.buttonEmprestimo.Location = new System.Drawing.Point(70, 368);
            this.buttonEmprestimo.Name = "buttonEmprestimo";
            this.buttonEmprestimo.Size = new System.Drawing.Size(127, 43);
            this.buttonEmprestimo.TabIndex = 2;
            this.buttonEmprestimo.Text = "Realizar Empréstimo";
            this.buttonEmprestimo.UseVisualStyleBackColor = true;
            this.buttonEmprestimo.Click += new System.EventHandler(this.buttonEmprestimo_Click);
            // 
            // textBoxNomeUsuario
            // 
            this.textBoxNomeUsuario.Location = new System.Drawing.Point(35, 246);
            this.textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            this.textBoxNomeUsuario.Size = new System.Drawing.Size(185, 20);
            this.textBoxNomeUsuario.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(47, 98);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(164, 20);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Digite o titulo do livro :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Digite seu nome de usuário :\r\n";
            // 
            // FormEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(261, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.textBoxNomeUsuario);
            this.Controls.Add(this.buttonEmprestimo);
            this.Controls.Add(this.comboBoxLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormEmprestimo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Emprestimo";
            this.Load += new System.EventHandler(this.FormEmprestimo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxLivros;
        private System.Windows.Forms.Button buttonEmprestimo;
        private System.Windows.Forms.TextBox textBoxNomeUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
    }
}