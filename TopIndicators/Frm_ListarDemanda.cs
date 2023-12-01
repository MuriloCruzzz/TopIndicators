using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Frm_ListarDemanda : Form
    {
        private string id_usuario;

        public string Id_Usuario
        {
            set { id_usuario = value; }
        }
        public Frm_ListarDemanda()
        {
            InitializeComponent();
        }

        public void Frm_ListarDemanda_Load(object sender, EventArgs e)
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
                    try
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
                    catch
                    {
                        MessageBox.Show("Crie uma nova Demanda em 'NOVA DEMANDA'");
                        return;
                    }
                
                        
                    

                }
                //connection.Open();

                string query5 = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida from demanda"; // demanda.id_Demanda,demanda.quantidade_Demandada,demanda.prazo, produto_acabado.Nome AS Nome,cliente.nome AS nome FROM demanda INNER JOIN produto_acabado ON demanda.ID_Produto = produto_acabado.id_produto INNER JOIN cliente ON demanda.id_cliente = cliente.ID_Cliente";
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

                            // Adiciona a linha ao DataGridView

                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }

        private void dtv_listarDemanda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string nomePesquisa = Listar_Clientes.Text.Trim();

            if (!string.IsNullOrEmpty(nomePesquisa))
            {
                listarDemandaBindingSource.Filter = $"nome_colaborador LIKE '%{nomePesquisa}%'";
            }
            else
            {
                listarDemandaBindingSource.RemoveFilter();
            }

            dtv_listarDemanda.Refresh();

        }

        private void listarDemandaBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Listar_Clientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string nomeCliente = Listar_Clientes.Text;

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
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
                    Console.WriteLine(ex.Message);
                }
                connection1.Close();
            }
        }
    }
}
