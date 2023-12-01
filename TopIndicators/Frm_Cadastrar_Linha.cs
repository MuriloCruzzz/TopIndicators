using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using DadosUsuarios;
using DadosDemanda;
using MySqlX.XDevAPI;
using Microsoft.ReportingServices.Diagnostics.Internal;

namespace TopIndicators
{
    public partial class Frm_Cadastrar_Linha : Form
    {

        public Frm_Cadastrar_Linha()
        {
            InitializeComponent();
        }
        public void Frm_Cadastrar_Linha_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                // Consulta SQL para selecionar os nomes dos clientes
                string query = "SELECT nome FROM cliente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string nomeCliente = reader["Nome"].ToString();
                            Listar_Clientes.Items.Add(nomeCliente);
                        }
                    }
                }
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                int id_cliente = 0;
                int id_produto = 0;
                connection.Open();

                string query = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida FROM demanda where status_demanda = 0";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            id_cliente = (int)reader["ID_Cliente"];
                            id_produto = (int)reader["ID_Produto"];
                            dtv_listarDemanda.Rows.Add(reader["id_Demanda"], reader["quantidade_Demandada"], reader["prazo"], reader["ID_Cliente"], reader["ID_Produto"], reader["qunatidade_produzida"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }

                }
                //connection.Open();

                string query5 = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida from demanda where status_demanda = 0"; // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                MySqlCommand command5 = new MySqlCommand(query5, connection);

                using (MySqlDataReader reader5 = command.ExecuteReader())
                {
                    if (reader5.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader5.Read())
                        {
                            // Armazena o valor de id_demanda na variável id_demanda
                            int id_demanda = (int)reader5["id_demanda"];

                            // Armazena o valor de quantidade_demandada na variável quantidade_demandada
                            int quantidade_demandada = (int)reader5["quantidade_demandada"];

                            int quantidade_produzida = (int)reader5["qunatidade_produzida"];

                            // Armazena o valor de prazo na variável prazo
                            DateTime prazo = (DateTime)reader5["prazo"];

                            // Armazena o valor de nome_produto na variável nome_produto

                            string nome_cliente_s = reader5["ID_Cliente"].ToString();
                            int id_cliente_int_s = int.Parse(nome_cliente_s);
                            string nome_cliente = "";
                            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
                            {
                                connection4.Open();

                                // Cria um comando SQL para selecionar o nome do cliente
                                MySqlCommand command4 = new MySqlCommand("SELECT nome FROM cliente where id_Cliente = @id_cliente", connection4);

                                // Adiciona o parâmetro @id_cliente à consulta SQL
                                command4.Parameters.AddWithValue("@id_cliente", id_cliente_int_s);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader4 = command4.ExecuteReader())
                                {
                                    if (reader4.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader4.Read();

                                        // Obtém o valor da coluna nome
                                        nome_cliente = reader4["nome"].ToString();
                                    }
                                }
                                connection4.Close();

                            }

                            string nome_produto_int = reader5["ID_Produto"].ToString();
                            int id_produto_int_s = int.Parse(nome_produto_int);
                            string nome_produto = "";
                            using (MySqlConnection connection5 = new MySqlConnection(connectionString))
                            {
                                connection5.Open();

                                // Cria um comando SQL para selecionar o nome do produto
                                MySqlCommand command7 = new MySqlCommand("SELECT Nome FROM produto_acabado where id_produto = @id_produto", connection5);

                                // Adiciona o parâmetro @id_produto à consulta SQL
                                command7.Parameters.AddWithValue("@id_produto", id_produto_int_s);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader7 = command7.ExecuteReader())
                                {
                                    if (reader7.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader7.Read();

                                        // Obtém o valor da coluna nome
                                        nome_produto = reader7["Nome"].ToString();
                                    }
                                }
                                connection5.Close();
                                dtv_listarDemanda.Rows.Add(id_demanda, quantidade_demandada, prazo, nome_cliente, nome_produto, quantidade_produzida);
                            }

                            // Adiciona a linha ao DataGridVie
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

            }
        }
        public void Atualizar_dados()
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                int id_cliente = 0;
                int id_produto = 0;
                connection.Open();

                string query = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida FROM demanda where status_demanda = 0";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            id_cliente = (int)reader["ID_Cliente"];
                            id_produto = (int)reader["ID_Produto"];
                            dtv_listarDemanda.Rows.Add(reader["id_Demanda"], reader["quantidade_Demandada"], reader["prazo"], reader["ID_Cliente"], reader["ID_Produto"], reader["qunatidade_produzida"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }

                }
                //connection.Open();

                string query5 = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida from demanda where status_demanda = 0"; // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                MySqlCommand command5 = new MySqlCommand(query5, connection);

                using (MySqlDataReader reader5 = command.ExecuteReader())
                {
                    if (reader5.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader5.Read())
                        {
                            // Armazena o valor de id_demanda na variável id_demanda
                            int id_demanda = (int)reader5["id_demanda"];

                            // Armazena o valor de quantidade_demandada na variável quantidade_demandada
                            int quantidade_demandada = (int)reader5["quantidade_demandada"];

                            int quantidade_produzida = (int)reader5["qunatidade_produzida"];

                            // Armazena o valor de prazo na variável prazo
                            DateTime prazo = (DateTime)reader5["prazo"];

                            // Armazena o valor de nome_produto na variável nome_produto

                            string nome_cliente_s = reader5["ID_Cliente"].ToString();
                            int id_cliente_int_s = int.Parse(nome_cliente_s);
                            string nome_cliente = "";
                            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
                            {
                                connection4.Open();

                                // Cria um comando SQL para selecionar o nome do cliente
                                MySqlCommand command4 = new MySqlCommand("SELECT nome FROM cliente where id_Cliente = @id_cliente", connection4);

                                // Adiciona o parâmetro @id_cliente à consulta SQL
                                command4.Parameters.AddWithValue("@id_cliente", id_cliente_int_s);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader4 = command4.ExecuteReader())
                                {
                                    if (reader4.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader4.Read();

                                        // Obtém o valor da coluna nome
                                        nome_cliente = reader4["nome"].ToString();
                                    }
                                }
                                connection4.Close();

                            }

                            string nome_produto_int = reader5["ID_Produto"].ToString();
                            int id_produto_int_s = int.Parse(nome_produto_int);
                            string nome_produto = "";
                            using (MySqlConnection connection5 = new MySqlConnection(connectionString))
                            {
                                connection5.Open();

                                // Cria um comando SQL para selecionar o nome do produto
                                MySqlCommand command7 = new MySqlCommand("SELECT Nome FROM produto_acabado where id_produto = @id_produto", connection5);

                                // Adiciona o parâmetro @id_produto à consulta SQL
                                command7.Parameters.AddWithValue("@id_produto", id_produto_int_s);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader7 = command7.ExecuteReader())
                                {
                                    if (reader7.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader7.Read();

                                        // Obtém o valor da coluna nome
                                        nome_produto = reader7["Nome"].ToString();
                                    }
                                }
                                connection5.Close();
                                dtv_listarDemanda.Rows.Add(id_demanda, quantidade_demandada, prazo, nome_cliente, nome_produto, quantidade_produzida);
                            }

                            // Adiciona a linha ao DataGridVie
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

            }

        }

        public void dtv_listarDemanda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Obtém o valor da coluna id_demanda
                int id_demanda = Convert.ToInt32(dtv_listarDemanda.Rows[e.RowIndex].Cells["id_Demanda"].Value);

                // Obtém o valor da coluna quantidade_demandada
                int qunatidade_produzida = Convert.ToInt32(dtv_listarDemanda.Rows[e.RowIndex].Cells["quantidade_Demandanda"].Value);

                // Obtém o valor da coluna prazo
                string prazo = dtv_listarDemanda.Rows[e.RowIndex].Cells["prazo"].Value.ToString();

                // Obtém o valor da coluna nome_cliente
                string nome_cliente = dtv_listarDemanda.Rows[e.RowIndex].Cells["nome_cliente"].Value.ToString();

                // Obtém o valor da coluna nome_produto
                string nome_produto = dtv_listarDemanda.Rows[e.RowIndex].Cells["nome_produto"].Value.ToString();

                // Obtém o valor da coluna quantidade_produzida
                int quantidade_produzida = Convert.ToInt32(dtv_listarDemanda.Rows[e.RowIndex].Cells["atual"].Value);

                // Passa os valores para o formulário
                Frm_Confirmação_Linha frm = new Frm_Confirmação_Linha();
                frm.id_demanda = id_demanda;
                frm.quantidade_demandada = qunatidade_produzida;
                frm.prazo = prazo;
                frm.nome_cliente = nome_cliente;
                frm.nome_produto = nome_produto;
                frm.quantidade_produzida = quantidade_produzida;
                frm.ShowDialog();
                Atualizar_dados();
            }
        }


        private void Listar_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Listar_Clientes_TextChanged(object sender, EventArgs e)
        {
            comboBox1.Text = ""; 
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão

            string nome_cliente_s = Listar_Clientes.Text;
            string nomeCliente = Listar_Clientes.Text;

            using (MySqlConnection connection1 = new MySqlConnection(connectionString))
            {
                try
                {
                    connection1.Open();

                    string query2 = "SELECT Nome FROM produto_acabado WHERE Cliente = @cliente_id";
                    MySqlCommand commandCreate2 = new MySqlCommand(query2, connection1);

                    commandCreate2.Parameters.AddWithValue("@cliente_id", nomeCliente);

                    using (MySqlDataReader reader = commandCreate2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Limpa as opções do ComboBox
                            comboBox1.Items.Clear();

                            // Adiciona as opções ao ComboBox
                            while (reader.Read())
                            {
                                comboBox1.Items.Add(reader["nome"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }

            //int id_cliente_int_s = int.Parse(nome_cliente_s);
            int nome_cliente_id = 0;
            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
            {
                connection4.Open();

                // Cria um comando SQL para selecionar o nome do cliente
                MySqlCommand command4 = new MySqlCommand("SELECT id_Cliente FROM cliente where nome = @nome", connection4);

                // Adiciona o parâmetro @id_cliente à consulta SQL
                command4.Parameters.AddWithValue("@nome", nome_cliente_s);

                // Executa a consulta SQL e obtém o DataReader
                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Lê a próxima linha
                        reader4.Read();

                        // Obtém o valor da coluna nome
                        nome_cliente_id = int.Parse(reader4["id_Cliente"].ToString());
                    }
                }


                string query5 = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida from demanda where status_demanda = 0 AND ID_Cliente = " + nome_cliente_id + ";"; // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                                                                                                                                                                                                                // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                MySqlCommand command5 = new MySqlCommand(query5, connection4);

                using (MySqlDataReader reader5 = command5.ExecuteReader())
                {
                    if (reader5.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader5.Read())
                        {
                            // Armazena o valor de id_demanda na variável id_demanda
                            int id_demanda = (int)reader5["id_demanda"];

                            // Armazena o valor de quantidade_demandada na variável quantidade_demandada
                            int quantidade_demandada = (int)reader5["quantidade_demandada"];

                            int quantidade_produzida = (int)reader5["qunatidade_produzida"];

                            // Armazena o valor de prazo na variável prazo
                            DateTime prazo = (DateTime)reader5["prazo"];

                            // Armazena o valor de nome_produto na variável nome_produto

                            string nome_cliente_s1 = reader5["ID_Cliente"].ToString();
                            int id_cliente_int_s1 = int.Parse(nome_cliente_s1);
                            string nome_cliente = "";
                            using (MySqlConnection connection7 = new MySqlConnection(connectionString))
                            {
                                connection7.Open();

                                // Cria um comando SQL para selecionar o nome do cliente
                                MySqlCommand command7 = new MySqlCommand("SELECT nome FROM cliente where id_Cliente = @id_cliente", connection7);

                                // Adiciona o parâmetro @id_cliente à consulta SQL
                                command7.Parameters.AddWithValue("@id_cliente", id_cliente_int_s1);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader7 = command7.ExecuteReader())
                                {
                                    if (reader7.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader7.Read();

                                        // Obtém o valor da coluna nome
                                        nome_cliente = reader7["nome"].ToString();
                                    }
                                }
                                connection7.Close();

                            }

                            string nome_produto_int = reader5["ID_Produto"].ToString();
                            int id_produto_int_s = int.Parse(nome_produto_int);
                            string nome_produto = "";
                            using (MySqlConnection connection5 = new MySqlConnection(connectionString))
                            {
                                connection5.Open();

                                // Cria um comando SQL para selecionar o nome do produto
                                MySqlCommand command7 = new MySqlCommand("SELECT Nome FROM produto_acabado where id_produto = @id_produto", connection5);

                                // Adiciona o parâmetro @id_produto à consulta SQL
                                command7.Parameters.AddWithValue("@id_produto", id_produto_int_s);

                                // Executa a consulta SQL e obtém o DataReader
                                using (MySqlDataReader reader7 = command7.ExecuteReader())
                                {
                                    if (reader7.HasRows)
                                    {
                                        // Lê a próxima linha
                                        reader7.Read();

                                        // Obtém o valor da coluna nome
                                        nome_produto = reader7["Nome"].ToString();
                                    }
                                }
                                connection5.Close();
                                dtv_listarDemanda.Rows.Add(id_demanda, quantidade_demandada, prazo, nome_cliente, nome_produto, quantidade_produzida);
                            }

                            // Adiciona a linha ao DataGridVie
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão

            string nome_cliente_s = Listar_Clientes.Text;
            string nomeCliente = Listar_Clientes.Text;


            //int id_cliente_int_s = int.Parse(nome_cliente_s);
            int nome_cliente_id = 0;
            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
            {
                connection4.Open();

                // Cria um comando SQL para selecionar o nome do cliente
                MySqlCommand command4 = new MySqlCommand("SELECT id_Cliente FROM cliente where nome = @nome", connection4);

                // Adiciona o parâmetro @id_cliente à consulta SQL
                command4.Parameters.AddWithValue("@nome", nome_cliente_s);

                // Executa a consulta SQL e obtém o DataReader
                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Lê a próxima linha
                        reader4.Read();

                        // Obtém o valor da coluna nome
                        nome_cliente_id = int.Parse(reader4["id_Cliente"].ToString());
                    }
                }
                int nome_Produto_id = 0;
                using (MySqlConnection connectionA = new MySqlConnection(connectionString))
                {
                    connectionA.Open();

                    // Cria um comando SQL para selecionar o nome do cliente
                    MySqlCommand commandA = new MySqlCommand("SELECT id_produto FROM produto_acabado where Nome = @nome", connectionA);

                    // Adiciona o parâmetro @id_cliente à consulta SQL
                    commandA.Parameters.AddWithValue("@nome", comboBox1.Text);

                    // Executa a consulta SQL e obtém o DataReader
                    using (MySqlDataReader readerA = commandA.ExecuteReader())
                    {
                        if (readerA.HasRows)
                        {
                            // Lê a próxima linha
                            readerA.Read();

                            // Obtém o valor da coluna nome
                            nome_Produto_id = int.Parse(readerA["id_produto"].ToString());
                        }
                    }


                    string query5 = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida from demanda where status_demanda = 0 AND ID_Cliente = " + nome_cliente_id + " AND ID_Produto = " + nome_Produto_id + " ;"; // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                                                                                                                                                                                                                                                              // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
                    MySqlCommand command5 = new MySqlCommand(query5, connection4);

                    using (MySqlDataReader reader5 = command5.ExecuteReader())
                    {
                        if (reader5.HasRows)
                        {
                            dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader5.Read())
                            {
                                // Armazena o valor de id_demanda na variável id_demanda
                                int id_demanda = (int)reader5["id_demanda"];

                                // Armazena o valor de quantidade_demandada na variável quantidade_demandada
                                int quantidade_demandada = (int)reader5["quantidade_demandada"];

                                int quantidade_produzida = (int)reader5["qunatidade_produzida"];

                                // Armazena o valor de prazo na variável prazo
                                DateTime prazo = (DateTime)reader5["prazo"];

                                // Armazena o valor de nome_produto na variável nome_produto

                                string nome_cliente_s1 = reader5["ID_Cliente"].ToString();
                                int id_cliente_int_s1 = int.Parse(nome_cliente_s1);
                                string nome_cliente = "";
                                using (MySqlConnection connection7 = new MySqlConnection(connectionString))
                                {
                                    connection7.Open();

                                    // Cria um comando SQL para selecionar o nome do cliente
                                    MySqlCommand command7 = new MySqlCommand("SELECT nome FROM cliente where id_Cliente = @id_cliente", connection7);

                                    // Adiciona o parâmetro @id_cliente à consulta SQL
                                    command7.Parameters.AddWithValue("@id_cliente", id_cliente_int_s1);

                                    // Executa a consulta SQL e obtém o DataReader
                                    using (MySqlDataReader reader7 = command7.ExecuteReader())
                                    {
                                        if (reader7.HasRows)
                                        {
                                            // Lê a próxima linha
                                            reader7.Read();

                                            // Obtém o valor da coluna nome
                                            nome_cliente = reader7["nome"].ToString();
                                        }
                                    }
                                    connection7.Close();

                                }

                                string nome_produto_int = reader5["ID_Produto"].ToString();
                                int id_produto_int_s = int.Parse(nome_produto_int);
                                string nome_produto = "";
                                using (MySqlConnection connection5 = new MySqlConnection(connectionString))
                                {
                                    connection5.Open();

                                    // Cria um comando SQL para selecionar o nome do produto
                                    MySqlCommand command7 = new MySqlCommand("SELECT Nome FROM produto_acabado where id_produto = @id_produto", connection5);
                                    string nome_selecionado = comboBox1.Text;
                                    // Adiciona o parâmetro @id_produto à consulta SQL
                                    command7.Parameters.AddWithValue("@id_produto", nome_selecionado);

                                    // Executa a consulta SQL e obtém o DataReader
                                    using (MySqlDataReader reader7 = command7.ExecuteReader())
                                    {
                                        if (reader7.HasRows)
                                        {
                                            // Lê a próxima linha
                                            reader7.Read();

                                            // Obtém o valor da coluna nome
                                            nome_produto = reader7["Nome"].ToString();
                                        }
                                    }
                                    connection5.Close();
                                    dtv_listarDemanda.Rows.Add(id_demanda, quantidade_demandada, prazo, nome_cliente, comboBox1.Text, quantidade_produzida);
                                }

                                // Adiciona a linha ao DataGridVie
                            }
                        }
                        else
                        {
                            MessageBox.Show("Nenhum registro encontrado.");
                        }
                    }
                }
            }
        }
    }
}