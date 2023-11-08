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
    public partial class Func_Turnos : Form
    {
        public Func_Turnos()
        {
            InitializeComponent();
        }

        private void Func_Turnos_Load(object sender, EventArgs e)
        {
            Frm_Listar_Turno frm1 = new Frm_Listar_Turno();
            MostrarFormulario(frm1);

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
    }
}
