namespace WindowsFormsApp1
{
    partial class FormTelaUsuarios
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
            this.btnDv = new System.Windows.Forms.Button();
            this.btnAcervo = new System.Windows.Forms.Button();
            this.btnEmprestimo = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDv
            // 
            this.btnDv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDv.Location = new System.Drawing.Point(516, 224);
            this.btnDv.Name = "btnDv";
            this.btnDv.Size = new System.Drawing.Size(89, 93);
            this.btnDv.TabIndex = 6;
            this.btnDv.Text = "Devolução";
            this.btnDv.UseVisualStyleBackColor = false;
            this.btnDv.Click += new System.EventHandler(this.btnDv_Click);
            // 
            // btnAcervo
            // 
            this.btnAcervo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAcervo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcervo.Location = new System.Drawing.Point(348, 224);
            this.btnAcervo.Name = "btnAcervo";
            this.btnAcervo.Size = new System.Drawing.Size(89, 93);
            this.btnAcervo.TabIndex = 5;
            this.btnAcervo.Text = "Acervo";
            this.btnAcervo.UseVisualStyleBackColor = false;
            this.btnAcervo.Click += new System.EventHandler(this.btnAcervo_Click);
            // 
            // btnEmprestimo
            // 
            this.btnEmprestimo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnEmprestimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmprestimo.Location = new System.Drawing.Point(171, 224);
            this.btnEmprestimo.Name = "btnEmprestimo";
            this.btnEmprestimo.Size = new System.Drawing.Size(89, 93);
            this.btnEmprestimo.TabIndex = 4;
            this.btnEmprestimo.Text = "Empréstimo";
            this.btnEmprestimo.UseVisualStyleBackColor = false;
            this.btnEmprestimo.Click += new System.EventHandler(this.btnEmprestimo_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe Script", 19F, System.Drawing.FontStyle.Bold);
            this.lblNome.Location = new System.Drawing.Point(200, 52);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(405, 43);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "Selecione a opção desejada :";
            // 
            // FormTelaUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.btnDv);
            this.Controls.Add(this.btnAcervo);
            this.Controls.Add(this.btnEmprestimo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormTelaUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Biblioteca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDv;
        private System.Windows.Forms.Button btnAcervo;
        private System.Windows.Forms.Button btnEmprestimo;
        private System.Windows.Forms.Label lblNome;
    }
}