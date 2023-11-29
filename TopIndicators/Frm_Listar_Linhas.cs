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
    public partial class Frm_Listar_Linhas : Form
    {
        public Frm_Listar_Linhas()
        {
            InitializeComponent();
            LoadDataAndCreateButtons();
        }
        int id_producao = 0;
        private void LoadDataAndCreateButtons()
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            string query = "SELECT id_producao, status_producao FROM producao_linha";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                connection.Open();
                string status_producao = "";
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int idLinha = (int)reader["id_producao"];
                    id_producao = idLinha;
                    int status = (int)reader["status_producao"];
                    if(status != 2)
                    {
                        if (status == 0)
                        {
                            status_producao = "Em produção";
                        }
                        // Crie um novo botão
                        Button button = new Button();
                        button.Text = $"ID PRODUÇÃO: {idLinha} \nStatus: {status_producao}";
                        button.Size = new Size(182, 94);
                        button.Font = new Font("Arial", 14, FontStyle.Bold);
                        button.BackColor = Color.DeepSkyBlue;
                        button.ForeColor = Color.Black;
                        if (status == 1)
                        {
                            button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Em Andamento";
                            button.BackColor = Color.DeepSkyBlue; // Define um fundo como LightGreen
                        }
                        else if (status == 2)
                        {
                            button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Linha Finalizada";
                            button.BackColor = Color.Tomato;
                            return;
                        }
                        else if (status == 0)
                        {
                            button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Aguandando 1º lançamento";
                            button.BackColor = Color.Gold;
                        }
                        /*
                        button.Click += (sender, e) =>
                        {
                            // Este código será executado quando o botão for clicado
                            // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                            // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                            int clickedIdLinha = idLinha;
                            string clickedStatus = status_producao;
                            AbrirFormularioProducaoAndamento(clickedIdLinha);
                        };
                        */

                        AdicionarEventosAosBotoes(button);


                        //Painel painel1 = new Painel();
                        //panel1.AutoScroll = true; // Habilita rolagem automática vertical
                        //panel1.Dock = DockStyle.Fill;

                        flowLayoutPanel2.Controls.Add(button);


                    }

                }
                reader.Close();
            }
        }
        private void AdicionarEventosAosBotoes(Button button)
        {
            // Itere sobre os botões

            // Adicione um evento Click ao botão
            button.Click += (sender, e) =>
            {
                // Extraia o ID_Produção do texto do botão
                int idProducao = ExtractIdProducaoFromButtonText((Button)sender);

                // Execute alguma ação com o ID_Produção
                // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                AbrirFormularioProducaoAndamento(idProducao);
            };
        }

        private int ExtractIdProducaoFromButtonText(Button button)
        {
            int idProducao = -1; // Valor padrão caso não seja encontrado

            // Dividir o texto em partes usando a vírgula como delimitador
            string[] parts = button.Text.Split(',');

            foreach (string part in parts)
            {
                // Procurar a parte que contém "ID_Produção:"
                if (part.Contains("ID PRODUÇÃO:"))
                {
                    // Extrair o ID_Produção como uma string
                    string idPart = part.Trim().Replace("ID PRODUÇÃO:", "");

                    // Converter a string para um valor inteiro
                    if (int.TryParse(idPart, out idProducao))
                    {
                        id_producao = idProducao;
                        break; // Sai do loop quando encontrar o ID_Produção
                    }
                }
            }

            return idProducao;
        }
        private void AbrirFormularioProducaoAndamento(int idLinha)
        {

            Frm_Vizualizar_Linhas fmr = new Frm_Vizualizar_Linhas();
            fmr.id_producao = id_producao;

            fmr.ShowDialog();
        }
    }
}

