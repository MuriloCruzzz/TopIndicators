using AngleSharp.Dom;
using Microsoft.ReportingServices.Diagnostics.Internal;
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
    public partial class AdicionarEstoque : Form
    {
        public string nome_produto_atual;
        public string Nome_Produto_Atual
        {
            set { nome_produto_atual = value; }
        }
        public string nome_click_atual;
        public string Nome_click_Atual
        {
            set { nome_click_atual = value; }
        }
        public AdicionarEstoque()
        {
            InitializeComponent();
        }

        private void Lbl_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AdicionarEstoque_Load(object sender, EventArgs e)
        {
            string nome_produto = nome_produto_atual;
            string nome_click = nome_click_atual;

            if (nome_click_atual == "1")
            {
                Lbl_nomeProd.Text = "Matéria Prima:";
                lbl_nome_produto.Text = nome_produto_atual;
            }

            if (nome_click_atual == "2")
            {
                Lbl_nomeProd.Text = "Componente:";
                lbl_nome_produto.Text = nome_produto_atual;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(nome_click_atual == "1")
            {
                int quantidade_adicionada_1 = int.Parse(mk_quantidadeADC.Text);
                int quantidade_adicionada = 0;
                int estoque_atual = 0;

                string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {
                    connection.Open();

                    string query = "SELECT Quantidade FROM produto_materia_prima WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                estoque_atual = int.Parse(reader["Quantidade"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }

                quantidade_adicionada = estoque_atual + quantidade_adicionada_1;

                using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                {
                    connection1.Open();

                    string queryCreate = "UPDATE produto_materia_prima SET Quantidade = " + quantidade_adicionada + " WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                    {
                        //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                        commandCreate.ExecuteNonQuery();
                        MessageBox.Show("Adicionado " + quantidade_adicionada_1 + " Peças em " + nome_produto_atual + "!!!");
                        // Obtenha uma referência ao formulário
                        this.Close();

                    }

                }
            }
            if(nome_click_atual == "2")
            {
                int quantidade_adicionada_1 = int.Parse(mk_quantidadeADC.Text);
                int quantidade_adicionada = 0;
                int estoque_atual = 0;

                string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {
                    connection.Open();

                    string query = "SELECT Quantidade FROM produto_materia_prima WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                estoque_atual = int.Parse(reader["Quantidade"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }

                quantidade_adicionada = estoque_atual + quantidade_adicionada_1;

                using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                {
                    connection1.Open();

                    string queryCreate = "UPDATE produto_materia_prima_componente SET Quantidade = " + quantidade_adicionada + " WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                    {
                        //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                        commandCreate.ExecuteNonQuery();
                        MessageBox.Show("Adicionado " + quantidade_adicionada_1 + " Peças em " + nome_produto_atual + "!!!");
                        // Obtenha uma referência ao formulário
                        this.Close();

                    }

                }
            }
            
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(nome_click_atual == "1")
            {
                int quantidade_adicionada_1 = int.Parse(mk_quantidadeADC.Text);
                int quantidade_adicionada = 0;
                int estoque_atual = 0;

                string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {
                    connection.Open();

                    string query = "SELECT Quantidade FROM produto_materia_prima WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                estoque_atual = int.Parse(reader["Quantidade"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }

                quantidade_adicionada = estoque_atual - quantidade_adicionada_1;

                if (quantidade_adicionada <= 0)
                {
                    MessageBox.Show("Estoque já está ZERADO!!!");
                    return;
                }

                using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                {
                    connection1.Open();

                    string queryCreate = "UPDATE produto_materia_prima SET Quantidade = " + quantidade_adicionada + " WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                    {
                        //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                        commandCreate.ExecuteNonQuery();
                        MessageBox.Show("Removido " + quantidade_adicionada_1 + " Peças em " + nome_produto_atual + "!!!");
                        // Obtenha uma referência ao formulário
                        this.Close();

                    }

                }
            } 
            if(nome_click_atual == "2")
            {
                int quantidade_adicionada_1 = int.Parse(mk_quantidadeADC.Text);
                int quantidade_adicionada = 0;
                int estoque_atual = 0;

                string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {
                    connection.Open();

                    string query = "SELECT Quantidade FROM produto_materia_prima WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {


                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                estoque_atual = int.Parse(reader["Quantidade"].ToString());
                            }
                        }
                    }
                    connection.Close();
                }

                quantidade_adicionada = estoque_atual - quantidade_adicionada_1;

                if (quantidade_adicionada <= 0)
                {
                    MessageBox.Show("Estoque já está ZERADO!!!");
                    return;
                }

                using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
                {
                    connection1.Open();

                    string queryCreate = "UPDATE produto_materia_prima_componente SET Quantidade = " + quantidade_adicionada + " WHERE Nome = '" + nome_produto_atual + "';";
                    MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                    {
                        //commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                        commandCreate.ExecuteNonQuery();
                        MessageBox.Show("Removido " + quantidade_adicionada_1 + " Peças em " + nome_produto_atual + "!!!");
                        // Obtenha uma referência ao formulário
                        this.Close();

                    }

                }
            }
        }
    }
}
