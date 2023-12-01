using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Microsoft.ReportingServices;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;

namespace TopIndicators
{
    public partial class usuario_relatorio : Form
    {
        DataTable dt = new DataTable();
        public usuario_relatorio(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void usuario_relatorio_Load(object sender, EventArgs e)
        {

            
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new
                    Microsoft.Reporting.WinForms.ReportDataSource("Colaboradores", dt));
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
