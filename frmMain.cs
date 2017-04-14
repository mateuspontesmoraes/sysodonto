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
    public partial class frmMain : Form
    {
        
        public frmMain()
        {
            InitializeComponent();            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            Application.Exit();
        }

        private void consultarPaciêntesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmPesquisa();
            frm.ShowDialog(this);
        }

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmCadPaciente();
            frm.ShowDialog(this);
        }

        private void relatórioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new frmReport();
            frm.ShowDialog(this);
        }
    }
}
