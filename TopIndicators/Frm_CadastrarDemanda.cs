using DadosDemanda;
using DadosUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TopIndicators
{
    public partial class Frm_CadastrarDemanda : Form
    {
        public Frm_CadastrarDemanda()
        {
            InitializeComponent();
        }

        private void Frm_CadastrarDemanda_Load(object sender, EventArgs e)
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
                string query2 = "SELECT Nome FROM produto_acabado";
                MySqlCommand command2 = new MySqlCommand(query2, connection);

                using (MySqlDataReader reader = command2.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            string nomeCliente = reader["Nome"].ToString();
                            comboBox1.Items.Add(nomeCliente);
                        }
                    }
                }

                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

            DateTime prazo = DateTime.Parse(mtx_Prazo.Text);
            int meta = int.Parse(Txt_quantidade.Text);
            int atual = int.Parse(Txt_Atual.Text);
            string Nome_Produto = comboBox1.Text;
            string Nome_Cliente = Listar_Clientes.Text;
            int id_cliente = 0;
            int id_produto = 0;


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string queryCreate = "SELECT id_Cliente FROM cliente WHERE nome like @Nome_Cliente";
                    MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection);
                    commandCreate.Parameters.AddWithValue("@Nome_Cliente", "%" + Nome_Cliente + "%");

                    object result = commandCreate.ExecuteScalar();

                    if (result != null)
                    {
                        id_cliente = Convert.ToInt32(result);
                        // Agora você pode usar a variável id_cliente conforme necessário
                    }

                    string queryCreate2 = "SELECT id_produto FROM produto_acabado WHERE Nome like @Nome_Produto";
                    MySqlCommand commandCreate2 = new MySqlCommand(queryCreate2, connection);
                    commandCreate2.Parameters.AddWithValue("@Nome_Produto", "%" + Nome_Produto + "%");

                    object result2 = commandCreate2.ExecuteScalar();

                    if (result2 != null)
                    {
                        id_produto = Convert.ToInt32(result2);
                        // Agora você pode usar a variável id_cliente conforme necessário
                    }

                    connection.Close();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                using (MySqlConnection connection1 = new MySqlConnection(connectionString))
                {
                    try
                    {
                        connection1.Open();
                        string queryCreate1 = "INSERT INTO demanda (quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida ) VALUES (@quantidade_Demandada, @prazo, @ID_Cliente, @ID_Produto, @qunatidade_produzida )";
                        MySqlCommand commandCreate = new MySqlCommand(queryCreate1, connection1);
                        commandCreate.Parameters.AddWithValue("@quantidade_Demandada", meta);
                        commandCreate.Parameters.AddWithValue("@prazo", prazo);
                        commandCreate.Parameters.AddWithValue("@ID_Cliente", id_cliente);
                        commandCreate.Parameters.AddWithValue("@ID_Produto", id_produto);
                        commandCreate.Parameters.AddWithValue("@qunatidade_produzida", atual);

                        commandCreate.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    connection1.Close();
                    Console.WriteLine("Demanda inserida com sucesso!");

                    mtx_Prazo.Text = "";
                    Txt_quantidade.Text = "";
                    Txt_Atual.Text = "";
                    comboBox1.Text = "";
                    Listar_Clientes.Text = "";
                    Listar_Clientes.Text = "";
                    textBox2.Text = "";
                }

            }
        }
    }
}
