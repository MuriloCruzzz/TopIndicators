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
        public Func_Demanda()
        {
            InitializeComponent();
        }

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
            MostrarFormulario(form3);
            panel1.BackColor = Color.WhiteSmoke;
            panel1.BackColor = Color.Honeydew;
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
