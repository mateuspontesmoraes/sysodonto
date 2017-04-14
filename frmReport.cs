using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysOdonto
{
    public partial class frmReport : Form
    {
        SYSODONTOEntities db;
        private ReportDataSource rds;

        public frmReport()
        {
            InitializeComponent();
            db = new SYSODONTOEntities();

          
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            var list = db.Pacientes.ToList();
            reportViewer1.LocalReport.DataSources.FirstOrDefault().Value = db.Pacientes.ToList();
            this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.Refresh();
        }
    }
}
