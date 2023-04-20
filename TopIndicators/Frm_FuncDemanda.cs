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
    public partial class Frm_FuncDemanda : Form
    {
        public Frm_FuncDemanda()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_CadastrarDemanda form = new Frm_CadastrarDemanda();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_ListarDemanda form = new Frm_ListarDemanda();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_DeletarDemanda form = new Frm_DeletarDemanda();
            form.Show();
        }
    }
}
