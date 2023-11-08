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
using System.Text.RegularExpressions;
using System.Windows.Media.Animation;
using static TopIndicators.Frm_CadastroUsuario.ChecaForcaSenha;
//using DadosUsuarios;
using Connection;

namespace TopIndicators
{
    public partial class Frm_DeletarUsuario : Form
    {
        public Frm_DeletarUsuario()
        {
            InitializeComponent();
        }

        public void Btn_DeletarUsuario_Click(object sender, EventArgs e)
        {
            int valorInteiro = 0;

            valorInteiro = int.Parse(Txt_idUsuario.Text);

            //Usuario usuario = new Usuario();

            //usuario.Id = valorInteiro;

            Txt_idUsuario.Text = Txt_idUsuario.Text = "";

            Connection.ProcessoDados criarUsuario = new Connection.ProcessoDados();
            //criarUsuario.DeletarUsuario(usuario);

            MessageBox.Show("Usuario Cancelado Com Sucesso!!!");

            //Frm_DeletarUsuario form = new Frm_DeletarUsuario();
            //this.Hide();
            //Frm_DeletarUsuario.Close();

        }
    }
}
