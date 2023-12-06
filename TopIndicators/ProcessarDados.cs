using System;
using System.Data;
using MySql.Data.MySqlClient;
using TopIndicators;
using DadosUsuarios;
using System.Xml.Xsl;
using Org.BouncyCastle.Crypto.Digests;
using System.Windows.Forms;
using System.Collections.Generic;
using DadosDemanda;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;
using System.Data.SqlClient;
using ExcelDataReader;
using System.IO;
using System.Windows.Controls;
//using ListagemUsuario;


namespace Connection
{
    public class ProcessoDados
    {
        public static MySqlConnection connection = new MySqlConnection("Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;");
        private object reader;

        public void CriarUsuario(Usuario usuario)
        {
            //connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                string queryCreate = "INSERT INTO usuario (nome, senha, id_setor, Grupo_Acesso, Status_Usuario, turno) " +
                    "VALUES (@nome, @senha, @setor, @Grupo_Acesso, @Status_Usuario, @turno)";
                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                commandCreate.Parameters.AddWithValue("@nome", usuario.Nome);
                commandCreate.Parameters.AddWithValue("@senha", usuario.Senha);
                commandCreate.Parameters.AddWithValue("@setor", usuario.Setor);
                commandCreate.Parameters.AddWithValue("@Grupo_Acesso", usuario.Grupo_Acesso);
                commandCreate.Parameters.AddWithValue("@Status_Usuario", usuario.Status_Usuario);
                commandCreate.Parameters.AddWithValue("@turno", usuario.Turno_Usuario);
                commandCreate.ExecuteNonQuery();
                Console.WriteLine("Usuário "+usuario.Nome+" inserido com sucesso!");
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
        public void InserirTabelaClientes()
        {
            connection.Open();

            // Diálogo para selecionar o arquivo Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    if (openFileDialog.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (openFileDialog.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        throw new Exception("Tipo de arquivo não suportado.");
                    }

                    // Ler os dados do arquivo Excel
                    try
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                string idCliente = (reader.GetString(0)); // Assumindo que a primeira coluna contém Id_Cliente
                                string nome = reader.GetString(1);
                                string CNPJ = reader.GetString(2);
                                int idClienteINT = int.Parse(idCliente);// Assumindo que a segunda coluna contém Nome

                                // Inserir os dados na tabela do banco de dados
                                string queryCreate = "INSERT INTO cliente (id_Cliente, nome, CNPJ) VALUES (@id_Cliente, @nome, @CNPJ)";
                                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                                {
                                    commandCreate.Parameters.AddWithValue("@id_Cliente", idClienteINT);
                                    commandCreate.Parameters.AddWithValue("@nome", nome);
                                    commandCreate.Parameters.AddWithValue("@CNPJ", CNPJ);

                                    commandCreate.ExecuteNonQuery();
                                }

                            }
                        } while (reader.NextResult());
                    }
                    catch (Exception ex)
                    {
                        // Exibir a mensagem de erro
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            connection.Close();
        }
        public void InserirTabelaMateriaPrima()
        {
            connection.Open();

            // Diálogo para selecionar o arquivo Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    if (openFileDialog.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (openFileDialog.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        throw new Exception("Tipo de arquivo não suportado.");
                    }

                    // Ler os dados do arquivo Excel
                    try
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                int idProduto = int.Parse(reader.GetString(0)); // Assumindo que a primeira coluna contém Id_Cliente
                                DateTime Data_Validade = DateTime.Parse(reader.GetString(1));
                                string Nome = reader.GetString(2);
                                int estoque = int.Parse(reader.GetString(3));
                                int estoque_minimo = int.Parse(reader.GetString(4));
                                int estoque_maximo = int.Parse(reader.GetString(5));
                                string status = "OK";

                                // Inserir os dados na tabela do banco de dados
                                string queryCreate = "INSERT INTO produto_materia_prima (id_produto,Quantidade, Data_Validade, Nome, estoque_minimo, estoque_maximo, status) VALUES (@id_produto, @quantidade, @Data_Validade, @Nome, @estoque_minimo, @estoque_maximo, @status)";
                                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                                {
                                    commandCreate.Parameters.AddWithValue("@id_produto", idProduto);
                                    commandCreate.Parameters.AddWithValue("@quantidade", estoque);
                                    commandCreate.Parameters.AddWithValue("@Data_Validade", Data_Validade);
                                    commandCreate.Parameters.AddWithValue("@Nome", Nome);
                                    commandCreate.Parameters.AddWithValue("@estoque_minimo", estoque_minimo);
                                    commandCreate.Parameters.AddWithValue("@estoque_maximo", estoque_maximo);
                                    commandCreate.Parameters.AddWithValue("@status", status);

                                    commandCreate.ExecuteNonQuery();
                                }

                            }
                        } while (reader.NextResult());
                    }
                    catch (Exception ex)
                    {
                        // Exibir a mensagem de erro
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            connection.Close();
        }
        public void InserirTabelaMaterial()
        {
            connection.Open();

            // Diálogo para selecionar o arquivo Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    if (openFileDialog.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (openFileDialog.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        throw new Exception("Tipo de arquivo não suportado.");
                    }

                    // Ler os dados do arquivo Excel
                    try
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                int idProduto = int.Parse(reader.GetString(0)); // Assumindo que a primeira coluna contém Id_Cliente
                                DateTime Data_Validade = DateTime.Parse(reader.GetString(1));
                                string Nome = reader.GetString(2);
                                int estoque = int.Parse(reader.GetString(3));
                                int estoque_minimo = int.Parse(reader.GetString(4));
                                int estoque_maximo = int.Parse(reader.GetString(5));
                                string status = "OK";

                                // Inserir os dados na tabela do banco de dados
                                string queryCreate = "INSERT INTO produto_materia_prima_componente (id_produto, Quantidade, Data_Validade, Nome, estoque_minimo, estoque_maximo, status) VALUES (@id_produto, @Quantidade, @Data_Validade, @Nome, @estoque_minimo, @estoque_maximo, @status)";
                                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                                {
                                    commandCreate.Parameters.AddWithValue("@id_produto", idProduto);
                                    commandCreate.Parameters.AddWithValue("@Quantidade", estoque);
                                    commandCreate.Parameters.AddWithValue("@Data_Validade", Data_Validade);
                                    commandCreate.Parameters.AddWithValue("@Nome", Nome);
                                    commandCreate.Parameters.AddWithValue("@estoque_minimo", estoque_minimo);
                                    commandCreate.Parameters.AddWithValue("@estoque_maximo", estoque_maximo);
                                    commandCreate.Parameters.AddWithValue("@status", status);

                                    commandCreate.ExecuteNonQuery();
                                }

                            }
                        } while (reader.NextResult());
                    }
                    catch (Exception ex)
                    {
                        // Exibir a mensagem de erro
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            connection.Close();
        }
        public void InserirTabelaProdutoAcabado()
        {
            connection.Open();

            // Diálogo para selecionar o arquivo Excel
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos do Excel|*.xlsx;*.xls";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    IExcelDataReader reader;
                    if (openFileDialog.FileName.EndsWith(".xls"))
                    {
                        reader = ExcelReaderFactory.CreateBinaryReader(stream);
                    }
                    else if (openFileDialog.FileName.EndsWith(".xlsx"))
                    {
                        reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    }
                    else
                    {
                        throw new Exception("Tipo de arquivo não suportado.");
                    }

                    // Ler os dados do arquivo Excel
                    try
                    {
                        do
                        {
                            while (reader.Read())
                            {
                                int idProdutoA = int.Parse(reader.GetString(0)); // Assumindo que a primeira coluna contém Id_Cliente
                                DateTime Data_Validade = DateTime.Parse(reader.GetString(1));
                                string nome_produto = reader.GetString(2);
                                string PPH = reader.GetString(3);
                                int KU = int.Parse(reader.GetString(4));
                                int YIELD = int.Parse(reader.GetString(5));
                                string material_consumo = reader.GetString(6);
                                string materia_prima_consumo = reader.GetString(7);
                                string cliente = reader.GetString(8);

                                // Inserir os dados na tabela do banco de dados
                                string queryCreate = "INSERT INTO produto_acabado (id_produto, Quantidade, Data_Validade, Nome, PPH, KU, YIELD, Material_Consumo, Materia_Prima_Consumo, Cliente) VALUES " +
                                    "(@id_produto,0, @Data_Validade, @Nome, @PPH, @KU, @YIELD, @Material_Consumo, @Materia_Prima_Consumo, @Cliente)";
                                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                                {
                                    commandCreate.Parameters.AddWithValue("@id_produto", idProdutoA);
                                    commandCreate.Parameters.AddWithValue("@Data_Validade", Data_Validade);
                                    commandCreate.Parameters.AddWithValue("@Nome", nome_produto);
                                    commandCreate.Parameters.AddWithValue("@PPH", int.Parse(PPH));
                                    commandCreate.Parameters.AddWithValue("@KU", KU);
                                    commandCreate.Parameters.AddWithValue("@YIELD", YIELD);
                                    commandCreate.Parameters.AddWithValue("@Material_Consumo", material_consumo);
                                    commandCreate.Parameters.AddWithValue("@Materia_Prima_Consumo", materia_prima_consumo);
                                    commandCreate.Parameters.AddWithValue("@Cliente", cliente);

                                    commandCreate.ExecuteNonQuery();
                                }

                            }
                        } while (reader.NextResult());
                    }
                    catch (Exception ex)
                    {
                        // Exibir a mensagem de erro
                        Console.WriteLine(ex.Message);
                    }
                }
            }
            connection.Close();
        }
        public void InserirDemanda()
        {

        }
    }
}