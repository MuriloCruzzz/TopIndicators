using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TopIndicators
{
    public partial class Frm_1_usuario : Form
    {
        public Frm_1_usuario()
        {
            InitializeComponent();
        }

        private void Frm_1_usuario_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT ID, nome, id_setor, senha FROM usuario WHERE Grupo_Acesso = 0";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"]);
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

        private void dtv_colaboradores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_colaboradores.Rows[e.RowIndex];

                string registroUsuario = row.Cells["ID"].Value.ToString();
                string nomeUsuario = row.Cells["Nome"].Value.ToString();
                string senhaUsuario = row.Cells["senha"].Value.ToString();
                string setorUsuario = row.Cells["id_setor"].Value.ToString();
;

                Alterar_Excluir_Usuario frm1 = new Alterar_Excluir_Usuario();

                // Passe os valores para as propriedades do formulário
                frm1.RegistroUsuario = registroUsuario;
                frm1.NomeUsuario = nomeUsuario;
                frm1.SetorUsuario = setorUsuario;
                frm1.SenhaUsuario = senhaUsuario;

                frm1.Show(); // Ou frm1.ShowDialog() dependendo do comportamento desejado

            }
        }

        private void checkbox_status_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
