using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;
using DadosUsuarios;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Web;
using AngleSharp.Io;
using iTextSharp.text.pdf;
using System.Runtime.Remoting.Lifetime;
using System.Data.SqlClient;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;

namespace TopIndicators
{
    public partial class Frm_1_usuario : Form
    {
        public DataGridView dgvData;
        public Frm_1_usuario()
        {
            InitializeComponent();
        }

        public void Frm_1_usuario_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE Status_Usuario = 0";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"], reader["Grupo_Acesso"], reader["turno"]);
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

        public void dtv_colaboradores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            // Verifique se o índice da linha selecionada é válido
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtv_colaboradores.Rows[e.RowIndex];

                string registroUsuario = row.Cells["ID"].Value.ToString();
                string nomeUsuario = row.Cells["Nome"].Value.ToString();
                string senhaUsuario = row.Cells["senha"].Value.ToString();
                string setorUsuario = row.Cells["id_setor"].Value.ToString();
                string grupo_acesso = row.Cells["Cargo"].Value.ToString();
                string turno_usuario = row.Cells["Turno"].Value.ToString();
                ;

                Alterar_Excluir_Usuario frm1 = new Alterar_Excluir_Usuario();

                // Passe os valores para as propriedades do formulário
                frm1.RegistroUsuario = registroUsuario;
                frm1.NomeUsuario = nomeUsuario;
                frm1.SetorUsuario = setorUsuario;
                frm1.SenhaUsuario = senhaUsuario;
                frm1.Grupo_Acesso = grupo_acesso;
                frm1.TurnoUsuario = turno_usuario;


                frm1.ShowDialog();
                AtualizarDados();
            }
        }
        public void AtualizarDados()
        {
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE Status_Usuario = 0";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"], reader["Grupo_Acesso"], reader["turno"]);
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

        private void checkbox_status_CheckedChanged(object sender, EventArgs e)
        {
            string checkON = "";
            if (checkbox_status.Checked)
            {
                // Quando o CheckBox estiver marcado (habilitado)
                checkON = "Status_Usuario = 1";
            }
            else
            {
                // Quando o CheckBox não estiver marcado (desabilitado)
                checkON = "Status_Usuario = 0";
            }

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE " + checkON + ";";
                MySqlCommand command = new MySqlCommand(query, connection);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                        while (reader.Read())
                        {
                            dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"], reader["Grupo_Acesso"], reader["turno"]);
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
        private DataTable GerarDadosRelatorio()
        {
            var dt = new DataTable();
            dt.Columns.Add("Registro", typeof(int));
            dt.Columns.Add("Nome");
            dt.Columns.Add("Setor");
            dt.Columns.Add("Cargo");
            dt.Columns.Add("Turno");



            foreach (DataGridViewRow item in dtv_colaboradores.Rows)
            {
                dt.Rows.Add(Convert.ToInt32(item.Cells[0].Value),
                                            item.Cells[1].Value,
                                            item.Cells[2].Value,
                                            item.Cells[3].Value,
                                            item.Cells[4].Value);

            }
            return dt;
        }

        private void btn_imprimir_Click(object sender, EventArgs e)
        {
           
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            string Nome = txtPesquisa.Text;
            int n = txtPesquisa.Text.Length;




            if (checkbox_status.Checked)
            {
                string connectionString1 = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString1))
                {

                    connection.Open();

                    string query = "SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE LEFT(nome, " + n + ") = '" + Nome + "'AND Status_Usuario = 1;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"], reader["Grupo_Acesso"], reader["turno"]);
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
            else
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {

                    connection.Open();

                    string query = "SELECT ID, nome, id_setor, senha, Grupo_Acesso, turno FROM usuario WHERE LEFT(nome, " + n + ") = '" + Nome + "' AND Status_Usuario = 0;";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            dtv_colaboradores.Rows.Clear(); // Limpa as linhas existentes no DataGridView

                            while (reader.Read())
                            {
                                dtv_colaboradores.Rows.Add(reader["ID"], reader["nome"], reader["id_setor"], reader["senha"], reader["Grupo_Acesso"], reader["turno"]);
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
            
            
        }
    }
}


