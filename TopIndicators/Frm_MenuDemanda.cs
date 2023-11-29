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
    public partial class Frm_MenuDemanda : Form
    {
        private string id_usuario;
        public string Id_Usuario
        {
            set { id_usuario = value; }
        }

        public Frm_MenuDemanda()
        {
            InitializeComponent();
        }

        private void Lbl_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();
        }

        private void btn_demanda_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.DarkGray;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.Transparent;

            Func_Demanda form1 = new Func_Demanda();
            form1.Id_Usuario = id_usuario;
            MostrarFormulario(form1);

        }

        private void btn_cadastro_usuarios_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.DarkGray;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.Transparent;

            Frm_FuncUsuarios form1 = new Frm_FuncUsuarios();
            form1.Id_Usuario = id_usuario;
            MostrarFormulario(form1);
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_principal.Controls.Clear();
            panel_principal.Controls.Add(formulario);
            formulario.Show();
        }

        private void btn_turnos_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.DarkGray;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.Transparent;

            Func_Turnos form1 = new Func_Turnos();
            MostrarFormulario(form1);
        }

        private void btn_lancar_prod_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.DarkGray;
            Btn_Linha.BackColor = Color.Transparent;

            Func_Produção form1 = new Func_Produção();
            form1.Id_Usuario = id_usuario;
            MostrarFormulario(form1);
        }

        private void btn_estoque_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.DarkGray;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.Transparent;

            Func_Estoque form1 = new Func_Estoque();
            MostrarFormulario(form1);
        }

        private void Btn_Produção_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.DarkGray;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.Transparent;

            Func_Graficos form1 = new Func_Graficos();
            MostrarFormulario(form1);
        }
        private void Btn_Linha_Click(object sender, EventArgs e)
        {
            btn_cadastro_usuarios.BackColor = Color.Transparent;
            btn_demanda.BackColor = Color.Transparent;
            btn_turnos.BackColor = Color.Transparent;
            Btn_Produção.BackColor = Color.Transparent;
            btn_estoque.BackColor = Color.Transparent;
            btn_lancar_prod.BackColor = Color.Transparent;
            Btn_Linha.BackColor = Color.DarkGray;

            Func_Linhas form1 = new Func_Linhas();
            form1.Id_Usuario = id_usuario;
            MostrarFormulario(form1);


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

        private void Frm_MenuDemanda_Load(object sender, EventArgs e)
        {
            string turno = "0";
            string grup_acesso = "0";

            string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {

                connection.Open();

                string query = "SELECT Grupo_Acesso, turno FROM usuario WHERE ID = @ID";
                MySqlCommand command = new MySqlCommand(query, connection);

                command.Parameters.AddWithValue("@ID", id_usuario);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        // Itere sobre os resultados da consulta
                        while (reader.Read())
                        {
                            // Pegue os valores dos campos da consulta
                            grup_acesso = reader["Grupo_Acesso"].ToString();//
                            turno = reader["turno"].ToString();//
                        }
                    }
                }

                connection.Close();

                if(grup_acesso == "Lider")
                {
                    Btn_Produção.Enabled = false;
                    btn_cadastro_usuarios.Enabled = false;
                    btn_turnos.Enabled = false;

                }
                if(grup_acesso == "Operador")
                {
                    Btn_Produção.Enabled = false;
                    btn_cadastro_usuarios.Enabled = false;
                    btn_turnos.Enabled = false;
                    btn_demanda.Enabled = false;
                    btn_estoque.Enabled = false;
                    Btn_Linha.Enabled = false;
                }

            }
        }
    }
}
