using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Frm_Vizualizar_Linhas : Form
    {
        public Frm_Vizualizar_Linhas()
        {
            InitializeComponent();
        }
        public int id_producao { get; set; }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Frm_Vizualizar_Linhas_Load(object sender, EventArgs e)
        {
            // Conecte-se ao banco de dados
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            // Execute a consulta
            string query = "SELECT id_produto_acabado, id_producao, id_produto_materia_prima, id_produto_material, quantidade_produzidas,quantidade_demanda_atual FROM producao_linha WHERE id_producao = @id_producao";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id_producao", id_producao);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    // Itere sobre os resultados da consulta
                    while (reader.Read())
                    {
                        // Pegue os valores dos campos da consulta
                        string idProdutoAcabado = reader["id_produto_acabado"].ToString();
                        int idProducao = (int)reader["id_producao"];
                        int idProdutoMateriaPrima = (int)reader["id_produto_materia_prima"];
                        int idProdutoMaterial = (int)reader["id_produto_material"];
                        int quantidadeProduzidas = (int)reader["quantidade_produzidas"];
                        int quantidadeDemandaAtual = (int)reader["quantidade_demanda_atual"];

                        // Armazene os valores nas label.text
                        lbl_nome_produto.Text = idProdutoAcabado;
                        lbl_linha.Text = idProducao.ToString();
                        lbl_materia_prima.Text = idProdutoMateriaPrima.ToString();
                        lbl_material.Text = idProdutoMaterial.ToString();
                        lbl_produto_acabado.Text = idProdutoAcabado.ToString();
                        lbl_quantidade_produzida.Text = quantidadeProduzidas.ToString();
                        lbl_quantidade_demandada.Text = quantidadeDemandaAtual.ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }
                connection.Close();
            }
            string query2 = "SELECT Nome FROM produto_materia_prima WHERE id_produto = @id_produto";
            MySqlCommand command2 = new MySqlCommand(query2, connection);
            command2.Parameters.AddWithValue("@id_produto", int.Parse(lbl_materia_prima.Text));
            connection.Open();

            using (MySqlDataReader reader2 = command2.ExecuteReader())
            {
                if (reader2.HasRows)
                {
                    // Itere sobre os resultados da consulta
                    while (reader2.Read())
                    {
                        // Pegue os valores dos campos da consulta
                        lbl_materia_prima.Text = reader2["Nome"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }
            }
            connection.Close();
            string query3 = "SELECT Nome FROM produto_materia_prima_componente WHERE id_produto = @id_produto";
            MySqlCommand command3 = new MySqlCommand(query3, connection);
            command3.Parameters.AddWithValue("@id_produto", int.Parse(lbl_material.Text));
            connection.Open();

            using (MySqlDataReader reader3 = command2.ExecuteReader())
            {
                if (reader3.HasRows)
                {
                    // Itere sobre os resultados da consulta
                    while (reader3.Read())
                    {
                        // Pegue os valores dos campos da consulta
                        lbl_material.Text = reader3["Nome"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Nenhum registro encontrado.");
                }
            }
            connection.Close();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
