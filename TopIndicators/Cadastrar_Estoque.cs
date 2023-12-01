﻿using Connection;
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
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMateriaPrima();

            MessageBox.Show("MATERIA PRIMA Inseridos Com Sucesso!!!");
            AtualizarDadosMateriaPrima();
        }

        private void btn_Importar_MT_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMaterial();

            MessageBox.Show("COMPONENTES Inseridos Com Sucesso!!!");
            AtualizarDadosComponentes();
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
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaProdutoAcabado();

            MessageBox.Show("produto Inseridos Com Sucesso!!!");
            AtualizarDadosProdutoAcabado();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaClientes();

            MessageBox.Show("Clientes Inseridos Com Sucesso!!!");
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
            if(id_null == 0)
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
            if(id_click == 2)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, estoque_minimo, estoque_maximo, status FROM produto_materia_prima_componente WHERE Nome LIKE '%" + pesquisa+"%';";
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
            if(id_click == 3)
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT id_produto, Nome, Data_Validade, Quantidade AS Estoque_Atual, Material_Consumo, Materia_Prima_Consumo, Cliente FROM produto_acabado WHERE Nome LIKE '%" + pesquisa+"%';";
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
    }
}
