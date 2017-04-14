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
    public partial class frmPesquisa : Form
    {
        SYSODONTOEntities db;

        public frmPesquisa()
        {
            InitializeComponent();
            db = new SYSODONTOEntities();
        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            var query = db.Pacientes.Where(x => x.Codigo > 0);

            if (edtCodigo.Text != "")
            {
                var cd = int.Parse(edtCodigo.Text);
                query = query.Where(x => x.Codigo == cd);
            }

            if (edtNome.Text != "")
                query = query.Where(x => x.Nome.Contains(edtNome.Text));

            var result = query.OrderBy(x => x.Nome).ToList();

            if (result.Count > 0)
            {
                dtResult.Rows.Clear();
                foreach (var row in result)
                {
                    var endereco = string.Format("{0} {1}, {2} - {3}", row.Endereco, row.Numero, row.Bairro, row.Cidade);
                    dtResult.Rows.Add(row.Codigo, row.Nome, endereco);
                }
            }
            else {
                MessageBox.Show("Nenhum resultado foi localizado");
            }
        }

        private void btnNovoCliente_Click(object sender, EventArgs e)
        {
            this.Close();
            var frm = new frmCadPaciente();
            frm.ShowDialog();
        }

        private void dtResult_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dtResult_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var codigo = dtResult.Rows[e.RowIndex].Cells[0].Value;

            this.Close();
            var frm = new frmCadPaciente();
            frm.setCodigo(codigo);
            frm.ShowDialog();
        }
    }
}
