namespace WindowsFormsApp1
{
    partial class FormCadastroLivros
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.iDLivroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anoPublicacaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroExemplaresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bD_BibliotecaDataSet = new WindowsFormsApp1.BD_BibliotecaDataSet();
            this.lblNumero = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtAnoPublicacao = new System.Windows.Forms.TextBox();
            this.txtNumeroExemplares = new System.Windows.Forms.TextBox();
            this.txtEditora = new System.Windows.Forms.TextBox();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnDevolucao = new System.Windows.Forms.Button();
            this.btnRegistroUsuarios = new System.Windows.Forms.Button();
            this.livrosTableAdapter = new WindowsFormsApp1.BD_BibliotecaDataSetTableAdapters.LivrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BibliotecaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.AutoGenerateColumns = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDLivroDataGridViewTextBoxColumn,
            this.tituloDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.editoraDataGridViewTextBoxColumn,
            this.anoPublicacaoDataGridViewTextBoxColumn,
            this.numeroExemplaresDataGridViewTextBoxColumn});
            this.dgvLivros.DataSource = this.livrosBindingSource;
            this.dgvLivros.Location = new System.Drawing.Point(368, 11);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(645, 524);
            this.dgvLivros.TabIndex = 1;
            // 
            // iDLivroDataGridViewTextBoxColumn
            // 
            this.iDLivroDataGridViewTextBoxColumn.DataPropertyName = "ID_Livro";
            this.iDLivroDataGridViewTextBoxColumn.HeaderText = "ID_Livro";
            this.iDLivroDataGridViewTextBoxColumn.Name = "iDLivroDataGridViewTextBoxColumn";
            // 
            // tituloDataGridViewTextBoxColumn
            // 
            this.tituloDataGridViewTextBoxColumn.DataPropertyName = "Titulo";
            this.tituloDataGridViewTextBoxColumn.HeaderText = "Titulo";
            this.tituloDataGridViewTextBoxColumn.Name = "tituloDataGridViewTextBoxColumn";
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            // 
            // editoraDataGridViewTextBoxColumn
            // 
            this.editoraDataGridViewTextBoxColumn.DataPropertyName = "Editora";
            this.editoraDataGridViewTextBoxColumn.HeaderText = "Editora";
            this.editoraDataGridViewTextBoxColumn.Name = "editoraDataGridViewTextBoxColumn";
            // 
            // anoPublicacaoDataGridViewTextBoxColumn
            // 
            this.anoPublicacaoDataGridViewTextBoxColumn.DataPropertyName = "AnoPublicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.HeaderText = "AnoPublicacao";
            this.anoPublicacaoDataGridViewTextBoxColumn.Name = "anoPublicacaoDataGridViewTextBoxColumn";
            // 
            // numeroExemplaresDataGridViewTextBoxColumn
            // 
            this.numeroExemplaresDataGridViewTextBoxColumn.DataPropertyName = "NumeroExemplares";
            this.numeroExemplaresDataGridViewTextBoxColumn.HeaderText = "NumeroExemplares";
            this.numeroExemplaresDataGridViewTextBoxColumn.Name = "numeroExemplaresDataGridViewTextBoxColumn";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bindingSource1;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.bD_BibliotecaDataSet;
            this.bindingSource1.Position = 0;
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // bD_BibliotecaDataSet
            // 
            this.bD_BibliotecaDataSet.DataSetName = "BD_BibliotecaDataSet";
            this.bD_BibliotecaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumero.Location = new System.Drawing.Point(25, 306);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(95, 20);
            this.lblNumero.TabIndex = 32;
            this.lblNumero.Text = "Quantidade :";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(2, 270);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(118, 20);
            this.lblAno.TabIndex = 31;
            this.lblAno.Text = "Ano  Publicação:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(55, 234);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(65, 20);
            this.lblEditora.TabIndex = 30;
            this.lblEditora.Text = "Editora :";
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutor.Location = new System.Drawing.Point(63, 199);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(55, 20);
            this.lblAutor.TabIndex = 29;
            this.lblAutor.Text = "Autor :";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe Script", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(63, 160);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(57, 20);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Titulo :";
            // 
            // txtAnoPublicacao
            // 
            this.txtAnoPublicacao.Location = new System.Drawing.Point(120, 270);
            this.txtAnoPublicacao.Name = "txtAnoPublicacao";
            this.txtAnoPublicacao.Size = new System.Drawing.Size(189, 20);
            this.txtAnoPublicacao.TabIndex = 27;
            // 
            // txtNumeroExemplares
            // 
            this.txtNumeroExemplares.Location = new System.Drawing.Point(120, 306);
            this.txtNumeroExemplares.Name = "txtNumeroExemplares";
            this.txtNumeroExemplares.Size = new System.Drawing.Size(189, 20);
            this.txtNumeroExemplares.TabIndex = 26;
            // 
            // txtEditora
            // 
            this.txtEditora.Location = new System.Drawing.Point(120, 234);
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Size = new System.Drawing.Size(189, 20);
            this.txtEditora.TabIndex = 25;
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(120, 199);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(189, 20);
            this.txtAutor.TabIndex = 24;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(120, 160);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(189, 20);
            this.txtTitulo.TabIndex = 23;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Location = new System.Drawing.Point(146, 355);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(137, 55);
            this.btnCadastro.TabIndex = 22;
            this.btnCadastro.Text = "Cadastrar Livro";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click_1);
            // 
            // btnDevolucao
            // 
            this.btnDevolucao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnDevolucao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDevolucao.Location = new System.Drawing.Point(200, 35);
            this.btnDevolucao.Name = "btnDevolucao";
            this.btnDevolucao.Size = new System.Drawing.Size(137, 55);
            this.btnDevolucao.TabIndex = 34;
            this.btnDevolucao.Text = "Registro de Devoluções";
            this.btnDevolucao.UseVisualStyleBackColor = false;
            this.btnDevolucao.Click += new System.EventHandler(this.btnDevolucao_Click);
            // 
            // btnRegistroUsuarios
            // 
            this.btnRegistroUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnRegistroUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroUsuarios.Location = new System.Drawing.Point(43, 35);
            this.btnRegistroUsuarios.Name = "btnRegistroUsuarios";
            this.btnRegistroUsuarios.Size = new System.Drawing.Size(137, 55);
            this.btnRegistroUsuarios.TabIndex = 33;
            this.btnRegistroUsuarios.Text = "Registro de Usuarios";
            this.btnRegistroUsuarios.UseVisualStyleBackColor = false;
            this.btnRegistroUsuarios.Click += new System.EventHandler(this.btnRegistroUsuarios_Click);
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // FormCadastroLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1025, 547);
            this.Controls.Add(this.btnDevolucao);
            this.Controls.Add(this.btnRegistroUsuarios);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtAnoPublicacao);
            this.Controls.Add(this.txtNumeroExemplares);
            this.Controls.Add(this.txtEditora);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.dgvLivros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCadastroLivros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela de Gerenciamento";
            this.Load += new System.EventHandler(this.FormDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_BibliotecaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtAnoPublicacao;
        private System.Windows.Forms.TextBox txtNumeroExemplares;
        private System.Windows.Forms.TextBox txtEditora;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnDevolucao;
        private System.Windows.Forms.Button btnRegistroUsuarios;
        private System.Windows.Forms.BindingSource bindingSource1;
        private BD_BibliotecaDataSet bD_BibliotecaDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BD_BibliotecaDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDLivroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn editoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn anoPublicacaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroExemplaresDataGridViewTextBoxColumn;
    }
}