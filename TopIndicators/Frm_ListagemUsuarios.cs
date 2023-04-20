using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using ListagemUsuarios;
using DadosUsuarios;
using Connection;

namespace TopIndicators
{
    public partial class Frm_ListagemUsuarios : Form
    {
        public Frm_ListagemUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Frm_ListagemUsuarios_Load(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario();
            //Connection.ProcessoDados lerUsuario = new Connection.ProcessoDados();

            //lerUsuario.LerUsuarios(usuario);
            ListagemUsuarios.ListaDeUsuarios lerUsuarios = new ListagemUsuarios.ListaDeUsuarios();
            lerUsuarios.LerUsuarios(listView1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
