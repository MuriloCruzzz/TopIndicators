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
using OfficeOpenXml;
//using OfficeOpenXml.Core.ExcelPackage;
using System.IO;

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

        private void button4_Click(object sender, EventArgs e)
        {
            string dadosCotacao = $"Produção = {lbl_nome_produto.Text} - Relatório";

            listBox1.Items.Clear();
            listBox1.Items.Add(dadosCotacao);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
            saveFileDialog.Title = "Salvar Produção como...";
            saveFileDialog.FileName = "produção"+ lbl_nome_produto.Text + ".xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Cria uma planilha
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Produção");

                        // Adiciona os dados adicionais
                        worksheet.Cells["A1"].Value = "Produção";
                        worksheet.Cells["B1"].Value = lbl_nome_produto.Text.Trim();
                        worksheet.Cells["A2"].Value = "Cliente";
                        worksheet.Cells["B2"].Value = lb_cliente.Text.Trim();
                        worksheet.Cells["A3"].Value = "PPH";
                        worksheet.Cells["B3"].Value = lbl_pph.Text.Trim();
                        worksheet.Cells["A4"].Value = "KU";
                        worksheet.Cells["B4"].Value = lbl_ku.Text.Trim();
                        worksheet.Cells["A5"].Value = "YIELD";
                        worksheet.Cells["B5"].Value = lbl_YIELD.Text.Trim();
                        worksheet.Cells["A6"].Value = "Tempo Total Produção";
                        worksheet.Cells["B6"].Value = lbl_tempo_total_producao.Text.Trim();
                        worksheet.Cells["A7"].Value = "Tempo Paradas de Linha";
                        worksheet.Cells["B7"].Value = lbl_paradasLinha.Text.Trim();
                        worksheet.Cells["A8"].Value = "Hora Inicio";
                        worksheet.Cells["B8"].Value = lbl_h_inicio.Text.Trim();
                        worksheet.Cells["A9"].Value = "Hora Final";
                        worksheet.Cells["B9"].Value = lbl_h_final.Text.Trim();
                        worksheet.Cells["A10"].Value = "Quantidade Produzida";
                        worksheet.Cells["B10"].Value = lbl_quantidade.Text.Trim();
                        worksheet.Cells["A11"].Value = "Refugo Componentes";
                        worksheet.Cells["B11"].Value = lbl_refugo_material.Text.Trim();
                        worksheet.Cells["A12"].Value = "Refugo Materia Prima";
                        worksheet.Cells["B12"].Value = lbl_refugo_materia_prima.Text.Trim();
                        worksheet.Cells["A13"].Value = "Refugo Produto Acabado";
                        worksheet.Cells["B13"].Value = lbl_refugo_produto_acabado.Text.Trim();

                        // Adiciona os cabeçalhos


                        int row = 1;
                        foreach (var item in listBox1.Items)
                        {
                            string[] partes = item.ToString().Split(new string[] { " - " }, StringSplitOptions.None);
                            worksheet.Cells[row, 1].Value = partes[0].Trim();
                            worksheet.Cells[row, 2].Value = partes[1].Trim();


                            row++;
                            //}

                            // Ajuste automático do tamanho das colunas
                            worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                            // Salva o arquivo
                            FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                            excelPackage.SaveAs(fileInfo);

                            MessageBox.Show("Produção "+ lbl_nome_produto.Text + "o exportada com sucesso!");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao exportar a produção: {ex.Message}");
                }
            }

        }
    }
}

