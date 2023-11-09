using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.IO;
using ExcelDataReader;
using DadosUsuarios;

namespace TopIndicators
{
    public partial class Frm_Cadastrar_Linha : Form
    {

        public Frm_Cadastrar_Linha()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Connection.ProcessoDados InserirCliente = new Connection.ProcessoDados();

            _ = new ConnectionMaria.ProcessoDadosUsuarios();

            InserirCliente.InserirTabelaClientes();

            MessageBox.Show("Clientes Inseridos Com Sucesso!!!");

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Cadastrar_Linha_Load(object sender, EventArgs e)
        {

        }
    }
}
