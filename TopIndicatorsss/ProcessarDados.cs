using System;
using System.Data;
using MySql.Data.MySqlClient;
using TopIndicators;
using DadosUsuarios;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto.Digests;
using TopIndicators;
using System.Windows.Forms;
using System.Collections.Generic;
using DadosDemanda;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
//using ListagemUsuario;


namespace Connection
{
    public class ProcessoDados
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=teste1;Uid=root;Pwd=123456789;");

        public void CriarUsuario(Usuario usuario)
        {
            //connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                string queryCreate = "INSERT INTO usuario (nome, senha, id_setor) VALUES (@nome, @senha, @setor)";
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
            connection.Close();
        }

        public void LerUsuarios(Demanda demanda)
        {
            try
            {
                connection.Open();

                string query = "SELECT nome, ID FROM usuario WHERE ID = @id";

                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", demanda.Id_Usuario);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            demanda.Id_Usuario = Convert.ToInt32(reader["id"]);
                        }
                        else
                        {
                            demanda.Id_Usuario = 0;
                        }
                        reader.Close();
                    }
                    
                    connection.Close();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Usuario não cadastrado!");
                connection.Close();
            }
        }

        public void AtualizarDadosUsuario()
        {
            
            string queryUpdate = "UPDATE usuarios SET senha = @novaSenha WHERE id = @id";
            MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
            commandUpdate.Parameters.AddWithValue("@novaSenha", "654321");
            commandUpdate.Parameters.AddWithValue("@id", 1);
            commandUpdate.ExecuteNonQuery();
            Console.WriteLine("Senha do usuário atualizada com sucesso!");
        }

        public void DeletarUsuario(Usuario usuario)
        {
            try 
            {
                connection.Open();
                // DELETE - Deletar o usuário com id = 2
                string queryDelete = "DELETE FROM usuario WHERE ID = @id";
                MySqlCommand commandDelete = new MySqlCommand(queryDelete, connection);
                commandDelete.Parameters.AddWithValue("@id", usuario.Id);
                commandDelete.ExecuteNonQuery();
                Console.WriteLine("Usuário deletado com sucesso!");

            }catch(Exception ex)
            {
                MessageBox.Show("Usuario não existente!!!");
            }
             
             connection.Close();
        }
        public void DeletarDemanda(Demanda demanda)
        {
            try
            {
                connection.Open();
                // DELETE - Deletar o usuário com id = 2
                string queryDelete = "DELETE FROM demanda WHERE ID = @id";
                MySqlCommand commandDelete = new MySqlCommand(queryDelete, connection);
                commandDelete.Parameters.AddWithValue("@id", demanda.Id);
                commandDelete.ExecuteNonQuery();
                Console.WriteLine("Demanda deletado com sucesso!");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Demanda não existente!!!");
            }

            connection.Close();
        }

        public void CriarDemanda(Demanda demanda)
        {
            //connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                string queryCreate = "INSERT INTO demanda (quantidade_Demandada, prazo, status, ID_Cliente, ID_Produto, Id_Usuario) VALUES (@quantidade_Demandada, @prazo, @status, @ID_Cliente, @ID_Produto, @Id_Usuario)";
                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                commandCreate.Parameters.AddWithValue("@quantidade_Demandada", demanda.quantidade_Demandada);
                commandCreate.Parameters.AddWithValue("@prazo", demanda.Prazo);
                commandCreate.Parameters.AddWithValue("@status", demanda.Status);
                commandCreate.Parameters.AddWithValue("@ID_CLiente", demanda.Id_Cliente);
                commandCreate.Parameters.AddWithValue("@Id_Produto", demanda.Id_Produto);
                commandCreate.Parameters.AddWithValue("@Id_Usuario", demanda.Id_Usuario);
                commandCreate.ExecuteNonQuery();
                //Console.WriteLine("Usuário inserido com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            connection.Close();
        }

    }

}