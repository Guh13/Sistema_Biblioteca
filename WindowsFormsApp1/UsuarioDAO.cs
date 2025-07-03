using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    
}
public class UsuarioDAO
    {
        private SqlConnection connection;

    public UsuarioDAO(string connectionString)
    {
        // Ignora a string de conexão que veio do formulário e usa a nossa, que sabemos que está 100% correta.
        string stringDeConexaoCorreta = "Server=localhost\\SQLEXPRESS;Database=BibliotecaDB;Trusted_Connection=True;TrustServerCertificate=True;";
        connection = new SqlConnection(stringDeConexaoCorreta);
    }

    public int ObterUsuarioId(string nomeUsuario)
        {
                int usuarioId = -1;

                string query = "SELECT ID_Usuario FROM Usuarios WHERE Nome = @Nome";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Nome", nomeUsuario);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    usuarioId = reader.GetInt32(0);
                }
                connection.Close();

                return usuarioId;
        }
}