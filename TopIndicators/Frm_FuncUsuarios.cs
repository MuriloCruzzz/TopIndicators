using DadosUsuarios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ListagemUsuarios;
using DadosUsuarios;
using Connection;

namespace TopIndicators
{
    public partial class Frm_FuncUsuarios : Form
    {
        public string id_usuario;
        public string Id_Usuario
        {
            set { id_usuario = value; }
        }
        public Frm_FuncUsuarios()
        {
            InitializeComponent();
        }

        public void Btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            //Frm_CadastroUsuario form = new Frm_CadastroUsuario();
            //form.Show();
            Frm_CadastroUsuario form3 = new Frm_CadastroUsuario();
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel_c_1.BackColor = Color.Honeydew;
        }

        public void button4_Click(object sender, EventArgs e)
        {

            //Frm_ListagemUsuarios form = new Frm_ListagemUsuarios();
            //form.Show();
            panel1.BackColor = Color.Honeydew;
            panel_c_1.BackColor = Color.WhiteSmoke;
            Frm_1_usuario form3 = new Frm_1_usuario();
            MostrarFormulario(form3);
        }

        public void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_2.Controls.Clear();
            panel_2.Controls.Add(formulario);
            formulario.Show();
        }


        public void Frm_FuncUsuarios_Load(object sender, EventArgs e)
        {
            Frm_CadastroUsuario form3 = new Frm_CadastroUsuario();
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel_c_1.BackColor = Color.Honeydew;

        }

        public void Btn_NovoUsuario_MouseEnter(object sender, EventArgs e)
        {
            //Btn_NovoUsuario.BackColor = Color.FromArgb(255, 0, 0); // Mude a cor de fundo quando o mouse entrar
            //Btn_NovoUsuario.ForeColor = Color.White;
        }

        public void Btn_NovoUsuario_MouseLeave(object sender, EventArgs e)
        {
            //Btn_NovoUsuario.BackColor = Color.DarkSeaGreen; // Restaure a cor de fundo quando o mouse sair
            //Btn_NovoUsuario.ForeColor = Color.Black;
        }
    }
}
