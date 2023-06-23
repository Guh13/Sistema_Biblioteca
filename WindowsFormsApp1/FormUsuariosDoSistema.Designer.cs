namespace WindowsFormsApp1
{
    partial class FormUsuariosDoSistema
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtNomeUsuario = new System.Windows.Forms.TextBox();
            this.btnRemoverUsuario = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(258, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 426);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtNomeUsuario
            // 
            this.txtNomeUsuario.Location = new System.Drawing.Point(60, 176);
            this.txtNomeUsuario.Name = "txtNomeUsuario";
            this.txtNomeUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtNomeUsuario.TabIndex = 1;
            // 
            // btnRemoverUsuario
            // 
            this.btnRemoverUsuario.Location = new System.Drawing.Point(107, 237);
            this.btnRemoverUsuario.Name = "btnRemoverUsuario";
            this.btnRemoverUsuario.Size = new System.Drawing.Size(96, 33);
            this.btnRemoverUsuario.TabIndex = 2;
            this.btnRemoverUsuario.Text = "Remover";
            this.btnRemoverUsuario.UseVisualStyleBackColor = true;
            this.btnRemoverUsuario.Click += new System.EventHandler(this.btnRemoverUsuario_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(60, 134);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(183, 20);
            this.txtIDUsuario.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(1, 176);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(53, 20);
            this.lblNome.TabIndex = 6;
            this.lblNome.Text = "Nome :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Deseja remover o usuário?\r\n";
            // 
            // FormUsuariosDoSistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.btnRemoverUsuario);
            this.Controls.Add(this.txtNomeUsuario);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormUsuariosDoSistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuários do Sistema";
            this.Load += new System.EventHandler(this.FormUsuariosDoSistema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtNomeUsuario;
        private System.Windows.Forms.Button btnRemoverUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}