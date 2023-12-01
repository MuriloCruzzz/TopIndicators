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
        int id_produto = 0;
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


                string query3 = "SELECT MAX(id_Demanda) AS id_Demanda FROM demanda";
                MySqlCommand command3 = new MySqlCommand(query3, connection);

                using (MySqlDataReader reader3 = command3.ExecuteReader())
                {
                    if (reader3.HasRows)
                    {
                        try
                        {
                            reader3.Read();
                            int idDemanda = int.Parse(reader3["id_Demanda"].ToString());

                            int id_demanda_atual = idDemanda + 1;

                            textBox1.Text = id_demanda_atual.ToString();
                        }
                        catch 
                        {
                            textBox1.Text = "1";

                        }
                    }
                }

                connection.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (Txt_quantidade.Text == "")
            {
                Txt_quantidade.Text = "";
                MessageBox.Show("Quantidade não informada!!!");
                return;
            }
            if (Listar_Clientes.Text == "")
            {
                Listar_Clientes.Text = "";
                MessageBox.Show("Cliente não informado!!!");
                return;
            }
            if (comboBox1.Text == "")
            {
                comboBox1.Text = "";
                MessageBox.Show("Produto não informado!!!");
                return;
            }
            try 
            {
                DateTime dataAtual = DateTime.Now;

                // Obtém a data do MaskedTextBox
                string data = mtx_Prazo.Text;

                // Verifica se a data é superior a data atual
                DateTime dataConvertida = DateTime.Parse(data);
                if (dataConvertida <= dataAtual)
                {
                    // A data é inválida
                    mtx_Prazo.Text = "";
                    MessageBox.Show("A data deve ser superior a data atual.");
                    return;
                }

                // Verifica se a data é válida
                if (!DateTime.TryParse(data, out dataConvertida))
                {
                    // A data é inválida
                    mtx_Prazo.Text = "";
                    MessageBox.Show("A data deve estar no formato dd/MM/yyyy HH:mm.");
                    return;
                }
            }
            catch 
            {
                mtx_Prazo.Text = "";
                MessageBox.Show("A data deve estar no formato dd/MM/yyyy HH:mm.");
                return;

            }


            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

            DateTime prazo = DateTime.Parse(mtx_Prazo.Text);
            int meta = int.Parse(Txt_quantidade.Text);
            int atual = int.Parse(Txt_Atual.Text);
            string Nome_Produto = comboBox1.Text;
            string Nome_Cliente = Listar_Clientes.Text;
            int id_cliente = 0;
            
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
                        string queryCreate1 = "INSERT INTO demanda (quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida, status_demanda ) VALUES (@quantidade_Demandada, @prazo, @ID_Cliente, @ID_Produto, @qunatidade_produzida, @status_demanda )";
                        MySqlCommand commandCreate = new MySqlCommand(queryCreate1, connection1);
                        commandCreate.Parameters.AddWithValue("@quantidade_Demandada", meta);
                        commandCreate.Parameters.AddWithValue("@prazo", prazo);
                        commandCreate.Parameters.AddWithValue("@ID_Cliente", id_cliente);
                        commandCreate.Parameters.AddWithValue("@ID_Produto", id_produto);
                        commandCreate.Parameters.AddWithValue("@qunatidade_produzida", atual);
                        commandCreate.Parameters.AddWithValue("@status_demanda", 0);

                        commandCreate.ExecuteNonQuery();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    connection1.Close();
                    MessageBox.Show("Demanda inserida com sucesso!");

                    mtx_Prazo.Text = "";
                    Txt_quantidade.Text = "";
                    Txt_Atual.Text = "";
                    comboBox1.Text = "";
                    Listar_Clientes.Text = "";
                    Listar_Clientes.Text = "";
                    textBox2.Text = "";
                    textBox1.Text = "";
                }

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Txt_quantidade.Text == "")
            {
                comboBox1.SelectedIndex = 0;
                MessageBox.Show("Insira a Quantidade Primeiro!!!");
                return;
            }
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionString))
            {
                try
                {
                    connection1.Open();

                    string queryCreate2 = "SELECT id_produto FROM produto_acabado WHERE Nome like @Nome_Produto";
                    MySqlCommand commandCreate2 = new MySqlCommand(queryCreate2, connection1);
                    string Nome_Produto = comboBox1.Text;
                    commandCreate2.Parameters.AddWithValue("@Nome_Produto", "%" + Nome_Produto + "%");

                    object result2 = commandCreate2.ExecuteScalar();

                    if (result2 != null)
                    {
                        id_produto = Convert.ToInt32(result2);
                        // Agora você pode usar a variável id_cliente conforme necessário
                    }
                    connection1.Close();

                    connection1.Open();
                    string queryCreate3 = "SELECT Quantidade FROM produto_acabado WHERE id_produto = @id_produto;";
                    MySqlCommand commandCreate3 = new MySqlCommand(queryCreate3, connection1);
                    commandCreate3.Parameters.AddWithValue("@id_produto", id_produto);

                    object result3 = commandCreate3.ExecuteScalar();

                    if (result3 != null)
                    {
                        int Estoque_Produto = Convert.ToInt32(result3);
                        Txt_Atual.Text = Estoque_Produto.ToString();
                        int restante = int.Parse(Txt_quantidade.Text);
                        restante = (restante - Estoque_Produto);
                        textBox2.Text = restante.ToString();

                        // Agora você pode usar a variável id_cliente conforme necessário
                    }
                    else
                    {
                        Txt_Atual.Text = "0";
                        Txt_quantidade.Text = "0";
                    }

                    //commandCreate3.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                connection1.Close();

            }
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

        private void mtx_Prazo_MaskChanged(object sender, EventArgs e)
        {
            DateTime dataAtual = DateTime.Now;

            // Obtém a data do MaskedTextBox
            string data = mtx_Prazo.Text;

            // Verifica se a data é superior a data atual
            DateTime dataConvertida = DateTime.Parse(data);
            if (dataConvertida <= dataAtual)
            {
                // A data é inválida
                //e.Cancel = true;
                MessageBox.Show("A data deve ser superior a data atual.");
            }

            // Verifica se a data é válida
            if (!DateTime.TryParse(data, out dataConvertida))
            {
                // A data é inválida
                //e.Cancel = true;
                MessageBox.Show("A data deve estar no formato dd/MM/yyyy HH:mm.");
            }
        }

    }
}
