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
    public partial class Frm_Menu : Form
    {
        public Frm_Menu()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_CadastroUsuario form = new Frm_CadastroUsuario();
            form.Show();
        }
    }
}
