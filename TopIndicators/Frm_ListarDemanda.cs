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
    public partial class Frm_ListarDemanda : Form
    {
        public Frm_ListarDemanda()
        {
            InitializeComponent();
        }

        public void Frm_ListarDemanda_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT id_Demanda, quantidade_Demandada, prazo, ID_Cliente, ID_Produto, qunatidade_produzida FROM demanda";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_listarDemanda.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_listarDemanda.Rows.Add(reader["id_Demanda"], reader["quantidade_Demandada"], reader["prazo"], reader["ID_Cliente"], reader["ID_Produto"], reader["qunatidade_produzida"]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nenhum registro encontrado.");
                    }
                }

                connection.Close();
            }
        }

        private void dtv_listarDemanda_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
