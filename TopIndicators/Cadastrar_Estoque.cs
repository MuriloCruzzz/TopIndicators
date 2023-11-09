using Connection;
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
    public partial class Cadastrar_Estoque : Form
    {
        public Cadastrar_Estoque()
        {
            InitializeComponent();
        }

        private void btn_importarMP_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMateriaPrima();

            MessageBox.Show("MATERIA PRIMA Inseridos Com Sucesso!!!");
        }

        private void btn_Importar_MT_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMaterial();

            MessageBox.Show("COMPONENTES Inseridos Com Sucesso!!!");
        }

        private void btn_Listar_materiaPrima_Click(object sender, EventArgs e)
        {
            btn_Listar_materiaPrima.BackColor = Color.MediumTurquoise;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

                connection.Close();
            }
        }

        private void btn_Listar_Materiais_Click(object sender, EventArgs e)
        {
            btn_Listar_materiaPrima.BackColor = Color.DarkGreen;
            btn_Listar_Materiais.BackColor = Color.MediumTurquoise;

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual FROM produto_materia_prima_componente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

                connection.Close();
            }

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cadastrar_Estoque_Load(object sender, EventArgs e)
        {
            btn_Listar_materiaPrima.BackColor = Color.MediumTurquoise;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

                connection.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaProdutoAcabado();

            MessageBox.Show("produto Inseridos Com Sucesso!!!");
        }
    }
}
