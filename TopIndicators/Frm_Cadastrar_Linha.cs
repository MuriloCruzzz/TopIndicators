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
                dtv_listarDemanda.Refresh();
            }
        }
    }
}
