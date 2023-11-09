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

namespace TopIndicators
{
    public partial class Frm_Listar_Turno : Form
    {
        public Frm_Listar_Turno()
        {
            InitializeComponent();
            LoadDataAndCreateButtons();
        }
        private void LoadDataAndCreateButtons()
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT * FROM turno";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int idLinha = (int)reader["ID"];
                        DateTime horario_inicio = (DateTime)reader["horario_inicio"];
                        DateTime data = (DateTime)reader["data"];
                        int quantidadeTotalProduzida = (int)reader["quantidadeTotalProduzida"];
                        int id_setor = (int)reader["id_setor"];
                        int ID_Producao = (int)reader["ID_Producao"];


                        // Crie um novo botão

                        System.Windows.Forms.Button button = new System.Windows.Forms.Button();
                        button.Text = $"ID Linha: {idLinha}ID Produção: {horario_inicio} \nData : {data}\nHorario Inicio: {horario_inicio}\nHProduzido: {ID_Producao}";
                        button.Size = new Size(390, 186);
                        button.Font = new Font("Arial", 18, FontStyle.Bold);
                        button.BackColor = Color.LightGreen;
                        if (id_setor == 1)
                        {
                            button.Text = $"ID Linha: {idLinha}, Status: Em Andamento";
                            button.BackColor = Color.LightGreen; // Define a cor de fundo como LightGreen
                        }
                        else if (id_setor == 0)
                        {
                            button.Text = $"ID Linha: {idLinha}, Status: Linha Finalizada";
                            button.BackColor = Color.Tomato;
                        }
                        else if (id_setor == 2)
                        {
                            button.Text = $"ID Linha: {idLinha}, Status: Aguandando 1º lançamento";
                            button.BackColor = Color.Gold;
                        }
                        button.Click += (sender, e) =>
                        {
                            // Este código será executado quando o botão for clicado
                            // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
                            // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
                            int clickedIdLinha = idLinha;
                            string clickedStatus = id_setor.ToString();
                            AbrirFormularioProducaoAndamento(clickedIdLinha, clickedStatus);
                        };
                        //Panel panel1 = new Panel();
                        //panel1.AutoScroll = true; // Habilita a rolagem automática vertical
                        //panel1.Dock = DockStyle.Fill;


                        // Adicione o botão ao FlowLayoutPanel
                        panel1.Controls.Add(button);
                    }

                    reader.Close();
                }

                connection.Close();
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

        private void Button_Click(int idLinha, int idSetor, object sender, EventArgs e)
        {
            // Este código será executado quando o botão for clicado
            // Você pode realizar qualquer ação desejada aqui com base no ID_Linha e Status
            // Por exemplo, abrir o formulário Producao_Andamento com os dados da produção
            //int clickedIdLinha = idLinha;
            string clickedStatus = idSetor.ToString();
            //AbrirFormularioProducaoAndamento(clickedIdLinha, clickedStatus);




            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;

            // Extrair o ID_Linha do texto do botão
            //int idLinha = ExtractIdLinhaFromButtonText(clickedButton.Text);

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
