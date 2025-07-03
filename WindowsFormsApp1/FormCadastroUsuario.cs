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

        private string connectionString = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";
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

            // AQUI ESTÁ A CORREÇÃO! Definimos um valor padrão para o tipo.
            string tipo = "Usuario";

            // Inserir os valores no banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // AQUI ESTÁ A CORREÇÃO NO SQL! Adicionamos a coluna e o parâmetro 'Tipo'.
                    string query = "INSERT INTO Usuarios (Nome, Senha, Endereco, Telefone, Tipo) " +
                                   "VALUES (@Nome, @Senha, @Endereco, @Telefone, @Tipo)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Nome", nome);
                    command.Parameters.AddWithValue("@Senha", senha);
                    command.Parameters.AddWithValue("@Endereco", endereco);
                    command.Parameters.AddWithValue("@Telefone", telefone);
                    command.Parameters.AddWithValue("@Tipo", tipo); // E AQUI ADICIONAMOS O PARÂMETRO!

                    command.ExecuteNonQuery();

                    txtNome.Clear();
                    txtSenha.Clear();
                    txtEndereco.Clear();
                    txtTelefone.Clear();

                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    LoadUsuariosData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro ao salvar os dados: " + ex.Message);
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