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
    public partial class Func_Produção : Form
    {
        public Func_Produção()
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
                    if (status == 0)
                    {
                        status_producao = "Em produção";
                    }
                    // Crie um novo botão
                    Button button = new Button();
                    button.Text = $"ID PRODUÇÃO: {idLinha} \nStatus: {status_producao}";
                    button.Size = new Size(182, 94);
                    button.Font = new Font("Arial", 14, FontStyle.Bold);
                    button.BackColor = Color.LightGreen;
                    button.ForeColor = Color.Black;
                    if (status == 0)
                    {
                        button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Em Andamento";
                        button.BackColor = Color.LightGreen; // Define um fundo como LightGreen
                    }
                    else if (status == 2)
                    {
                        button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Linha Finalizada";
                        button.BackColor = Color.Tomato;
                    }
                    else if (status == 1)
                    {
                        button.Text = $"ID PRODUÇÃO: {idLinha}, Status: Aguandando 1º lançamento";
                        button.BackColor = Color.Gold;
                    }

                    button.Click += (sender, e) =>
                    {
                        // Este código será executado quando o botão for clicado
                        // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                        // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                        int clickedIdLinha = idLinha;
                        string clickedStatus = status_producao;
                        AbrirFormularioProducaoAndamento(clickedIdLinha, clickedStatus);
                    };
                    //Painel painel1 = new Painel();
                    //panel1.AutoScroll = true; // Habilita rolagem automática vertical
                    //panel1.Dock = DockStyle.Fill;
                    // Adicione o botão ao FlowLayoutPanel
                    flowLayoutPanel2.Controls.Add(button);
                }
                reader.Close();
            }
        }

        private void AbrirFormularioProducaoAndamento(int idLinha, string status)
        {
            // Código para abrir o formulário Producao_Andamento e passar os parâmetros
            // Você precisa implementar a lógica para abrir o formulário e passar os parâmetros
            // Pode ser semelhante ao que mencionamos em respostas anteriores.
            Form1 fmr = new Form1();
            fmr.ShowDialog();

        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            // Extrair o ID_Linha do texto do botão
            int idLinha = ExtractIdLinhaFromButtonText(clickedButton.Text);

            // Criar uma instância do formulário Producao_Andamento, passando o ID_Linha como parâmetro
            Form1 formularioProducaoAndamento = new Form1();

            // Exibir o formulário Producao_Andamento
            formularioProducaoAndamento.Show();
        }
        private int ExtractIdLinhaFromButtonText(string buttonText)
        {
            int idLinha = -1; // Valor padrão caso não seja encontrado

            // Dividir o texto em partes usando a vírgula como delimitador
            string[] parts = buttonText.Split(',');

            foreach (string part in parts)
            {
                // Procurar a parte que contém "ID_Linha:"
                if (part.Contains("ID_Linha:"))
                {
                    // Extrair o ID_Linha como uma string
                    string idPart = part.Trim().Replace("ID_Linha:", "");

                    // Converter a string para um valor inteiro
                    if (int.TryParse(idPart, out idLinha))
                    {
                        break; // Sai do loop quando encontrar o ID_Linha
                    }
                }
            }

            return idLinha;
        }

    }
}
