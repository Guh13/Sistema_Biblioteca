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
    public partial class FormAcervo : Form
    {
        private string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_Biblioteca;Persist Security Info=True;User ID=sa;Password=12345678";
        public FormAcervo()
        {
            InitializeComponent();
        }

        private void FormAcervo_Load(object sender, EventArgs e)
        {
            // Ao carregar o formulário, exiba todos os livros no DataGridView
            ExibirLivros();
        }

        private void ExibirLivros()
        {
            try
            {
                // Cria uma conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Cria o comando SQL para selecionar todos os livros
                    string sqlQuery = "SELECT * FROM Livros";

                    // Verifica se há um texto de pesquisa no TextBox
                    if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                    {
                        // Adiciona a cláusula WHERE à consulta para filtrar pelo nome do livro
                        sqlQuery += " WHERE Titulo LIKE '%' + @Titulo + '%'";
                    }

                    // Cria o SqlDataAdapter e preenche o DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);

                    // Define o parâmetro do nome do livro, se houver
                    if (!string.IsNullOrWhiteSpace(txtPesquisa.Text))
                    {
                        adapter.SelectCommand.Parameters.AddWithValue("@Titulo", txtPesquisa.Text);
                    }

                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer
                MessageBox.Show("Erro ao exibir livros: " + ex.Message);
            }
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            // Atualiza o DataGridView com base na pesquisa do usuário
            ExibirLivros();
        }
    }
}
