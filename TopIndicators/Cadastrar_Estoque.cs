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
    public partial class Cadastrar_Estoque : Form
    {
        public Cadastrar_Estoque()
        {
            InitializeComponent();
        }

        private void btn_importarMP_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMateriaPrima();

            MessageBox.Show("MATERIA PRIMA Inseridos Com Sucesso!!!");
        }

        private void btn_Importar_MT_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaMaterial();

            MessageBox.Show("COMPONENTES Inseridos Com Sucesso!!!");
        }
    }
}
