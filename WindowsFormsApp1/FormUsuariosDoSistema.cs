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
    public partial class FormUsuariosDoSistema : Form
    {
        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        public FormUsuariosDoSistema()
        {
            InitializeComponent();
        }

        private void btnRemoverUsuario_Click(object sender, EventArgs e)
        {
            // Obtém o ID_Usuario e o Nome digitados nos TextBoxes
            string idUsuario = txtIDUsuario.Text;
            string nomeUsuario = txtNomeUsuario.Text;

            try
            {
                // Cria uma conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Cria o comando SQL para excluir o usuário com base no ID_Usuario e no Nome
                    string sqlQuery = "DELETE FROM Usuarios WHERE ID_Usuario = @ID_Usuario AND Nome = @Nome";

                    // Cria o SqlCommand e define os parâmetros
                    using (SqlCommand command = new SqlCommand(sqlQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ID_Usuario", idUsuario);
                        command.Parameters.AddWithValue("@Nome", nomeUsuario);

                        // Executa o comando SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Usuário removido com sucesso.");
                            // Atualiza o DataGridView após a remoção do usuário
                            ExibirUsuarios();
                        }
                        else
                        {
                            MessageBox.Show("Usuário não encontrado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer
                MessageBox.Show("Erro ao remover usuário: " + ex.Message);
            }
        }

        private void FormUsuariosDoSistema_Load(object sender, EventArgs e)
        {
            // Ao carregar o formulário, preencha o DataGridView com os dados da tabela "Usuarios"
            ExibirUsuarios();
        }
        private void ExibirUsuarios()
        {
            try
            {
                // Cria uma conexão com o banco de dados
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Abre a conexão com o banco de dados
                    connection.Open();

                    // Cria o comando SQL para selecionar todos os usuários
                    string sqlQuery = "SELECT * FROM Usuarios";

                    // Cria o SqlDataAdapter e preenche o DataTable
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlQuery, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    // Define o DataTable como a fonte de dados do DataGridView
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                // Trate qualquer exceção que possa ocorrer
                MessageBox.Show("Erro ao exibir usuários: " + ex.Message);
            }
        }
    }
}
