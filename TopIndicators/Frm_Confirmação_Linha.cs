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
    public partial class Frm_Confirmação_Linha : Form
    {
        public Frm_Confirmação_Linha()
        {
            InitializeComponent();
        }

        public int id_demanda { get; set; }
        public int quantidade_demandada { get; set; }
        public string prazo { get; set; }
        public string nome_cliente { get; set; }
        public string nome_produto { get; set; }
        public int quantidade_produzida { get; set; }

        string tempo = null;
        int id_Producao;
        int quantidade_Produzida;
        DateTime hora_inicio;
        DateTime hora_final;
        DateTime tempo_total_producao;
        string status = "teste para linha";
        int refugoProdutos;
        int parasLinha;
        string id_setor;
        int ID_Produto;
        int ID_Cliente;
        int ID_Turno;
        int quantidade_zerada = 0;
        int status_producao = 0;


        public void button1_Click(object sender, EventArgs e)
        {
            if(cmb_turno.Text != "1º" && cmb_turno.Text != "2º" && cmb_turno.Text != "3º")
            {
                MessageBox.Show("Campo Turno Incorreto!");
                cmb_turno.Text = "1º";
                return;
            }

            int id_demanda = this.id_demanda;
            int quantidade_demandada = this.quantidade_demandada;
            string prazo = this.prazo;
            string nome_cliente = this.nome_cliente;
            string nome_produto = this.nome_produto;
            string nome_materia_prima = "";
            string nome_componente = "";
            int quantidade_produzida = this.quantidade_produzida;

            int id_materia_prima = 0;
            int id_materia_prima_componente = 0;

            // trazendo os ids para adicionar no cadastro da linha
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;"; // Substitua pela sua própria string de conexão

            using (MySqlConnection connection1 = new MySqlConnection(connectionString))
            {
                try
                {
                    connection1.Open();

                    string query2 = "SELECT Material_Consumo, Materia_Prima_Consumo FROM produto_acabado WHERE id_produto = @id_produto";
                    MySqlCommand commandCreate2 = new MySqlCommand(query2, connection1);

                    commandCreate2.Parameters.AddWithValue("@id_produto", nome_produto);

                    using (MySqlDataReader reader = commandCreate2.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            // Adiciona as opções ao ComboBox
                            while (reader.Read())
                            {
                                nome_materia_prima = reader["Material_Consumo"].ToString();
                                nome_componente = reader["Materia_Prima_Consumo"].ToString();

                                using (MySqlConnection connection3 = new MySqlConnection(connectionString))
                                {
                                    try
                                    {
                                        connection3.Open();

                                        string query3 = "SELECT t1.id_Produto AS id_ProdutoMP , t2.id_Produto AS id_ProdutoCP FROM  produto_materia_prima AS t1 JOIN produto_materia_prima_componente AS t2 ON t1.Nome = '@NomeMP' AND t2.Nome = '@NomeCP';";
                                        MySqlCommand commandCreate3 = new MySqlCommand(query3, connection3);

                                        commandCreate2.Parameters.AddWithValue("@NomeMP", nome_materia_prima);
                                        commandCreate2.Parameters.AddWithValue("@NomeCP", nome_materia_prima);

                                        using (MySqlDataReader reader3 = commandCreate2.ExecuteReader())
                                        {
                                            if (reader.HasRows)
                                            {
                                                // Adiciona as opções ao ComboBox
                                                while (reader.Read())
                                                {
                                                    id_materia_prima = int.Parse(reader["id_ProdutoMP"].ToString());
                                                    id_materia_prima_componente = int.Parse(reader["id_ProdutoCP"].ToString());
                                                }
                                            }
                                        }
                                    }
                                    catch (Exception ex)
                                    {

                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {

                }
            }


            string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
            {
                connection1.Open();

                // Cria um comando SQL para inserir um registro na tabela produção
                //MySqlCommand command1 = new MySqlCommand("INSERT INTO producao_linha(id_produto_materia_prima,id_produto_material,id_produto_acabado,quantidade_produzidas,quantidade_demanda_atual,tempo_total_producao,hora_inicial,hora_final,quantidade_refugo_materia_prima,quantidade_refugo_produto_acabado,quantidade_refugo_material,tempo_parada_linha,observacao_parada_linha, status_producao VALUES" +
                //"(@id_produto_materia_prima,@id_produto_material,@id_produto_acabado,@quantidade_produzidas,@quantidade_demanda_atual,@tempo_total_producao,@hora_inicial,@hora_final,@quantidade_refugo_materia_prima,@quantidade_refugo_produto_acabado,@quantidade_refugo_material,@tempo_parada_linha,@observacao_parada_linha,@status_producao);", connection1);

                string queryCreate = "INSERT INTO producao_linha(id_produto_materia_prima,id_produto_material,id_produto_acabado,quantidade_produzidas,quantidade_demanda_atual,quantidade_refugo_materia_prima,quantidade_refugo_produto_acabado,quantidade_refugo_material,observacao_parada_linha,status_producao, quantidade_operadores, turno) VALUES (@id_produto_materia_prima,@id_produto_material,@id_produto_acabado,@quantidade_produzidas,@quantidade_demanda_atual,@quantidade_refugo_materia_prima,@quantidade_refugo_produto_acabado,@quantidade_refugo_material,@observacao_parada_linha,@status_producao, @quantidade_operadores, @turno);";

                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                {
                    commandCreate.Parameters.AddWithValue("@id_produto_materia_prima", id_materia_prima);
                    commandCreate.Parameters.AddWithValue("@id_produto_material", id_materia_prima_componente);
                    commandCreate.Parameters.AddWithValue("@id_produto_acabado", nome_produto);
                    commandCreate.Parameters.AddWithValue("@quantidade_produzidas", quantidade_produzida);
                    commandCreate.Parameters.AddWithValue("@quantidade_demanda_atual", quantidade_demandada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_materia_prima", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_produto_acabado", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_material", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@observacao_parada_linha", status);
                    commandCreate.Parameters.AddWithValue("@status_producao", status_producao);
                    commandCreate.Parameters.AddWithValue("@quantidade_operadores", 1);
                    commandCreate.Parameters.AddWithValue("@turno", cmb_turno.Text);




                    commandCreate.ExecuteNonQuery();
                    // Executa o comando SQL
                    this.Close();
                    //command1.ExecuteNonQuery();

                    // Fecha a conexão com o banco de dados
                }

            }

            using (MySqlConnection connection2 = new MySqlConnection(connectionString1))
            {
                connection2.Open();

                // Cria um comando SQL para inserir um registro na tabela produção
                //MySqlCommand command1 = new MySqlCommand("INSERT INTO producao_linha(id_produto_materia_prima,id_produto_material,id_produto_acabado,quantidade_produzidas,quantidade_demanda_atual,tempo_total_producao,hora_inicial,hora_final,quantidade_refugo_materia_prima,quantidade_refugo_produto_acabado,quantidade_refugo_material,tempo_parada_linha,observacao_parada_linha, status_producao VALUES" +
                //"(@id_produto_materia_prima,@id_produto_material,@id_produto_acabado,@quantidade_produzidas,@quantidade_demanda_atual,@tempo_total_producao,@hora_inicial,@hora_final,@quantidade_refugo_materia_prima,@quantidade_refugo_produto_acabado,@quantidade_refugo_material,@tempo_parada_linha,@observacao_parada_linha,@status_producao);", connection1);

                string queryCreate = "UPDATE demanda SET status_demanda = 1 WHERE id_demanda = @id_demanda;";
                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection2);
                {
                    commandCreate.Parameters.AddWithValue("@id_demanda", id_demanda);
                    commandCreate.ExecuteNonQuery();
                    MessageBox.Show("Linha " + nome_produto + " Em operação!!!");
                    // Obtenha uma referência ao formulário

                }

            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Lbl_Cadastro_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Confirmação_Linha_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
