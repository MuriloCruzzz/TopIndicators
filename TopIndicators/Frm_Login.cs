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

            if (Txb_NomeLogin.Text == "" || Txb_SenhaLogin.Text == "")
            {
                MessageBox.Show("Preenchimento incorreto! \n Preencha Novamente!");
                Txb_NomeLogin.Text = Txb_NomeLogin.Text = "";
                Txb_NomeLogin.Text = Txb_SenhaLogin.Text = "";
                Txb_NomeLogin.Focus();
                return;
            }
            else if (Txb_NomeLogin.Text != "admin" && Txb_NomeLogin.Text != "admin")
            {
                MessageBox.Show("Usuario ou Senha Incorreto!");
                Txb_NomeLogin.Text = Txb_NomeLogin.Text = "";
                Txb_NomeLogin.Text = Txb_SenhaLogin.Text = "";
                Txb_NomeLogin.Focus();
                return;
            }

            else
            {
                Frm_MenuDemanda form = new Frm_MenuDemanda();
                this.Hide();
                form.Show();
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
    }
}
