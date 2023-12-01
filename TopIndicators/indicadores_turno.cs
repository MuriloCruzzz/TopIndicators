using Google.Protobuf.WellKnownTypes;
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
    public partial class indicadores_turno : Form
    {
        private string id_turno;
        public string Id_Turno
        {
            set { id_turno = value; }
        }
        public indicadores_turno()
        {
            InitializeComponent();
        }

        int id_producao = 0;

        private void indicadores_turno_Load(object sender, EventArgs e)
        {
            //string id_produção = id_turno;
            int id_produto = 0;
            int id_turno_prod = 0;
            string Nome_Produto = "";
            int quantidadeTotalProduzida = 0;
            string horario_inicio = "0";
            string horario_final = "0";
            string tempo_total = "0";
            string paradas_linha = "0";
            int refugo_produto_acabado = 0;
            int refugo_materia_prima = 0;
            int refugo_material = 0;
            double PPH = 0;
            double KU = 0;
            double YIELD_materia_prima = 0;

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connectiona = new MySqlConnection(connectionString))
            {

                connectiona.Open();


                string query = "SELECT * FROM producao where id_turno = @id_turno";
                MySqlCommand command = new MySqlCommand(query, connectiona);
                command.Parameters.AddWithValue("@id_turno", id_turno);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        id_turno_prod = (int)reader["id_turno"];
                        quantidadeTotalProduzida = (int)reader["quantidade_Produzida"];
                        horario_inicio = reader["hora_inicio"].ToString();
                        horario_final = reader["hora_final"].ToString();
                        paradas_linha = reader["paradasLinha"].ToString(); 
                        tempo_total = reader["tempo_total_producao"].ToString(); 
                        refugo_produto_acabado = (int)reader["refugo_produto_acabado"];
                        refugo_materia_prima = (int)reader["refugo_materia_prima"];
                        refugo_material = (int)reader["refugo_material"];
                        PPH = (double)reader["PPH"];
                        KU = (double)reader["KU"];
                        YIELD_materia_prima = (double)reader["YIELD_Materia_Prima"];
                        id_produto = (int)reader["ID_Produto"];

                        lbl_quantidade.Text = quantidadeTotalProduzida.ToString();
                        lbl_h_inicio.Text = horario_inicio.ToString();
                        lbl_h_final.Text = horario_final.ToString();
                        lbl_tempo_total_producao.Text = tempo_total.ToString();
                        lbl_paradasLinha.Text = paradas_linha.ToString();
                        lbl_refugo_produto_acabado.Text = refugo_produto_acabado.ToString();
                        lbl_refugo_materia_prima.Text = refugo_materia_prima.ToString();
                        lbl_refugo_material.Text = refugo_material.ToString();
                        lbl_id_Produto.Text = id_produto.ToString();

                        lbl_pph.Text = PPH.ToString();
                        lbl_ku.Text = KU.ToString() + "%";
                        lbl_YIELD.Text = YIELD_materia_prima.ToString() + "%";

                    }
                    connectiona.Close();
                    reader.Close();
                }
                using (MySqlConnection connectionNomes = new MySqlConnection(connectionString))
                {

                    connectionNomes.Open();


                    string queryNomes = "SELECT PPH, KU, YIELD, Cliente FROM produto_acabado WHERE id_produto = @id_produto";
                    MySqlCommand commandNomes = new MySqlCommand(queryNomes, connectionNomes);
                    commandNomes.Parameters.AddWithValue("@id_produto", id_produto);

                    using (MySqlDataReader reader = commandNomes.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            lb_pph.Text = reader["PPH"].ToString();
                            lb_ku.Text = reader["KU"].ToString() + "%";
                            lb_Yeld.Text = reader["YIELD"].ToString() + "%";
                            lb_cliente.Text = reader["Cliente"].ToString();
                        }
                    }
                }

                MySqlConnection connectionb = new MySqlConnection(connectionString);
                connectionb.Open();

                // Execute a consulta
                string queryb = "SELECT Nome FROM produto_acabado WHERE id_produto = @ID_Produto";
                MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
                commandb.Parameters.AddWithValue("@ID_Produto", id_turno_prod);

                using (MySqlDataReader readerb = commandb.ExecuteReader())
                {
                    if (readerb.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (readerb.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            Nome_Produto = readerb["Nome"].ToString();//
                            lbl_nome_produto.Text = Nome_Produto;
                        }
                    }
                    connectionb.Close();
                }
            }
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void lbl_refugo_materia_prima_Click(object sender, EventArgs e)
        {

        }
    }
}

