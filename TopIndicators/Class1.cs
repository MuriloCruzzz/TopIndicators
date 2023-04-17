using System;
using System.Data;
using MySql.Data.MySqlClient;

public class Program
{
    public static void Main()
    {
        string connectionString = "Server=127.0.0.1;Uid=root;Pwd=123456789;";
        MySqlConnection connection = new MySqlConnection(connectionString);

        try
        {
            connection.Open();

            // Criar o banco de dados 'projetoindicators'
            string query = "CREATE DATABASE projetoindicators";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.ExecuteNonQuery();

            Console.WriteLine("Banco de dados criado com sucesso!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Erro ao criar o banco de dados: " + ex.Message);
        }
        finally
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }
}
