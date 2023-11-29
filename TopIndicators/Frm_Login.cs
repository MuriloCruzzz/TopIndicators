using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }
        bool VerSenha = false;
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int Hora = DateTime.Now.Hour;

            if (Hora >= 6 && Hora < 12)
            {
                Lbl_Saudacoes.Text = "Bom Dia!";
            }
            else if (Hora >= 12 && Hora < 18)
            {
                Lbl_Saudacoes.Text = "Boa Tarde!";
            }
            else
            {
                Lbl_Saudacoes.Text = "Boa Noite!";
            }
        }
        private void Llbl_LinkSuporte_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível abrir o link que foi clicado.");
            }
        }
        private void VisitLink()
        {
            Llbl_LinkSuporte.LinkVisited = true;
            System.Diagnostics.Process.Start("https://contate.me/supportetopindicators");
        }
        private void Btn_Login_Click(object sender, EventArgs e)
        {
            string nome = Txb_NomeLogin.Text;
            string id_usuario = "0";
            string senha = Txb_SenhaLogin.Text;
            string nome_valido = "login";
            string senha_valido = "login";
            if (Txb_NomeLogin.Text == "" || Txb_SenhaLogin.Text == "")
            {
                MessageBox.Show("Preenchimento incorreto! \n Preencha Novamente!");
                Txb_NomeLogin.Text = Txb_NomeLogin.Text = "";
                Txb_NomeLogin.Text = Txb_SenhaLogin.Text = "";
                Txb_NomeLogin.Focus();
                return;
            }
            if (Txb_NomeLogin.Text == " " || Txb_SenhaLogin.Text == " ")
            {
                MessageBox.Show("Preenchimento incorreto! \n Preencha Novamente!");
                Txb_NomeLogin.Text = Txb_NomeLogin.Text = "";
                Txb_NomeLogin.Text = Txb_SenhaLogin.Text = "";
                Txb_NomeLogin.Focus();
                return;
            }
            else if (Txb_NomeLogin.Text != "" || Txb_SenhaLogin.Text != "")
            {
                string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

                MySqlConnection connectionb = new MySqlConnection(connectionString);
                connectionb.Open();

                // Execute a consulta
                string queryb = "SELECT ID, nome FROM usuario where nome = @nome";
                MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
                commandb.Parameters.AddWithValue("@nome", nome);

                using (MySqlDataReader readerb = commandb.ExecuteReader())
                {
                    if (readerb.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (readerb.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            id_usuario = readerb["ID"].ToString();//
                            nome_valido = readerb["nome"].ToString();//
                        }
                    }
                    else
                    {

                        Txb_NomeLogin.Text = Txb_NomeLogin.Text = "";
                        Txb_SenhaLogin.Text = Txb_SenhaLogin.Text = "";
                        Txb_NomeLogin.Focus();

                        MessageBox.Show("Nenhum usuario com esse nome entre novamente \n caso esqueceu seu Login ... contate seu Supervidor!.");
                        return;
                    }
                    connectionb.Close();
                }
                MySqlConnection connection = new MySqlConnection(connectionString);
                connection.Open();

                // Execute a consulta
                string query = "SELECT senha FROM usuario where senha = @senha";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@senha", senha);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (reader.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            senha_valido = reader["senha"].ToString();//
                        }
                    }
                    else
                    {

                        Txb_SenhaLogin.Text = Txb_SenhaLogin.Text = "";
                        Txb_SenhaLogin.Focus();

                        MessageBox.Show("Senha Incorreta entre novamente! \n  caso esqueceu a senha... contate seu Supervidor!.");
                        return;
                    }
                    connectionb.Close();
                }

            }

            if(senha == senha_valido && nome == nome_valido)
            {
                Frm_MenuDemanda frm = new Frm_MenuDemanda();
                frm.Id_Usuario = id_usuario;
                //frm.id_turno = id_turno.ToString; 
                frm.Show();

            }
        }
        private void Btn_OlharSenha_Click(object sender, EventArgs e)
        {
            if (VerSenha == false)
            {
                Txb_SenhaLogin.PasswordChar = '\0';
                VerSenha = true;
            }
            else
            {
                Txb_SenhaLogin.PasswordChar = '*';
                VerSenha = false;
            }
        }
        private void Btn_Parar_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
