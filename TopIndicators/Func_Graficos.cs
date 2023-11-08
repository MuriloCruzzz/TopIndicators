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
    public partial class Func_Graficos : Form
    {
        public Func_Graficos()
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

        private void Func_Graficos_Load(object sender, EventArgs e)
        {
            Frm_Indicadores form3 = new Frm_Indicadores();
            MostrarFormulario(form3);
        }
    }
}
