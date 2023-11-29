using System;
using System.Data;
using MySql.Data.MySqlClient;
using TopIndicators;
using DadosUsuarios;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto.Digests;


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
    }
}