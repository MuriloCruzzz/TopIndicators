using DadosDemanda;
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

namespace TopIndicators
{
    public partial class Frm_DeletarDemanda : Form
    {
        public Frm_DeletarDemanda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int valorInteiro = 0;

            valorInteiro = int.Parse(Txt_idDemanda.Text);

            Demanda demanda = new Demanda();

            demanda.Id = valorInteiro;

            Txt_idDemanda.Text = Txt_idDemanda.Text = "";

            Connection.ProcessoDados criarUsuario = new Connection.ProcessoDados();
            criarUsuario.DeletarDemanda(demanda);

            MessageBox.Show("Demanda Cancelada Com Sucesso!!!");
        }
    }
}
