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
        public Frm_FuncUsuarios()
        {
            InitializeComponent();
        }

        private void Btn_NovoUsuario_Click(object sender, EventArgs e)
        {
            Frm_CadastroUsuario form = new Frm_CadastroUsuario();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            Frm_ListagemUsuarios form = new Frm_ListagemUsuarios();
            form.Show();
        }

        private void Btn_ExcluirUsuario_Click(object sender, EventArgs e)
        {
            Frm_DeletarUsuario form = new Frm_DeletarUsuario();
            form.Show();
        }
    }
}
