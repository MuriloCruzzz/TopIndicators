using DadosUsuarios;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace TopIndicators
{
    public partial class Alterar_Excluir_Usuario : Form
    {
        private string registroUsuario;
        private string nomeUsuario;
        private string setorUsuario;
        private string senhaUsuario;
        private string grupo_acesso;
        private string turnoUsuario;

        public Alterar_Excluir_Usuario()
        {
            InitializeComponent();
        }
        public string RegistroUsuario
        {
            set { registroUsuario = value; }
        }
        public string Grupo_Acesso
        {
            set { grupo_acesso = value; }
        }
        public string SenhaUsuario
        {
            set { senhaUsuario = value; }
        }
        public string NomeUsuario
        {
            set { nomeUsuario = value; }
        }

        public string SetorUsuario
        {
            set { setorUsuario = value; }
        }

        public string TurnoUsuario
        {
            set { turnoUsuario = value; }
        }


        private void Alterar_Excluir_Usuario_Load_1(object sender, EventArgs e)
        {
            cod_colab.Text = registroUsuario;
            txb_nome.Text = nomeUsuario;
            cmb_setor.Text = setorUsuario;
            txb_senha.Text = senhaUsuario;
            cmb_cargo.Text = grupo_acesso;
            cmb_turno.Text = turnoUsuario;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            txb_nome.Text = "";
            cmb_setor.Text = "";
            txb_senha.Text = "";
            cmb_cargo.Text = "";
            cmb_turno.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string NovoNome = txb_nome.Text;
            string NovoSetor = cmb_setor.Text;
            string NovaSenha = txb_senha.Text;
            string NovaGrupoAcesso = cmb_cargo.Text;
            string TurnoUsuario = cmb_turno.Text;
            int id_usuario = int.Parse(cod_colab.Text);

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string queryUpdate = "UPDATE usuario SET Nome = @Nome, Senha = @Senha, id_setor = @Setor, Grupo_Acesso = @Grupo_Acesso, turno = @turno WHERE ID = @ID";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Nome", NovoNome);
                commandUpdate.Parameters.AddWithValue("@Senha", NovaSenha);
                commandUpdate.Parameters.AddWithValue("@Setor", NovoSetor);
                commandUpdate.Parameters.AddWithValue("@ID", id_usuario);
                commandUpdate.Parameters.AddWithValue("@Grupo_Acesso", NovaGrupoAcesso);
                commandUpdate.Parameters.AddWithValue("turno", TurnoUsuario);
                commandUpdate.ExecuteNonQuery();

                Console.WriteLine("Cadastro atualizado com sucesso!");


                txb_nome.Text = "";
                cmb_setor.Text = "";
                txb_senha.Text = "";
                cod_colab.Text = "";
                cmb_cargo.Text = "";
                cmb_turno.Text = "";

                this.Close();
            }

        }
        private void button_excluir_Click(object sender, EventArgs e)
        {

            int id_usuario = int.Parse(cod_colab.Text);

            string status_usuario = "";
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
            {
                connection4.Open();

                // Cria um comando SQL para selecionar o nome do cliente
                MySqlCommand command4 = new MySqlCommand("SELECT Status_Usuario FROM usuario where ID = @id_usuario", connection4);

                // Adiciona o parâmetro @id_cliente à consulta SQL
                command4.Parameters.AddWithValue("@id_usuario", id_usuario);

                // Executa a consulta SQL e obtém o DataReader
                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Lê a próxima linha
                        reader4.Read();

                        // Obtém o valor da coluna nome
                        status_usuario = reader4["Status_Usuario"].ToString();
                    }
                }
                connection4.Close();

            }
            if (status_usuario == "1")
            {
                MessageBox.Show("Usuario já Excluído!");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdate = "UPDATE usuario SET Status_Usuario = 1 WHERE ID = @ID";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);

                commandUpdate.Parameters.AddWithValue("@ID", id_usuario);
                commandUpdate.ExecuteNonQuery();

                Console.WriteLine("Usuario excluuido com sucesso!");


                txb_nome.Text = "";
                cmb_setor.Text = "";
                txb_senha.Text = "";
                cod_colab.Text = "";
                cmb_cargo.Text = "";
                cmb_turno.Text = "";

                this.Close();

            }
        }

        private void btn_ativar_Click(object sender, EventArgs e)
        {
            int id_usuario = int.Parse(cod_colab.Text);
            string status_usuario = "";
            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

            using (MySqlConnection connection4 = new MySqlConnection(connectionString))
            {
                connection4.Open();

                // Cria um comando SQL para selecionar o nome do cliente
                MySqlCommand command4 = new MySqlCommand("SELECT Status_Usuario FROM usuario where ID = @id_usuario", connection4);

                // Adiciona o parâmetro @id_cliente à consulta SQL
                command4.Parameters.AddWithValue("@id_usuario", id_usuario);

                // Executa a consulta SQL e obtém o DataReader
                using (MySqlDataReader reader4 = command4.ExecuteReader())
                {
                    if (reader4.HasRows)
                    {
                        // Lê a próxima linha
                        reader4.Read();

                        // Obtém o valor da coluna nome
                        status_usuario = reader4["Status_Usuario"].ToString();
                    }
                }
                connection4.Close();

            }
            if(status_usuario == "0")
            {
                MessageBox.Show("Usuario já Ativo!");
                return;
            }
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string queryUpdate = "UPDATE usuario SET Status_Usuario = 0 WHERE ID = @ID";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);

                commandUpdate.Parameters.AddWithValue("@ID", id_usuario);
                commandUpdate.ExecuteNonQuery();

                Console.WriteLine("Usuario ativado com sucesso!");


                txb_nome.Text = "";
                cmb_setor.Text = "";
                txb_senha.Text = "";
                cod_colab.Text = "";
                cmb_cargo.Text = "";
                cmb_turno.Text = "";

                this.Close();

            }

        }
    }
}
