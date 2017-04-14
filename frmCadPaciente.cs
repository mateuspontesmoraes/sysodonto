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
    public partial class frmCadPaciente : Form
    {
        SYSODONTOEntities db;

        public frmCadPaciente()
        {
            InitializeComponent();

            db = new SYSODONTOEntities();
            dtNacimento.Format = DateTimePickerFormat.Custom;
            dtNacimento.CustomFormat = "dd/MM/yyyy";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var novo = edtCodigo.Text == "";

            Paciente paciente;

            if (novo)
                paciente = new Paciente();
            else
            {
                var _cd = int.Parse(edtCodigo.Text);
                paciente = db.Pacientes.FirstOrDefault(x => x.Codigo == _cd);
            }

            paciente.Bairro = edtBairro.Text;
            paciente.Cep = edtCep.Text;
            paciente.Cidade = edtCidade.Text;
            paciente.Endereco = edtEndereco.Text;
            paciente.Nome = edtNome.Text;
            paciente.Numero = edtNumero.Text;
            paciente.UF = edtUf.Text;
            paciente.Ativo = ckAtivo.Checked;
            paciente.DataNascimento = dtNacimento.Value;
            paciente.Telefone = edtTelefone.Text;

            if (novo)
                db.Pacientes.Add(paciente);
            else
                db.Entry(paciente).State = System.Data.Entity.EntityState.Modified;

            db.SaveChanges();

            edtCodigo.Text = paciente.Codigo.ToString();

            MessageBox.Show("Paciente atualizado com sucesso!");
        }

        private void frmCadPaciente_Load(object sender, EventArgs e)
        {
            this.ActiveControl = edtNome;
        }

        internal void setCodigo(object codigo)
        {
            edtCodigo.Text = codigo.ToString();

            var _cd = int.Parse(edtCodigo.Text);
            var paciente = db.Pacientes.FirstOrDefault(x => x.Codigo == _cd);

            edtBairro.Text = paciente.Bairro;
            edtCep.Text = paciente.Cep;
            edtCidade.Text = paciente.Cidade;
            edtEndereco.Text = paciente.Endereco;
            edtNome.Text = paciente.Nome;
            edtNumero.Text = paciente.Numero;
            edtUf.Text = paciente.UF;
            ckAtivo.Checked = paciente.Ativo.Value;
            dtNacimento.Value = paciente.DataNascimento.Value;
            edtTelefone.Text = paciente.Telefone;
        }
    }
}
