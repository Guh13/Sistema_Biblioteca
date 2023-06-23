namespace WindowsFormsApp1
{
    partial class FormLogin
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.Senha = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_BibliotecaDataSet = new WindowsFormsApp1.BD_BibliotecaDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp1.Properties.Resources.icons8_usuario_64_1;
            this.pictureBox1.Location = new System.Drawing.Point(142, 73);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 67);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtNome.Location = new System.Drawing.Point(92, 183);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(168, 20);
            this.txtNome.TabIndex = 13;
            // 
            // txtSenha
            // 
            this.txtSenha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.txtSenha.Location = new System.Drawing.Point(92, 228);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(168, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(33, 183);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 15;
            this.lblNome.Text = "Nome :";
            // 
            // Senha
            // 
            this.Senha.AutoSize = true;
            this.Senha.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Senha.Location = new System.Drawing.Point(29, 228);
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(57, 20);
            this.Senha.TabIndex = 16;
            this.Senha.Text = "Senha :";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(142, 311);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(72, 26);
            this.btnLogin.TabIndex = 17;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bD_BibliotecaDataSet;
            this.bindingSource1.Position = 0;
            // 
            // bD_BibliotecaDataSet
            // 
            this.bD_BibliotecaDataSet.DataSetName = "BD_BibliotecaDataSet";
            this.bD_BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(344, 479);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Login";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label Senha;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD_BibliotecaDataSet bD_BibliotecaDataSet;
    }
}