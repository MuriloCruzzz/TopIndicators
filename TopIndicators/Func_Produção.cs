using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Func_Produção : Form
    {
        private string id_usuario;
        public string Id_Usuario
        {
            set { id_usuario = value; }
        }
        public Func_Produção()
        {
            InitializeComponent();
            LoadDataAndCreateButtons();
        }
        int id_producao = 0;
        int teste = 0;
        private bool processoExecutado = false;
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
                    if (status == 0)
                    {
                        status_producao = "Em produção";
                    }
                    if(status != 2)
                    {
                        // Crie um novo botão
                        Button button = new Button();
                        button.Text = $"ID PRODUÇÃO: {idLinha} \nStatus: {status_producao}";
                        button.Size = new Size(182, 94);
                        button.Font = new Font("Arial", 14, FontStyle.Bold);
                        button.BackColor = Color.LightGreen;
                        button.ForeColor = Color.Black;
                        if (status == 1)
                        {
                            button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Em Andamento";
                            button.BackColor = Color.LightGreen; // Define um fundo como LightGreen
                        }
                        else if (status == 0)
                        {
                            button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Aguandando 1º lançamento";
                            button.BackColor = Color.Gold;
                        }

                        AdicionarEventosAosBotoes(button);

                        flowLayoutPanel2.Controls.Add(button);

                    }
                }
                reader.Close();
            }

        }

        private void AdicionarEventosAosBotoes(Button button)
        {

            button.Click += (sender, e) =>
            {
                int idSelecionado = ExtractIdProducaoFromButtonText((Button)sender);

                AbrirFormularioProducaoAndamento(id_producao);
            };
        }

        private int ExtractIdProducaoFromButtonText(Button button)
        {
            int idProducao = 0; // Valor padrão caso não seja encontrado

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

            Form1 fmr = new Form1();
            fmr.id_producao = id_producao;
            fmr.ShowDialog();

        }

    }
}
