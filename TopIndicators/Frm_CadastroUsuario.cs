﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.Animation;
using static TopIndicators.Frm_CadastroUsuario.ChecaForcaSenha;
using DadosUsuarios;
using static TopIndicators.Segurança;
using Connection;

using ConnectionMaria;
using crypto;
//>>>>>>> b5d070ecba66bd63fff6f2926b82ec99ac503113

namespace TopIndicators
{
    public partial class Frm_CadastroUsuario : Form
    {
        bool VerSenha = false;

        public Frm_CadastroUsuario()
        {
            InitializeComponent();
        }
        private void Btn_Reset_Click(object sender, EventArgs e)
        {
            Txt_Senha.Text = " ";
            Lbl_Resultado.Text = " ";
        }

        private void Txt_Senha_KeyDown(object sender, KeyEventArgs e)
        {
            ChecaForcaSenha Verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = Verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();
        }


        public class ChecaForcaSenha
        {
            public enum ForcaDaSenha
            {
                Inaceitavel,
                Fraca,
                Aceitavel,
                Forte,
                Segura
            }

            public int geraPontosSenha(string senha)
            {
                if (senha == null) return 0;
                int pontosPorTamanho = GetPontoPorTamanho(senha);
                int pontosPorMinusculas = GetPontoPorMinusculas(senha);
                int pontosPorMaiusculas = GetPontoPorMaiusculas(senha);
                int pontosPorDigitos = GetPontoPorDigitos(senha);
                int pontosPorSimbolos = GetPontoPorSimbolos(senha);
                int pontosPorRepeticao = GetPontoPorRepeticao(senha);
                return pontosPorTamanho + pontosPorMinusculas + pontosPorMaiusculas + pontosPorDigitos + pontosPorSimbolos - pontosPorRepeticao;
            }

            private int GetPontoPorTamanho(string senha)
            {
                return Math.Min(10, senha.Length) * 6;
            }

            private int GetPontoPorMinusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[a-z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorMaiusculas(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[A-Z]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorDigitos(string senha)
            {
                int rawplacar = senha.Length - Regex.Replace(senha, "[0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorSimbolos(string senha)
            {
                int rawplacar = Regex.Replace(senha, "[a-zA-Z0-9]", "").Length;
                return Math.Min(2, rawplacar) * 5;
            }

            private int GetPontoPorRepeticao(string senha)
            {
                System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"(\w)*.*\1");
                bool repete = regex.IsMatch(senha);
                if (repete)
                {
                    return 30;
                }
                else
                {
                    return 0;
                }
            }


            public ForcaDaSenha GetForcaDaSenha(string senha)
            {
                int placar = geraPontosSenha(senha);

                if (placar < 50)
                    return ForcaDaSenha.Inaceitavel;
                else if (placar < 60)
                    return ForcaDaSenha.Fraca;
                else if (placar < 80)
                    return ForcaDaSenha.Aceitavel;
                else if (placar < 100)
                    return ForcaDaSenha.Forte;
                else
                    return ForcaDaSenha.Segura;
            }
        }

        private void Txt_Senha_TextChanged(object sender, EventArgs e)
        {
            ChecaForcaSenha Verifica = new ChecaForcaSenha();
            ChecaForcaSenha.ForcaDaSenha forca;
            forca = Verifica.GetForcaDaSenha(Txt_Senha.Text);
            Lbl_Resultado.Text = forca.ToString();

            if (Lbl_Resultado.Text == "Inaceitavel" | Lbl_Resultado.Text == "Fraca")
            {
                Lbl_Resultado.ForeColor= Color.Red;
            }
            else if (Lbl_Resultado.Text == "Aceitavel")
            {
                Lbl_Resultado.ForeColor = Color.Yellow;
            }
            else if (Lbl_Resultado.Text == "Forte")
            {
                Lbl_Resultado.ForeColor = Color.Green;
            }
            else if (Lbl_Resultado.Text == "Segura")
            {
                Lbl_Resultado.ForeColor = Color.DarkGreen;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_OlharSenha_Click(object sender, EventArgs e)
        {
            if (VerSenha == false)
            {
                Txt_ConfirmacaoSenha.PasswordChar = '\0';
                Txt_Senha.PasswordChar= '\0';
                VerSenha = true;

            }
            else
            {
                Txt_ConfirmacaoSenha.PasswordChar = '*';
                Txt_Senha.PasswordChar = '*';
                VerSenha = false;

            }
        }

        private void Btn_CadastrarNovoUsuario_Click(object sender, EventArgs e)
        {
            if (Txt_ConfirmacaoSenha.Text != Txt_Senha.Text)
            {
                MessageBox.Show("Senhas Não Conferem");
                Txt_ConfirmacaoSenha.Text = Txt_ConfirmacaoSenha.Text = "";
                Txt_Senha.Text = Txt_Senha.Text = "";
                Txt_Senha.Focus();
                return;
            }
            if (Lbl_Resultado.Text == "Inaceitavel")
            {
                MessageBox.Show("Senha Inaceitavel \n Entre com Uma Senha Valida");
                Txt_ConfirmacaoSenha.Text = Txt_ConfirmacaoSenha.Text = "";
                Txt_Senha.Text = Txt_Senha.Text = "";
                Txt_Senha.Focus();
                return;
            }

            else if (Txt_NomeUsuario.Text == "" || Txt_NomeUsuario.Text == " ")
            {
                MessageBox.Show("Campo Nome Em Branco");
                Txt_NomeUsuario.Text = Txt_NomeUsuario.Text = "";
                Txt_Senha.Text = Txt_Senha.Text = "";
                Txt_ConfirmacaoSenha.Text = Txt_ConfirmacaoSenha.Text = "";
                Txt_NomeUsuario.Focus();
                return;
            }
            else if (Txt_NomeSetor2.Text == "" || Txt_NomeSetor2.Text == " ")
            {
                MessageBox.Show("Campo Setor Em Branco");
                Txt_NomeSetor2.Text = Txt_NomeSetor2.Text = "";
                Txt_ConfirmacaoSenha.Text = Txt_ConfirmacaoSenha.Text = "";
                Txt_Senha.Text = Txt_Senha.Text = "";
                Txt_Senha.Text = Txt_Senha.Text = "";
                Txt_NomeSetor2.Focus();
                return;
            }
            else
            {
                Usuario usuario = new Usuario(Segurança.Hash_login(Txt_Senha.Text));

                usuario.Id++;
                usuario.Nome = Txt_NomeUsuario.Text;
                usuario.Setor = Txt_NomeSetor2.Text;
                usuario.Senha = Txt_Senha.Text;
                usuario.Status_Usuario = 0;
                usuario.Turno_Usuario = cmb_turno.Text;
                usuario.Grupo_Acesso = comboBox1.Text;

                Txt_NomeSetor2.Text = "";
                Txt_ConfirmacaoSenha.Text = "";
                Txt_Senha.Text = "";
                Txt_NomeUsuario.Text = "";
                textBox1.Text = "";
                Lbl_Resultado.Text = "";
                comboBox1.Text = "";
                cmb_turno.Text = "";


                Connection.ProcessoDados criarUsuario = new Connection.ProcessoDados();

                _ = new ConnectionMaria.ProcessoDadosUsuarios();

                criarUsuario.CriarUsuario(usuario);

                MessageBox.Show("Usuario Cadastrado Com Sucesso!!!");

            }
        }

        private void Txt_NomeUsuario_TextChanged(object sender, EventArgs e)
        {
            //Txt_NomeUsuario.Text 
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txb_estado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txb_cidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txb_bairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_endereco_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frm_CadastroUsuario_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

