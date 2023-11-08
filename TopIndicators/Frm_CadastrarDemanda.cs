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
    public partial class Frm_CadastrarDemanda : Form
    {
        public Frm_CadastrarDemanda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Demanda demanda = new Demanda();
            Connection.ProcessoDados LerUsuario = new Connection.ProcessoDados();


            demanda.Id++;
            demanda.Prazo = DateTime.Parse(Txt_Prazo.Text);
            demanda.Status = "Em Aberto";
            demanda.Id_Cliente = int.Parse(Txt_Id_Cliente.Text);
            demanda.quantidade_Demandada = int.Parse(Txt_quantidade.Text); 
            demanda.Id_Produto = int.Parse(Txt_Id_Produto.Text);
            demanda.Id_Usuario = int.Parse(Txt_Id_Usuario.Text);

            if (demanda.Id_Usuario > 0)
            {
                LerUsuario.LerUsuarios(demanda);

                if(demanda.Id_Usuario == 0) 
                {
                    MessageBox.Show("Usuario não encontrado");
                    Txt_quantidade.Text = "";
                    Txt_Prazo.Text = "";
                    Txt_Id_Cliente.Text = "";
                    Txt_Id_Produto.Text = "";
                    Txt_Id_Usuario.Text = "";
                    Txt_quantidade.Focus();
                    return;
                }


            }
            Connection.ProcessoDados criarDemanda = new Connection.ProcessoDados();
            criarDemanda.CriarDemanda(demanda);
            Txt_quantidade.Text = "";
            Txt_Prazo.Text = "";
            Txt_Id_Cliente.Text = "";
            Txt_Id_Produto.Text = "";
            Txt_Id_Usuario.Text = "";
            MessageBox.Show("Demanda Cadastrada Com Sucesso!!!");

        }
    }
}
