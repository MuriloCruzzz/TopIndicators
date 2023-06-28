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
    public partial class Frm_ListarDemanda : Form
    {
        public Frm_ListarDemanda()
        {
            InitializeComponent();
        }

        public void Frm_ListarDemanda_Load(object sender, EventArgs e)
        {
            //Usuario usuario = new Usuario();
            //Connection.ProcessoDados lerUsuario = new Connection.ProcessoDados();

            //lerUsuario.LerUsuarios(usuario);
            ListagemDemanda.ListarDemanda lerUsuarios = new ListagemDemanda.ListarDemanda();
            lerUsuarios.LerDemanda(listView2);
        }
    }
}
