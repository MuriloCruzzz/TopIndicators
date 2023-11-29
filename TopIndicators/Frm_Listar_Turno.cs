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
using static LinqToDB.Common.Configuration;
using static LinqToDB.Sql;

namespace TopIndicators
{
    public partial class Frm_Listar_Turno : Form
    {
        public Frm_Listar_Turno()
        {
            InitializeComponent();
            //LoadDataAndCreateButtons();
        }
        int contador_click1 = 0;
        int contador_click2 = 0;
        int contador_click3 = 0;

        private void AbrirFormularioProducaoAndamento(int id_turno)
        {
            // Código para abrir o formulário Producao_Andamento e passar os parâmetros
            // Você precisa implementar a lógica para abrir o formulário e passar os parâmetros
            // Pode ser semelhante ao que mencionamos em respostas anteriores.
            string id_turno_string = id_turno.ToString();
            indicadores_turno frm = new indicadores_turno();
            frm.Id_Turno = id_turno_string;
            //frm.id_turno = id_turno.ToString; 
            frm.Show();
        }
        private void listarTurno1()
        {
            if(contador_click1 == 0)
            {
                contador_click1 = 1;
                contador_click2 = 0;
                contador_click3 = 0;
                flowLayoutPanel2.Controls.Clear();

                int id_produto = 0;
                string Nome_Produto = "";
                int id_turno = 0;
                int quantidadeTotalProduzida = 0;
                string horario_inicio = "0";
                string horario_final = "0";
                string tempo_total = "0";
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


                    string query = "SELECT * FROM producao where Turno = '1º'";
                    MySqlCommand command = new MySqlCommand(query, connectiona);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_turno = (int)reader["id_turno"];
                            quantidadeTotalProduzida = (int)reader["quantidade_Produzida"];
                            horario_inicio = reader["hora_inicio"].ToString();
                            horario_final = reader["hora_final"].ToString();
                            tempo_total = reader["paradasLinha"].ToString();
                            refugo_produto_acabado = (int)reader["refugo_produto_acabado"];
                            refugo_materia_prima = (int)reader["refugo_materia_prima"];
                            refugo_material = (int)reader["refugo_material"];
                            PPH = (double)reader["PPH"];
                            KU = (double)reader["KU"];
                            YIELD_materia_prima = (double)reader["YIELD_Materia_Prima"];
                            id_produto = (int)reader["ID_Produto"];

                            MySqlConnection connectionb = new MySqlConnection(connectionString);
                            connectionb.Open();

                            // Execute a consulta
                            string queryb = "SELECT Nome FROM produto_acabado WHERE id_produto = @ID_Produto";
                            MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
                            commandb.Parameters.AddWithValue("@ID_Produto", id_produto);

                            using (MySqlDataReader readerb = commandb.ExecuteReader())
                            {
                                if (readerb.HasRows)
                                {
                                    // Itere sobre os resultados da consulta
                                    while (readerb.Read())
                                    {
                                        // Pegue os valores dos campos da consulta
                                        Nome_Produto = readerb["Nome"].ToString();//
                                    }
                                }
                                connectionb.Close();
                            }
                            // Crie um novo botão

                            Button button = new Button();
                            button.Text = $"ID Produção:{id_turno} \n Produto: {Nome_Produto} ";
                            button.Size = new Size(276, 116);
                            button.Font = new Font("Arial", 18, FontStyle.Bold);
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.LightGreen;

                            button.Click += (sender, e) =>
                            {
                                // Este código será executado quando o botão for clicado
                                // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                                // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                                //int clickedIdLinha = id_setor;
                                //string clickedStatus = id_setor.ToString();
                                string extrair = sender.ToString();

                                int indexOfIdTurno = extrair.IndexOf("ID Produção:");
                                int indexOfNewLine = extrair.IndexOf("\n");

                                string turnoIdString = extrair.Substring(indexOfIdTurno + 12, indexOfNewLine - indexOfIdTurno - 13);

                                id_turno = int.Parse(turnoIdString);

                                AbrirFormularioProducaoAndamento(id_turno);
                            };
                            flowLayoutPanel2.Controls.Add(button);

                        }
                        reader.Close();

                    }
                    connectiona.Close();
                }
            }
            else
            {
                //this.Close();
            }
        }
        private void listarTurno2()
        {
            if (contador_click2 == 0)
            {
                contador_click1 = 0;
                contador_click2 = 1;
                contador_click3 = 0;
                flowLayoutPanel2.Controls.Clear();

                int id_produto = 0;
                string Nome_Produto = "";
                int id_turno = 0;
                int quantidadeTotalProduzida = 0;
                string horario_inicio = "0";
                string horario_final = "0";
                string tempo_total = "0";
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


                    string query = "SELECT * FROM producao where Turno = '2º'";
                    MySqlCommand command = new MySqlCommand(query, connectiona);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_turno = (int)reader["id_turno"];
                            quantidadeTotalProduzida = (int)reader["quantidade_Produzida"];
                            horario_inicio = reader["hora_inicio"].ToString();
                            horario_final = reader["hora_final"].ToString();
                            tempo_total = reader["paradasLinha"].ToString();
                            refugo_produto_acabado = (int)reader["refugo_produto_acabado"];
                            refugo_materia_prima = (int)reader["refugo_materia_prima"];
                            refugo_material = (int)reader["refugo_material"];
                            PPH = (double)reader["PPH"];
                            KU = (double)reader["KU"];
                            YIELD_materia_prima = (double)reader["YIELD_Materia_Prima"];
                            id_produto = (int)reader["ID_Produto"];

                            MySqlConnection connectionb = new MySqlConnection(connectionString);
                            connectionb.Open();

                            // Execute a consulta
                            string queryb = "SELECT Nome FROM produto_acabado WHERE id_produto = @ID_Produto";
                            MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
                            commandb.Parameters.AddWithValue("@ID_Produto", id_produto);

                            using (MySqlDataReader readerb = commandb.ExecuteReader())
                            {
                                if (readerb.HasRows)
                                {
                                    // Itere sobre os resultados da consulta
                                    while (readerb.Read())
                                    {
                                        // Pegue os valores dos campos da consulta
                                        Nome_Produto = readerb["Nome"].ToString();//
                                    }
                                }
                                connectionb.Close();
                            }
                            // Crie um novo botão

                            Button button = new Button();
                            button.Text = $"ID Produção:{id_turno} \n Produto: {Nome_Produto} ";
                            button.Size = new Size(276, 116);
                            button.Font = new Font("Arial", 18, FontStyle.Bold);
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.LightGreen;

                            button.Click += (sender, e) =>
                            {
                                // Este código será executado quando o botão for clicado
                                // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                                // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                                //int clickedIdLinha = id_setor;
                                //string clickedStatus = id_setor.ToString();
                                string extrair = sender.ToString();

                                int indexOfIdTurno = extrair.IndexOf("ID Produção:");
                                int indexOfNewLine = extrair.IndexOf("\n");

                                string turnoIdString = extrair.Substring(indexOfIdTurno + 12, indexOfNewLine - indexOfIdTurno - 13);

                                id_turno = int.Parse(turnoIdString);

                                AbrirFormularioProducaoAndamento(id_turno);
                            };
                            flowLayoutPanel2.Controls.Add(button);

                        }
                        reader.Close();

                    }
                    connectiona.Close();
                }
            }
            else
            {
                //this.Close();
            }


        }

        private void listarTurno3()
        {
            if (contador_click3 == 0)
            {
                contador_click1 = 0;
                contador_click2 = 0;
                contador_click3 = 1;
                flowLayoutPanel2.Controls.Clear();

                int id_produto = 0;
                string Nome_Produto = "";
                int id_turno = 0;
                int quantidadeTotalProduzida = 0;
                string horario_inicio = "0";
                string horario_final = "0";
                string tempo_total = "0";
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


                    string query = "SELECT * FROM producao where Turno = '3º'";
                    MySqlCommand command = new MySqlCommand(query, connectiona);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id_turno = (int)reader["id_turno"];
                            quantidadeTotalProduzida = (int)reader["quantidade_Produzida"];
                            horario_inicio = reader["hora_inicio"].ToString();
                            horario_final = reader["hora_final"].ToString();
                            tempo_total = reader["paradasLinha"].ToString();
                            refugo_produto_acabado = (int)reader["refugo_produto_acabado"];
                            refugo_materia_prima = (int)reader["refugo_materia_prima"];
                            refugo_material = (int)reader["refugo_material"];
                            PPH = (double)reader["PPH"];
                            KU = (double)reader["KU"];
                            YIELD_materia_prima = (double)reader["YIELD_Materia_Prima"];
                            id_produto = (int)reader["ID_Produto"];

                            MySqlConnection connectionb = new MySqlConnection(connectionString);
                            connectionb.Open();

                            // Execute a consulta
                            string queryb = "SELECT Nome FROM produto_acabado WHERE id_produto = @ID_Produto";
                            MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
                            commandb.Parameters.AddWithValue("@ID_Produto", id_produto);

                            using (MySqlDataReader readerb = commandb.ExecuteReader())
                            {
                                if (readerb.HasRows)
                                {
                                    // Itere sobre os resultados da consulta
                                    while (readerb.Read())
                                    {
                                        // Pegue os valores dos campos da consulta
                                        Nome_Produto = readerb["Nome"].ToString();//
                                    }
                                }
                                connectionb.Close();
                            }
                            // Crie um novo botão

                            Button button = new Button();
                            button.Text = $"ID Produção:{id_turno} \n Produto: {Nome_Produto} ";
                            button.Size = new Size(276, 116);
                            button.Font = new Font("Arial", 18, FontStyle.Bold);
                            button.ForeColor = Color.Black;
                            button.BackColor = Color.LightGreen;

                            button.Click += (sender, e) =>
                            {
                                // Este código será executado quando o botão for clicado
                                // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                                // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                                //int clickedIdLinha = id_setor;
                                //string clickedStatus = id_setor.ToString();
                                string extrair = sender.ToString();

                                int indexOfIdTurno = extrair.IndexOf("ID Produção:");
                                int indexOfNewLine = extrair.IndexOf("\n");

                                string turnoIdString = extrair.Substring(indexOfIdTurno + 12, indexOfNewLine - indexOfIdTurno - 13);

                                id_turno = int.Parse(turnoIdString);

                                AbrirFormularioProducaoAndamento(id_turno);
                            };
                            flowLayoutPanel2.Controls.Add(button);

                        }
                        reader.Close();

                    }
                    connectiona.Close();
                }
            }
            else
            {
                //this.Close();
            }


        }
        private void btn_turno1_Click(object sender, EventArgs e)
        {
            listarTurno1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listarTurno2();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listarTurno3();
        }
    }
}
