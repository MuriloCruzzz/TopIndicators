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

namespace TopIndicators
{
    public partial class Func_Demanda : Form
    {
        private string id_usuario;
        public string Id_Usuario
        {
            set { id_usuario = value; }
        }
        public Func_Demanda()
        {
            InitializeComponent();

        }
        string connectionString = "Server=127.0.0.1;Database=topindicators;Uid=root;Pwd=123456789;";

        private void button3_Click(object sender, EventArgs e)
        {
            //Frm_CadastroUsuario form = new Frm_CadastroUsuario();
            //form.Show();
            Frm_CadastrarDemanda form3 = new Frm_CadastrarDemanda();
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.Honeydew;
        }
        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel3.Controls.Clear();
            panel3.Controls.Add(formulario);
            formulario.Show();
        }

        private void Func_Demanda_Load(object sender, EventArgs e)
        {
            Frm_ListarDemanda form3 = new Frm_ListarDemanda();
            form3.Id_Usuario = id_usuario;
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.Honeydew;

            string cargo = "";
            MySqlConnection connectionb = new MySqlConnection(connectionString);
            connectionb.Open();

            // Execute a consulta
            string queryb = "SELECT Grupo_Acesso FROM usuario where ID = @ID";
            MySqlCommand commandb = new MySqlCommand(queryb, connectionb);
            commandb.Parameters.AddWithValue("@ID", id_usuario);

            using (MySqlDataReader readerb = commandb.ExecuteReader())
            {
                if (readerb.HasRows)
                {
                    // Itere sobre os resultados da consulta
                    while (readerb.Read())
                    {
                        // Pegue os valores dos campos da consulta
                        cargo = readerb["Grupo_Acesso"].ToString();//
                    }
                }
                connectionb.Close();
            }
            if (cargo == "Lider")
            {
                button3.Enabled = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_ListarDemanda form3 = new Frm_ListarDemanda();
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.Honeydew;
        }
    }
}
