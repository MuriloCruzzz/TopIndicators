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
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using AngleSharp.Dom;
using System.Drawing.Text;
using OfficeOpenXml;
using System.IO;

namespace TopIndicators
{
    public partial class Cadastrar_Estoque : Form
    {
        public Cadastrar_Estoque()
        {
            InitializeComponent();
        }
        int id_click;
        int id_componente;
        private void btn_importarMP_Click(object sender, EventArgs e)
        {
            int id_verificação = 0;
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                connection.Open();

                string query = "SELECT MAX(id_produto) AS id_ultimo_registro FROM produto_materia_prima;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_ultimo_registro"].ToString());
                            }
                        }
                    }
                    catch
                    {
                        id_verificação = 0;
                    }
                }

            }
            if (id_verificação == 0)
            {
                Connection.ProcessoDados InserirtabelaMateriaPrima = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirtabelaMateriaPrima.InserirTabelaMateriaPrima();

                MessageBox.Show("MATERIA PRIMA Inseridos Com Sucesso!!!");
                AtualizarDadosMateriaPrima();

            }
            if (id_verificação != 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionStringA))
                {
                    connection.Open();

                    string query = "DELETE FROM produto_materia_prima;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.ExecuteNonQuery();
                    connection.Close();
                }


                Connection.ProcessoDados InserirtabelaMateriaPrima = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();
                InserirtabelaMateriaPrima.InserirTabelaMateriaPrima();


                MessageBox.Show("MATERIA PRIMA Atualizada Com Sucesso!!!");
                AtualizarDadosMateriaPrima();

            }
        }

        private void btn_Importar_MT_Click(object sender, EventArgs e)
        {
            int id_verificação = 0;
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                connection.Open();

                string query = "SELECT MAX(id_produto) AS id_ultimo_registro FROM produto_materia_prima;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_ultimo_registro"].ToString());
                            }
                        }
                    }
                    catch
                    {
                        id_verificação = 0;

                    }
                }

            }
            if(id_verificação == 0)
            {
                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaMaterial();

                MessageBox.Show("COMPONENTES Inseridos Com Sucesso!!!");
                AtualizarDadosComponentes();

            }
            if (id_verificação != 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionStringA))
                {
                    connection.Open();

                    string query = "DELETE FROM produto_materia_prima_componente;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaMaterial();

                MessageBox.Show("COMPONENTES Atualizados Com Sucesso!!!");
                AtualizarDadosComponentes();
            }
        }

        private void btn_Listar_materiaPrima_Click(object sender, EventArgs e)
        {
            id_click = 1;


            btn_Listar_materiaPrima.BackColor = Color.MediumTurquoise;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;
            btn_produtoAcabado.BackColor = Color.DarkGreen;

            dataGridView1.Columns[4].HeaderText = "Minimo";
            dataGridView1.Columns[5].HeaderText = "Maximo";
            dataGridView1.Columns[6].HeaderText = "Status";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);


                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum PRODUTO ACABADO Cadastrada!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {

                            int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                            string estoqueMinimoa = reader["estoque_minimo"].ToString();
                            string estoqueMaximoa = reader["estoque_maximo"].ToString();


                            int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                            int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                            Color cor = Color.LightGreen;
                            string status;
                            if (estoqueAtual < estoqueMinimo)
                            {
                                cor = Color.Tomato;
                            }
                            if (estoqueAtual > estoqueMaximo)
                            {
                                cor = Color.Gold;
                            }

                            if (estoqueAtual < estoqueMinimo)
                            {
                                status = "ABAIXO";
                            }
                            else if (estoqueAtual > estoqueMaximo)
                            {
                                status = "ACIMA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                        }
                    }
                }

                connection.Close();
            }
        }
        private void AtualizarDadosMateriaPrima()
        {
            id_click = 1;


            btn_Listar_materiaPrima.BackColor = Color.MediumTurquoise;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;
            btn_produtoAcabado.BackColor = Color.DarkGreen;

            dataGridView1.Columns[4].HeaderText = "Minimo";
            dataGridView1.Columns[5].HeaderText = "Maximo";
            dataGridView1.Columns[6].HeaderText = "Status";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum PRODUTO ACABADO Cadastrada!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {

                            int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                            string estoqueMinimoa = reader["estoque_minimo"].ToString();
                            string estoqueMaximoa = reader["estoque_maximo"].ToString();


                            int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                            int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                            Color cor = Color.LightGreen;
                            string status;
                            if (estoqueAtual < estoqueMinimo)
                            {
                                cor = Color.Tomato;
                            }
                            if (estoqueAtual > estoqueMaximo)
                            {
                                cor = Color.Gold;
                            }

                            if (estoqueAtual < estoqueMinimo)
                            {
                                status = "ABAIXO";
                            }
                            else if (estoqueAtual > estoqueMaximo)
                            {
                                status = "ACIMA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                        }
                    }
                }

                connection.Close();
            }
        }
        private void AtualizarDadosComponentes()
        {
            id_click = 2;
            btn_Listar_materiaPrima.BackColor = Color.DarkGreen;
            btn_Listar_Materiais.BackColor = Color.MediumTurquoise;
            btn_produtoAcabado.BackColor = Color.DarkGreen;

            dataGridView1.Columns[4].HeaderText = "Minimo";
            dataGridView1.Columns[5].HeaderText = "Maximo";
            dataGridView1.Columns[6].HeaderText = "Status";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_materia_prima_componente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum COMPONENTE Cadastrado!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima_componente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                            string estoqueMinimoa = reader["estoque_minimo"].ToString();
                            string estoqueMaximoa = reader["estoque_maximo"].ToString();


                            int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                            int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                            Color cor = Color.LightGreen;
                            string status;
                            if (estoqueAtual < estoqueMinimo)
                            {
                                cor = Color.Tomato;
                            }
                            if (estoqueAtual > estoqueMaximo)
                            {
                                cor = Color.Gold;
                            }

                            if (estoqueAtual < estoqueMinimo)
                            {
                                status = "ABAIXO";
                            }
                            else if (estoqueAtual > estoqueMaximo)
                            {
                                status = "ACIMA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                        }
                    }
                }

                connection.Close();
            }
        }
        private void AtualizarDadosProdutoAcabado()
        {
            id_click = 3;
            btn_Listar_materiaPrima.BackColor = Color.DarkGreen;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;
            btn_produtoAcabado.BackColor = Color.MediumTurquoise;

            dataGridView1.Columns[4].HeaderText = "Material Consumo";
            dataGridView1.Columns[5].HeaderText = "Materia Prima Consumo";
            dataGridView1.Columns[6].HeaderText = "Cliente";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_acabado";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum PRODUTO ACABADO Cadastrado!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }
            if (id_null == 0)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, Material_Consumo, Materia_Prima_Consumo, Cliente FROM produto_acabado";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["Material_Consumo"], reader["Materia_Prima_Consumo"], reader["Cliente"]);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void btn_Listar_Materiais_Click(object sender, EventArgs e)
        {
            id_click = 2;
            btn_Listar_materiaPrima.BackColor = Color.DarkGreen;
            btn_Listar_Materiais.BackColor = Color.MediumTurquoise;
            btn_produtoAcabado.BackColor = Color.DarkGreen;

            dataGridView1.Columns[4].HeaderText = "Minimo";
            dataGridView1.Columns[5].HeaderText = "Maximo";
            dataGridView1.Columns[6].HeaderText = "Status";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_materia_prima_componente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum COMPONENTE Cadastrado!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima_componente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                            string estoqueMinimoa = reader["estoque_minimo"].ToString();
                            string estoqueMaximoa = reader["estoque_maximo"].ToString();


                            int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                            int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                            Color cor = Color.LightGreen;
                            string status;
                            if (estoqueAtual < estoqueMinimo)
                            {
                                cor = Color.Tomato;
                            }
                            if (estoqueAtual > estoqueMaximo)
                            {
                                cor = Color.Gold;
                            }

                            if (estoqueAtual < estoqueMinimo)
                            {
                                status = "ABAIXO";
                            }
                            else if (estoqueAtual > estoqueMaximo)
                            {
                                status = "ACIMA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                        }
                    }
                }

                connection.Close();
            }

        }
        public static string RemoverAspas(string numero)
        {
            return numero.Replace("\"", "");
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (id_click == 1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nome_produto_atual = row.Cells["nome"].Value.ToString();
                AdicionarEstoque form = new AdicionarEstoque();
                form.Nome_Produto_Atual = nome_produto_atual;
                form.Nome_click_Atual = id_click.ToString();
                form.ShowDialog();
                AtualizarDadosMateriaPrima();


            }
            if (id_click == 2)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string nome_produto_atual = row.Cells["nome"].Value.ToString();
                AdicionarEstoque form1 = new AdicionarEstoque();
                form1.Nome_Produto_Atual = nome_produto_atual;
                form1.Nome_click_Atual = id_click.ToString();
                form1.ShowDialog();
                AtualizarDadosComponentes();
            }
            if (id_click == 3)
            {
                return;
            }

        }

        private void Cadastrar_Estoque_Load(object sender, EventArgs e)
        {
            id_click = 1;
            btn_Listar_materiaPrima.BackColor = Color.MediumTurquoise;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;
            btn_produtoAcabado.BackColor = Color.DarkGreen;

            dataGridView1.Columns[4].HeaderText = "Minimo";
            dataGridView1.Columns[5].HeaderText = "Maximo";
            dataGridView1.Columns[6].HeaderText = "Status";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhuma MATERIA PRIMA Cadastrada!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }


            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                            string estoqueMinimoa = reader["estoque_minimo"].ToString();
                            string estoqueMaximoa = reader["estoque_maximo"].ToString();


                            int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                            int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                            Color cor = Color.LightGreen;
                            string status;
                            if (estoqueAtual < estoqueMinimo)
                            {
                                cor = Color.Tomato;
                            }
                            if (estoqueAtual > estoqueMaximo)
                            {
                                cor = Color.Gold;
                            }

                            if (estoqueAtual < estoqueMinimo)
                            {
                                status = "ABAIXO";
                            }
                            else if (estoqueAtual > estoqueMaximo)
                            {
                                status = "ACIMA";
                            }
                            else
                            {
                                status = "OK";
                            }

                            dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                        }
                    }
                }

                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id_verificação = 0;
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                connection.Open();

                string query = "SELECT MAX(id_produto) AS id_ultimo_registro FROM produto_acabado;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_ultimo_registro"].ToString());
                            }
                        }
                    }
                    catch
                    {
                        id_verificação = 0;

                    }
                }
            }
            if (id_verificação == 0)
            {
                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaProdutoAcabado();

                MessageBox.Show("Ficha Técnica Inserida Com Sucesso!!!");
                AtualizarDadosProdutoAcabado();
            }
            if (id_verificação != 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionStringA))
                {
                    connection.Open();

                    string query = "DELETE FROM produto_acabado;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaProdutoAcabado();

                MessageBox.Show("Ficha Técnica Atualizada Com Sucesso!!!");
                AtualizarDadosProdutoAcabado();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id_verificação = 0;
            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                connection.Open();

                string query = "SELECT MAX(id_Cliente) AS id_ultimo_registro FROM cliente;";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_ultimo_registro"].ToString());
                            }
                        }
                    }
                    catch
                    {
                        id_verificação = 0;

                    }
                }
            }
            if (id_verificação == 0)
            {
                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaClientes();

                MessageBox.Show("Clientes Inseridos Com Sucesso!!!");
            }
            if (id_verificação != 0)
            {
                using (MySqlConnection connection = new MySqlConnection(connectionStringA))
                {
                    connection.Open();

                    string query = "DELETE FROM cliente;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    command.ExecuteNonQuery();
                    connection.Close();
                }

                Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                InserirCliente.InserirTabelaClientes();

                MessageBox.Show("Clientes Atualizados Com Sucesso!!!");
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            id_click = 3;
            btn_Listar_materiaPrima.BackColor = Color.DarkGreen;
            btn_Listar_Materiais.BackColor = Color.DarkGreen;
            btn_produtoAcabado.BackColor = Color.MediumTurquoise;

            dataGridView1.Columns[4].HeaderText = "Material Consumo";
            dataGridView1.Columns[5].HeaderText = "Materia Prima Consumo";
            dataGridView1.Columns[6].HeaderText = "Cliente";

            int id_null = 0;

            string connectionStringA = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionStringA))
            {
                int id_verificação = 0;
                connection.Open();

                string query = "SELECT id_produto FROM produto_acabado";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    try
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                id_verificação = int.Parse(reader["id_produto"].ToString());
                            }
                        }
                        else
                        {
                            id_null = 1;
                            dataGridView1.Rows.Clear();
                            MessageBox.Show("Nenhum PRODUTO ACABADO Cadastrado!!!");
                            connection.Close();
                        }
                    }
                    catch
                    {
                        return;
                    }
                }

            }
            if (id_null == 0)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, Material_Consumo, Materia_Prima_Consumo, Cliente FROM produto_acabado";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["Material_Consumo"], reader["Materia_Prima_Consumo"], reader["Cliente"]);
                            }
                        }
                    }
                    connection.Close();
                }
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            if (id_click == 1)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima WHERE Nome LIKE '%" + pesquisa + "%';";
                    //"SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE LEFT(nome, " + n + ") = '" + Nome + "'AND Status_Usuario = 1;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                                string estoqueMinimoa = reader["estoque_minimo"].ToString();
                                string estoqueMaximoa = reader["estoque_maximo"].ToString();


                                int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                                int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                                Color cor = Color.LightGreen;
                                string status;
                                if (estoqueAtual < estoqueMinimo)
                                {
                                    cor = Color.Tomato;
                                }
                                if (estoqueAtual > estoqueMaximo)
                                {
                                    cor = Color.Gold;
                                }

                                if (estoqueAtual < estoqueMinimo)
                                {
                                    status = "ABAIXO";
                                }
                                else if (estoqueAtual > estoqueMaximo)
                                {
                                    status = "ACIMA";
                                }
                                else
                                {
                                    status = "OK";
                                }

                                dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                            }
                        }
                    }

                    connection.Close();
                }
            }
            if (id_click == 2)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima_componente WHERE Nome LIKE '%" + pesquisa + "%';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                int estoqueAtual = int.Parse(reader["Estoque_Atual"].ToString());
                                string estoqueMinimoa = reader["estoque_minimo"].ToString();
                                string estoqueMaximoa = reader["estoque_maximo"].ToString();


                                int estoqueMaximo = int.Parse(RemoverAspas(estoqueMaximoa));
                                int estoqueMinimo = int.Parse(RemoverAspas(estoqueMinimoa));

                                Color cor = Color.LightGreen;
                                string status;
                                if (estoqueAtual < estoqueMinimo)
                                {
                                    cor = Color.Tomato;
                                }
                                if (estoqueAtual > estoqueMaximo)
                                {
                                    cor = Color.Gold;
                                }

                                if (estoqueAtual < estoqueMinimo)
                                {
                                    status = "ABAIXO";
                                }
                                else if (estoqueAtual > estoqueMaximo)
                                {
                                    status = "ACIMA";
                                }
                                else
                                {
                                    status = "OK";
                                }

                                dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["estoque_minimo"], reader["estoque_maximo"], status);
                                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[6].Style.BackColor = cor;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            if (id_click == 3)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, Material_Consumo, Materia_Prima_Consumo, Cliente FROM produto_acabado WHERE Nome LIKE '%" + pesquisa + "%';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dataGridView1.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                dataGridView1.Rows.Add(reader["id_produto"], reader["Nome"], reader["Data_Validade"], reader["Estoque_Atual"], reader["Material_Consumo"], reader["Materia_Prima_Consumo"], reader["Cliente"]);
                            }
                        }
                    }
                    connection.Close();
                }

            }


        }

        private void label1_Click(object sender, EventArgs e)
        {
            ListarClientes form = new ListarClientes();
            form.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (id_click == 1)
            {
                string dadosCotacao = $"Registro - Nome - Validade - Estoque Atual - Minimo - Maximo - Status";

                dtv_clientes_ls.Items.Add(dadosCotacao);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
                saveFileDialog.Title = "Salvar Materias Primas como...";
                saveFileDialog.FileName = "Materia Prima.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Cria uma planilha
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Materia Prima");
                            worksheet.Cells["A1"].Value = "Registro";
                            worksheet.Cells["B1"].Value = "Materia Prima";
                            worksheet.Cells["C1"].Value = "Válidade";
                            worksheet.Cells["D1"].Value = "Estoque Atual";
                            worksheet.Cells["E1"].Value = "Minimo";
                            worksheet.Cells["F1"].Value = "Maximo";
                            worksheet.Cells["G1"].Value = "Status";
                            // Adiciona os cabeçalhos
                            worksheet.Cells["A2"].Value = "Registro";
                            worksheet.Cells["B2"].Value = "Materia Prima";
                            worksheet.Cells["C2"].Value = "Válidade";
                            worksheet.Cells["D2"].Value = "Estoque Atual";
                            worksheet.Cells["E2"].Value = "Minimo";
                            worksheet.Cells["F2"].Value = "Máximo";
                            worksheet.Cells["G2"].Value = "Status";

                            int row = 2; // Começa a partir da próxima linha após os cabeçalhos

                            // Itera sobre as linhas do DataGridView
                            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                            {
                                // Certifique-se de não pegar a linha de cabeçalho
                                if (!dataGridViewRow.IsNewRow)
                                {
                                    // Supondo que a primeira célula contém o ID, a segunda o nome e a terceira o CNPJ
                                    string registro = dataGridViewRow.Cells["id_produto"].Value.ToString();
                                    string materiaprima = dataGridViewRow.Cells["nome"].Value.ToString();
                                    string validade = dataGridViewRow.Cells["Validade"].Value.ToString();
                                    string estoque = dataGridViewRow.Cells["Estoque_Atual"].Value.ToString();
                                    string minimo = dataGridViewRow.Cells["Minimo"].Value.ToString();
                                    string maximo = dataGridViewRow.Cells["Maximo"].Value.ToString();
                                    string status = dataGridViewRow.Cells["Status"].Value.ToString();

                                    // Adiciona os dados ao Excel
                                    worksheet.Cells[row, 1].Value = registro;
                                    worksheet.Cells[row, 2].Value = materiaprima;
                                    worksheet.Cells[row, 3].Value = validade;
                                    worksheet.Cells[row, 4].Value = estoque;
                                    worksheet.Cells[row, 5].Value = minimo;
                                    worksheet.Cells[row, 6].Value = maximo;
                                    worksheet.Cells[row, 7].Value = status;

                                    row++;
                                }
                            }

                            // Ajuste automático do tamanho das colunas
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Salva o arquivo
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);

                            MessageBox.Show("Matéria Prima exportada com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar Matéria Prima: {ex.Message}");
                    }
                }
            }
            if (id_click == 2)
            {
                string dadosCotacao = $"Registro - Nome - Validade - Estoque Atual - Minimo - Maximo - Status";

                dtv_clientes_ls.Items.Add(dadosCotacao);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
                saveFileDialog.Title = "Salvar Componentes como...";
                saveFileDialog.FileName = "Componentes_Materiais.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Cria uma planilha
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Componentes");
                            worksheet.Cells["A1"].Value = "Registro";
                            worksheet.Cells["B1"].Value = "Materia Prima";
                            worksheet.Cells["C1"].Value = "Válidade";
                            worksheet.Cells["D1"].Value = "Estoque Atual";
                            worksheet.Cells["E1"].Value = "Minimo";
                            worksheet.Cells["F1"].Value = "Maximo";
                            worksheet.Cells["G1"].Value = "Status";
                            // Adiciona os cabeçalhos
                            worksheet.Cells["A2"].Value = "Registro";
                            worksheet.Cells["B2"].Value = "Materia Prima";
                            worksheet.Cells["C2"].Value = "Válidade";
                            worksheet.Cells["D2"].Value = "Estoque Atual";
                            worksheet.Cells["E2"].Value = "Minimo";
                            worksheet.Cells["F2"].Value = "Máximo";
                            worksheet.Cells["G2"].Value = "Status";

                            int row = 2; // Começa a partir da próxima linha após os cabeçalhos

                            // Itera sobre as linhas do DataGridView
                            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                            {
                                // Certifique-se de não pegar a linha de cabeçalho
                                if (!dataGridViewRow.IsNewRow)
                                {
                                    // Supondo que a primeira célula contém o ID, a segunda o nome e a terceira o CNPJ
                                    string registro = dataGridViewRow.Cells["id_produto"].Value.ToString();
                                    string materiaprima = dataGridViewRow.Cells["nome"].Value.ToString();
                                    string validade = dataGridViewRow.Cells["Validade"].Value.ToString();
                                    string estoque = dataGridViewRow.Cells["Estoque_Atual"].Value.ToString();
                                    string minimo = dataGridViewRow.Cells["Minimo"].Value.ToString();
                                    string maximo = dataGridViewRow.Cells["Maximo"].Value.ToString();
                                    string status = dataGridViewRow.Cells["Status"].Value.ToString();

                                    // Adiciona os dados ao Excel
                                    worksheet.Cells[row, 1].Value = registro;
                                    worksheet.Cells[row, 2].Value = materiaprima;
                                    worksheet.Cells[row, 3].Value = validade;
                                    worksheet.Cells[row, 4].Value = estoque;
                                    worksheet.Cells[row, 5].Value = minimo;
                                    worksheet.Cells[row, 6].Value = maximo;
                                    worksheet.Cells[row, 7].Value = status;

                                    row++;
                                }
                            }

                            // Ajuste automático do tamanho das colunas
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Salva o arquivo
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);

                            MessageBox.Show("Componentes exportados com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar Componentes: {ex.Message}");
                    }
                }
            }
            if (id_click == 3)
            {
                string dadosCotacao = $"Registro - Nome - Validade - Estoque Atual - Material Consumo - Materia Prima Consumo - Cliente";

                dtv_clientes_ls.Items.Add(dadosCotacao);
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
                saveFileDialog.Title = "Salvar Ficha Técnica Produtos como...";
                saveFileDialog.FileName = "Ficha Técnica.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage())
                        {
                            // Cria uma planilha
                            ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Componentes");
                            worksheet.Cells["A1"].Value = "Registro";
                            worksheet.Cells["B1"].Value = "Nome";
                            worksheet.Cells["C1"].Value = "Válidade";
                            worksheet.Cells["D1"].Value = "Estoque Atual";
                            worksheet.Cells["E1"].Value = "Material Consumo";
                            worksheet.Cells["F1"].Value = "Matéria Prima Consumo";
                            worksheet.Cells["G1"].Value = "Cliente";
                            // Adiciona os cabeçalhos
                            worksheet.Cells["A2"].Value = "Registro";
                            worksheet.Cells["B2"].Value = "Nome";
                            worksheet.Cells["C2"].Value = "Válidade";
                            worksheet.Cells["D2"].Value = "Estoque Atual";
                            worksheet.Cells["E2"].Value = "Material Consumo";
                            worksheet.Cells["F2"].Value = "Matéria Prima Consumo";
                            worksheet.Cells["G2"].Value = "Cliente";

                            int row = 2; // Começa a partir da próxima linha após os cabeçalhos

                            // Itera sobre as linhas do DataGridView
                            foreach (DataGridViewRow dataGridViewRow in dataGridView1.Rows)
                            {
                                // Certifique-se de não pegar a linha de cabeçalho
                                if (!dataGridViewRow.IsNewRow)
                                {
                                    // Supondo que a primeira célula contém o ID, a segunda o nome e a terceira o CNPJ
                                    string registro = dataGridViewRow.Cells["id_produto"].Value.ToString();
                                    string materiaprima = dataGridViewRow.Cells["nome"].Value.ToString();
                                    string validade = dataGridViewRow.Cells["Validade"].Value.ToString();
                                    string estoque = dataGridViewRow.Cells["Estoque_Atual"].Value.ToString();
                                    string minimo = dataGridViewRow.Cells["Minimo"].Value.ToString();
                                    string maximo = dataGridViewRow.Cells["Maximo"].Value.ToString();
                                    string status = dataGridViewRow.Cells["Status"].Value.ToString();

                                    // Adiciona os dados ao Excel
                                    worksheet.Cells[row, 1].Value = registro;
                                    worksheet.Cells[row, 2].Value = materiaprima;
                                    worksheet.Cells[row, 3].Value = validade;
                                    worksheet.Cells[row, 4].Value = estoque;
                                    worksheet.Cells[row, 5].Value = minimo;
                                    worksheet.Cells[row, 6].Value = maximo;
                                    worksheet.Cells[row, 7].Value = status;

                                    row++;
                                }
                            }

                            // Ajuste automático do tamanho das colunas
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Salva o arquivo
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);

                            MessageBox.Show("Ficha Técnica Produtos exportada com sucesso!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao exportar Ficha Técnica Produtos: {ex.Message}");
                    }
                }
            }
        }
    }
}
