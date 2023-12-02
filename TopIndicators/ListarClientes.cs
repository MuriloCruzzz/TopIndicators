using AngleSharp.Dom;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class ListarClientes : Form
    {
        public ListarClientes()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ListarClientes_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_Cliente AS Registro, nome AS Nome, CNPJ FROM cliente";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_clientes.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_clientes.Rows.Add(reader["Registro"], reader["Nome"], reader["CNPJ"]);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string pesquisa = txtPesquisa.Text;
            int n = txtPesquisa.Text.Length;
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT id_Cliente AS Registro, nome AS Nome, CNPJ FROM cliente WHERE LEFT(nome, " + n + ") = '" + pesquisa + "';";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_clientes.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_clientes.Rows.Add(reader["Registro"], reader["Nome"], reader["CNPJ"]);
                        }
                    }
                }
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string dadosCotacao = $"Registro - Cliente - CNPJ";

            List<Cliente> listaClientes = new List<Cliente>();
            dtv_clientes_ls.Items.Add(dadosCotacao);
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Arquivos Excel | *.xlsx";
            saveFileDialog.Title = "Salvar Produção como...";
            saveFileDialog.FileName = "clientes.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (ExcelPackage excelPackage = new ExcelPackage())
                    {
                        // Cria uma planilha
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Clientes");
                        worksheet.Cells["A1"].Value = "ID";
                        worksheet.Cells["B1"].Value = "Cliente";
                        worksheet.Cells["C1"].Value = "CNPJ";
                        // Adiciona os cabeçalhos
                        worksheet.Cells["A2"].Value = "ID";
                        worksheet.Cells["B2"].Value = "Cliente";
                        worksheet.Cells["C2"].Value = "CNPJ";

                        int row = 2; // Começa a partir da próxima linha após os cabeçalhos

                        // Itera sobre as linhas do DataGridView
                        foreach (DataGridViewRow dataGridViewRow in dtv_clientes.Rows)
                        {
                            // Certifique-se de não pegar a linha de cabeçalho
                            if (!dataGridViewRow.IsNewRow)
                            {
                                // Supondo que a primeira célula contém o ID, a segunda o nome e a terceira o CNPJ
                                string id = dataGridViewRow.Cells["ID"].Value.ToString();
                                string nomeCliente = dataGridViewRow.Cells["Nome"].Value.ToString();
                                string cnpj = dataGridViewRow.Cells["CNPJ"].Value.ToString();

                                // Adiciona os dados ao Excel
                                worksheet.Cells[row, 1].Value = id;
                                worksheet.Cells[row, 2].Value = nomeCliente;
                                worksheet.Cells[row, 3].Value = cnpj;

                                row++;
                            }
                        }

                        // Ajuste automático do tamanho das colunas
                        worksheet.Cells[worksheet.Dimension.Address].AutoFitColumns();

                        // Salva o arquivo
                        FileInfo fileInfo = new FileInfo(saveFileDialog.FileName);
                        excelPackage.SaveAs(fileInfo);

                        MessageBox.Show("Clientes exportados com sucesso!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao exportar clientes: {ex.Message}");
                }
            }
        } 
    }
}
