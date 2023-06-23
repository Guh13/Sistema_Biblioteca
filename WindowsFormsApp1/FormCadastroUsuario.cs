using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.Remoting.Contexts;

namespace WindowsFormsApp1
{
    public partial class FormCadastroUsuario : Form
    {
        private BindingSource bindingSourceUsuarios = new BindingSource();
        private SqlDataAdapter dataAdapterUsuarios = new SqlDataAdapter();
        private DataTable dataTableUsuarios = new DataTable();

        string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=BD_Biblioteca;Persist Security Info=True;User ID=sa;Password=12345678";
        public FormCadastroUsuario()
        {
            InitializeComponent();
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Obter os valores digitados pelo usuário
            string nome = txtNome.Text;
            string senha = txtSenha.Text;
            string endereco = txtEndereco.Text;
            string telefone = txtTelefone.Text;

            // Inserir os valores no banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para inserir os dados na tabela Usuarios
                    string query = "INSERT INTO Usuarios (Nome, Senha, Endereco, Telefone) " +
                        "VALUES (@Nome, @Senha, @Endereco, @Telefone)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Telefone", telefone);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();

                    // Limpar os campos de entrada de texto
                    txtNome.Clear();
                    txtSenha.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();

                    // Atualizar o DataTable com os novos dados
                    LoadUsuariosData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void LoadUsuariosData()
        {
            // Carregar os dados da tabela Usuarios no DataTable
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Comando SQL para selecionar todos os registros da tabela Usuarios
                    string query = "SELECT * FROM Usuarios";

                    dataAdapterUsuarios = new SqlDataAdapter(query, connection);

                    // Preencher o DataTable com os dados do banco de dados
                    dataTableUsuarios.Clear();
                    dataAdapterUsuarios.Fill(dataTableUsuarios);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao carregar os dados: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.Show();
        }
    }
}