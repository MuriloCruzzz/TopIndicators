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
    public partial class Panel_c_1 : Form
    {
        public Panel_c_1()
        {
            InitializeComponent();
        }

        private void MostrarFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;
            panel_2.Controls.Clear();
            panel_2.Controls.Add(formulario);
            formulario.Show();
        }


        private void Frm_FuncLancar_Load(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            MostrarFormulario(form);
            //panel1.BackColor = Color.WhiteSmoke;
            //panel2.BackColor = Color.Honeydew;

        }
    }
}
