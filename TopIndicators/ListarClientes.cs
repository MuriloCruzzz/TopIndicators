using AngleSharp.Dom;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
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
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_Cliente AS Registro, nome AS Nome, CNPJ FROM cliente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_clientes.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_clientes.Rows.Add(reader["Registro"], reader["Nome"], reader["CNPJ"]);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            int n = txtPesquisa.Text.Length;
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_Cliente AS Registro, nome AS Nome, CNPJ FROM cliente WHERE LEFT(nome, " + n + ") = '" + pesquisa + "';";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_clientes.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_clientes.Rows.Add(reader["Registro"], reader["Nome"], reader["CNPJ"]);
                        }
                    }
                }
                connection.Close();
            }
        }
    }
}
