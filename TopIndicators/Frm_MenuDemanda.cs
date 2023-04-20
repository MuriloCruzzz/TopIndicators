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
    public partial class Frm_MenuDemanda : Form
    {
        public Frm_MenuDemanda()
        {
            InitializeComponent();
        }

        private void Btn_Menu_Click(object sender, EventArgs e)
        {


        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Frm_FuncUsuarios form = new Frm_FuncUsuarios();
            form.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_FuncDemanda form = new Frm_FuncDemanda();
            form.Show();
        }
    }
}
