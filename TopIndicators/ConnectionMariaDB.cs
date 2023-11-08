using System;
using System.Data;
using MySql.Data.MySqlClient;
using TopIndicators;
using DadosUsuarios;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto.Digests;
using TopIndicators;

namespace ConnectionMaria
{
    public class ProcessoDadosUsuarios
    {

        //public string connectionString = "Server=127.0.0.1;Database=projetoindicators;Uid=root;Pwd=123456789;";
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=projetoindicators;Uid=root;Pwd=123456789;");
        public void CriarUsuario(Usuario usuario)
        {
            //connection.ConnectionString = connectionString;

            try
            {
                connection.Open();

                string queryCreate = "INSERT INTO usuarios (nome, senha, setor) VALUES (@nome, @senha, @setor)";
                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                commandCreate.Parameters.AddWithValue("@nome", usuario.Nome);
                commandCreate.Parameters.AddWithValue("@senha", usuario.Senha);
                commandCreate.Parameters.AddWithValue("@setor", usuario.Setor);
                commandCreate.ExecuteNonQuery();
                Console.WriteLine("Usuário inserido com sucesso!");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }

        }

        public void LerUsuarios()
        {
            // READ - Selecionar todos os usuários
            string queryRead = "SELECT * FROM usuarios";
            MySqlCommand commandRead = new MySqlCommand(queryRead, connection);
            MySqlDataReader reader = commandRead.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine($"ID: {reader["id"]}, Nome: {reader["nome"]}, Senha: {reader["senha"]}, Setor: {reader["setor"]}");
            }
            reader.Close();
        }

        public void AtualizarDadosUsuario()
        {
            // UPDATE - Atualizar a senha do usuário com id = 1
            string queryUpdate = "UPDATE usuarios SET senha = @novaSenha WHERE id = @id";
            MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
            commandUpdate.Parameters.AddWithValue("@novaSenha", "654321");
            commandUpdate.Parameters.AddWithValue("@id", 1);
            commandUpdate.ExecuteNonQuery();
            Console.WriteLine("Senha do usuário atualizada com sucesso!");
        }

        public void DeletarUsuario()
        {
            // DELETE - Deletar o usuário com id = 2
            string queryDelete = "DELETE FROM usuarios WHERE id = @id";
            MySqlCommand commandDelete = new MySqlCommand(queryDelete, connection);
            commandDelete.Parameters.AddWithValue("@id", 2);
            commandDelete.ExecuteNonQuery();
            Console.WriteLine("Usuário deletado com sucesso!");
        }


    }

}