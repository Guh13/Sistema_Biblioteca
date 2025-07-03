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
    public partial class FormLogin : Form
    {
        string connectionString = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";


        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            {
                // Obter o nome de usuário e senha digitados pelo usuário
                string username = txtNome.Text;
                string password = txtSenha.Text;

                // Realizar a autenticação do usuário no banco de dados
                bool autenticacaoSucesso = AutenticarUsuario(username, password);

                if (autenticacaoSucesso)
                {
                    // Obter o tipo de usuário
                    string tipoUsuario = ObterTipoUsuario(username);

                    // Abrir o formulário correspondente com base no tipo de usuário
                    if (tipoUsuario == "Usuario")
                    {
                        // Aqui você pode abrir o formulário específico para usuários
                        FormTelaUsuarios formTelaUsuarios = new FormTelaUsuarios();
                        formTelaUsuarios.Show(); // Alteração: usar ShowDialog em vez de Show
                    }
                    else if (tipoUsuario == "Funcionario")
                    {
                        // Aqui você pode abrir o formulário específico para funcionários
                        FormCadastroLivros formDevolucao = new FormCadastroLivros();
                        formDevolucao.Show(); // Alteração: usar ShowDialog em vez de Show
                    }

                    // Exibir uma mensagem de sucesso ou navegar para o próximo formulário
                    MessageBox.Show("Login bem-sucedido!");

                    // Ou você pode fechar o formulário de login e retornar ao formulário anterior
                    this.Close();
                }
                else
                {
                    // Exibir uma mensagem de erro caso a autenticação falhe
                    MessageBox.Show("Falha na autenticação. Por favor, verifique suas credenciais.");
                }
            }
        }

        private bool AutenticarUsuario(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para verificar se o usuário existe na tabela de usuários
                    string query = "SELECT COUNT(*) FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", username);
                    command.Parameters.AddWithValue("@Senha", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    // Se o usuário existir na tabela, a contagem será maior que zero
                    return count > 0;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao autenticar o usuário: " + ex.Message);
                    return false;
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private string ObterTipoUsuario(string username)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para obter o tipo de usuário com base no nome de usuário
                    string query = "SELECT Tipo FROM Usuarios WHERE Nome = @Nome";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", username);

                    string tipoUsuario = command.ExecuteScalar()?.ToString();

                    return tipoUsuario;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao obter o tipo de usuário: " + ex.Message);
                    return string.Empty;
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}