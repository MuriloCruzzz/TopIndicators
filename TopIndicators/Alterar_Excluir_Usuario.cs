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

        public Alterar_Excluir_Usuario()
        {
            InitializeComponent();
        }
        public string RegistroUsuario
        {
            set { registroUsuario = value; }
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


        private void Alterar_Excluir_Usuario_Load_1(object sender, EventArgs e)
        {
            cod_colab.Text = registroUsuario;
            txb_nome.Text = nomeUsuario;
            cmb_setor.Text = setorUsuario;
            txb_senha.Text = senhaUsuario;
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {

            txb_nome.Text = "";
            cmb_setor.Text = "";
            txb_senha.Text = "";

        }

        private void btn_salvar_Click(object sender, EventArgs e)
        {
            string NovoNome = txb_nome.Text;
            string NovoSetor = cmb_setor.Text;
            string NovaSenha = txb_senha.Text;
            int id_usuario = int.Parse(cod_colab.Text);

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string queryUpdate = "UPDATE usuario SET Nome = @Nome, Senha = @Senha, id_setor = @Setor WHERE ID = @ID";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);
                commandUpdate.Parameters.AddWithValue("@Nome", NovoNome);
                commandUpdate.Parameters.AddWithValue("@Senha", NovaSenha);
                commandUpdate.Parameters.AddWithValue("@Setor", NovoSetor);
                commandUpdate.Parameters.AddWithValue("@ID", id_usuario);
                commandUpdate.ExecuteNonQuery();

                Console.WriteLine("Cadastro atualizado com sucesso!");


                txb_nome.Text = "";
                cmb_setor.Text = "";
                txb_senha.Text = "";
                cod_colab.Text = "";

                this.Close();

            }

        }

        private void button_excluir_Click(object sender, EventArgs e)
        {

            int id_usuario = int.Parse(cod_colab.Text);

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();


                string queryUpdate = "UPDATE usuario SET Grupo_Acesso = 1 WHERE ID = @ID";
                MySqlCommand commandUpdate = new MySqlCommand(queryUpdate, connection);

                commandUpdate.Parameters.AddWithValue("@ID", id_usuario);
                commandUpdate.ExecuteNonQuery();

                Console.WriteLine("Usuario excluuido com sucesso!");


                txb_nome.Text = "";
                cmb_setor.Text = "";
                txb_senha.Text = "";
                cod_colab.Text = "";

                this.Close();

            }
        }
    }
}
