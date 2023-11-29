using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Func_Linhas : Form
    {
        private string id_usuario;
        public string Id_Usuario
        {
            set { id_usuario = value; }
        }
        public Func_Linhas()
        {
            InitializeComponent();
        }

        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(formulario);
            formulario.Show();
        }

        private void Func_Linhas_Load(object sender, EventArgs e)
        {
            Frm_Listar_Linhas form3 = new Frm_Listar_Linhas();
            MostrarFormulario(form3);
            panel3.BackColor = Color.Honeydew;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_Cadastrar_Linha form3 = new Frm_Cadastrar_Linha();
            MostrarFormulario(form3);
            panel3.BackColor = Color.WhiteSmoke;
            panel2.BackColor = Color.Honeydew;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_Listar_Linhas form3 = new Frm_Listar_Linhas();
            MostrarFormulario(form3);
            panel3.BackColor = Color.Honeydew;
            panel2.BackColor = Color.WhiteSmoke;
        }

    }
}
