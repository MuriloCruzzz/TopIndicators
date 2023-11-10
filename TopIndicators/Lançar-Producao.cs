using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopIndicators
{
    public partial class Form1 : Form
    {
        private int idLinha;
        private SqlConnection connection;
        private Timer timer;
        public Form1()
        {
            InitializeComponent();
        }
        public int id_producao { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            int id_producao = this.id_producao;


        }
    }
}
