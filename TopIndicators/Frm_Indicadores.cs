using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Frm_Indicadores : Form
    {
        public Frm_Indicadores()
        {
            InitializeComponent();
        }

        private void btn_pendente_Click(object sender, EventArgs e)
        {
            btn_finalizada.BackColor = Color.Gainsboro;
            btn_iniciada.BackColor = Color.Gainsboro;
            btn_pendente.BackColor = Color.CadetBlue;

            label2.ForeColor = Color.CadetBlue;
        }

        private void btn_iniciada_Click(object sender, EventArgs e)
        {
            btn_finalizada.BackColor = Color.Gainsboro;
            btn_iniciada.BackColor = Color.Coral;
            btn_pendente.BackColor = Color.Gainsboro;

            label2.ForeColor = Color.Coral;
        }

        private void btn_finalizada_Click(object sender, EventArgs e)
        {
            btn_finalizada.BackColor = Color.Khaki;
            btn_iniciada.BackColor = Color.Gainsboro;
            btn_pendente.BackColor = Color.Gainsboro;


            label2.ForeColor = Color.Khaki;
        }

    }
}
