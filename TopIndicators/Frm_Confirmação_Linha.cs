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
            int id_demanda = this.id_demanda;
            int quantidade_demandada = this.quantidade_demandada;
            string prazo = this.prazo;
            string nome_cliente = this.nome_cliente;
            string nome_produto = this.nome_produto;
            int quantidade_produzida = this.quantidade_produzida;

            string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection1 = new MySqlConnection(connectionString1))
            {
                connection1.Open();

                // Cria um comando SQL para inserir um registro na tabela produção
                //MySqlCommand command1 = new MySqlCommand("INSERT INTO producao_linha(id_produto_materia_prima,id_produto_material,id_produto_acabado,quantidade_produzidas,quantidade_demanda_atual,tempo_total_producao,hora_inicial,hora_final,quantidade_refugo_materia_prima,quantidade_refugo_produto_acabado,quantidade_refugo_material,tempo_parada_linha,observacao_parada_linha, status_producao VALUES" +
                //"(@id_produto_materia_prima,@id_produto_material,@id_produto_acabado,@quantidade_produzidas,@quantidade_demanda_atual,@tempo_total_producao,@hora_inicial,@hora_final,@quantidade_refugo_materia_prima,@quantidade_refugo_produto_acabado,@quantidade_refugo_material,@tempo_parada_linha,@observacao_parada_linha,@status_producao);", connection1);

                string queryCreate = "INSERT INTO producao_linha(id_produto_materia_prima,id_produto_material,id_produto_acabado,quantidade_produzidas,quantidade_demanda_atual,quantidade_refugo_materia_prima,quantidade_refugo_produto_acabado,quantidade_refugo_material,observacao_parada_linha,status_producao) VALUES (@id_produto_materia_prima,@id_produto_material,@id_produto_acabado,@quantidade_produzidas,@quantidade_demanda_atual,@quantidade_refugo_materia_prima,@quantidade_refugo_produto_acabado,@quantidade_refugo_material,@observacao_parada_linha,@status_producao);";

                MySqlCommand commandCreate = new MySqlCommand(queryCreate, connection1);
                {
                    commandCreate.Parameters.AddWithValue("@id_produto_materia_prima", id_demanda);
                    commandCreate.Parameters.AddWithValue("@id_produto_material", id_demanda);
                    commandCreate.Parameters.AddWithValue("@id_produto_acabado", nome_produto);
                    commandCreate.Parameters.AddWithValue("@quantidade_produzidas", quantidade_produzida);
                    commandCreate.Parameters.AddWithValue("@quantidade_demanda_atual", quantidade_demandada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_materia_prima", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_produto_acabado", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@quantidade_refugo_material", quantidade_zerada);
                    commandCreate.Parameters.AddWithValue("@observacao_parada_linha", status);
                    commandCreate.Parameters.AddWithValue("@status_producao", status_producao);



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
    }
}
