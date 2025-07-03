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
    
    public partial class FormEmprestimo : Form
    {
        string connectionString;
        SqlConnection connection;

        UsuarioDAO usuarioDAO; // Instância da classe UsuarioDAO

        public FormEmprestimo()
        {
            InitializeComponent();

            connectionString = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";
            connection = new SqlConnection(connectionString);

            usuarioDAO = new UsuarioDAO(connectionString); // Instanciação da classe UsuarioDAO
        }

        public class Livro
        {
            public int ID_Livro { get; set; }
            public string NomeLivro { get; set; }

            public Livro(int id, string nome)
            {
                ID_Livro = id;
                NomeLivro = nome;
            }

            public override string ToString()
            {
                return NomeLivro;
            }
        }
        

        private void FormEmprestimo_Load(object sender, EventArgs e)
        {
            // Carregar os dados da tabela "Livros" no ComboBox
            string query = "SELECT ID_Livro, Titulo FROM Livros";
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                int livroId = reader.GetInt32(0);
                string livroNome = reader.GetString(1);
                comboBoxLivros.Items.Add(new Livro(livroId, livroNome));
            }
            connection.Close();
        }

        private void buttonEmprestimo_Click(object sender, EventArgs e)
        {
            // Verificar se um livro foi selecionado
            if (comboBoxLivros.SelectedItem == null)
            {
                MessageBox.Show("Selecione um livro.");
                return;
            }

            Livro livroSelecionado = (Livro)comboBoxLivros.SelectedItem;
            int livroId = livroSelecionado.ID_Livro;

            // Obter o nome do usuário digitado no TextBox
            string nomeUsuario = textBoxNomeUsuario.Text.Trim();

            // Verificar se o nome do usuário foi fornecido
            if (string.IsNullOrEmpty(nomeUsuario))
            {
                MessageBox.Show("Digite o nome do usuário.");
                return;
            }

            // Obter o usuarioId do usuário atual

            int usuarioId = usuarioDAO.ObterUsuarioId(nomeUsuario);

            if (usuarioId == -1)
            {
                MessageBox.Show("Usuário não encontrado.");
                return;
            }


            // Inserir o empréstimo na tabela "Emprestimo"
            string query = "INSERT INTO Emprestimos (ID_Livro, ID_Usuario, Data_Emprestimo, Data_Devolucao) " +
                           "VALUES (@ID_Livro, @ID_Usuario, @Data_Emprestimo, @Data_Devolucao)";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID_Livro", livroId);
            command.Parameters.AddWithValue("@ID_Usuario", usuarioId); // substitua pelo ID do usuário correto
            command.Parameters.AddWithValue("@Data_Emprestimo", DateTime.Now);
            command.Parameters.AddWithValue("@Data_Devolucao", DateTime.Now.AddDays(7)); // substitua pela data de devolução correta
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Empréstimo realizado com sucesso.");
        }

        private void comboBoxLivros_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
