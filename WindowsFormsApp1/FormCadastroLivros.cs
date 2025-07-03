using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormCadastroLivros : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public FormCadastroLivros()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void FormDevolucao_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bD_BibliotecaDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bD_BibliotecaDataSet.Livros);

        }
        private void LimparCampos()
        {
            txtTitulo.Text = string.Empty;
            txtAutor.Text = string.Empty;
            txtEditora.Text = string.Empty;
            txtAnoPublicacao.Text = string.Empty;
            txtNumeroExemplares.Text = string.Empty;
        }

        private void btnCadastro_Click_1(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text;
            string autor = txtAutor.Text;
            string editora = txtEditora.Text;
            int anoPublicacao = Convert.ToInt32(txtAnoPublicacao.Text);
            int numeroExemplares = Convert.ToInt32(txtNumeroExemplares.Text);

            // Realizar o cadastro do livro no banco de dados
            bool sucesso = CadastrarLivro(titulo, autor, editora, anoPublicacao, numeroExemplares);

            if (sucesso)
            {
                MessageBox.Show("Livro cadastrado com sucesso!");
                LimparCampos();
            }
            else
            {
                MessageBox.Show("Falha ao cadastrar o livro. Verifique os dados informados.");
            }
        }
        private bool CadastrarLivro(string titulo, string autor, string editora, int anoPublicacao, int numeroExemplares)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para inserir um novo livro na tabela Livros
                    string query = "INSERT INTO Livros (Titulo, Autor, Editora, AnoPublicacao, NumeroExemplares) " +
                        "VALUES (@Titulo, @Autor, @Editora, @AnoPublicacao, @NumeroExemplares)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Titulo", titulo);
                    command.Parameters.AddWithValue("@Autor", autor);
                    command.Parameters.AddWithValue("@Editora", editora);
                    command.Parameters.AddWithValue("@AnoPublicacao", anoPublicacao);
                    command.Parameters.AddWithValue("@NumeroExemplares", numeroExemplares);

                    int rowsAffected = command.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao cadastrar o livro: " + ex.Message);
                    return false;
                }
            }
        }

        private void btnRegistroUsuarios_Click(object sender, EventArgs e)
        {
            FormUsuariosDoSistema formUsuariosDoSistema = new FormUsuariosDoSistema();
            formUsuariosDoSistema.Show();
        }

        private void btnDevolucao_Click(object sender, EventArgs e)
        {
            FormGerenciarDevolucoes formGerenciarDevolucoes = new FormGerenciarDevolucoes();
            formGerenciarDevolucoes.Show();
        }
    }
}