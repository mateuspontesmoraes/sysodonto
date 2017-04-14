namespace SysOdonto
{
    partial class frmCadPaciente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.edtUf = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.edtCep = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtCidade = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.edtBairro = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtNacimento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.ckAtivo = new System.Windows.Forms.CheckBox();
            this.edtTelefone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.edtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtCodigo.Location = new System.Drawing.Point(62, 10);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.ReadOnly = true;
            this.edtCodigo.Size = new System.Drawing.Size(100, 20);
            this.edtCodigo.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.edtTelefone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.ckAtivo);
            this.groupBox1.Controls.Add(this.dtNacimento);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.edtUf);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.edtCep);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.edtCidade);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.edtBairro);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.edtNumero);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.edtEndereco);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.edtNome);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(16, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 227);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Dados do Paciente ";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(409, 196);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(96, 23);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // edtUf
            // 
            this.edtUf.BackColor = System.Drawing.Color.White;
            this.edtUf.Location = new System.Drawing.Point(359, 170);
            this.edtUf.MaxLength = 2;
            this.edtUf.Name = "edtUf";
            this.edtUf.Size = new System.Drawing.Size(146, 20);
            this.edtUf.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(356, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "UF";
            // 
            // edtCep
            // 
            this.edtCep.BackColor = System.Drawing.Color.White;
            this.edtCep.Location = new System.Drawing.Point(199, 170);
            this.edtCep.Name = "edtCep";
            this.edtCep.Size = new System.Drawing.Size(154, 20);
            this.edtCep.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cep:";
            // 
            // edtCidade
            // 
            this.edtCidade.BackColor = System.Drawing.Color.White;
            this.edtCidade.Location = new System.Drawing.Point(19, 170);
            this.edtCidade.Name = "edtCidade";
            this.edtCidade.Size = new System.Drawing.Size(171, 20);
            this.edtCidade.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cidade:";
            // 
            // edtBairro
            // 
            this.edtBairro.BackColor = System.Drawing.Color.White;
            this.edtBairro.Location = new System.Drawing.Point(359, 126);
            this.edtBairro.Name = "edtBairro";
            this.edtBairro.Size = new System.Drawing.Size(146, 20);
            this.edtBairro.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(356, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Bairro:";
            // 
            // edtNumero
            // 
            this.edtNumero.BackColor = System.Drawing.Color.White;
            this.edtNumero.Location = new System.Drawing.Point(199, 126);
            this.edtNumero.Name = "edtNumero";
            this.edtNumero.Size = new System.Drawing.Size(154, 20);
            this.edtNumero.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Número:";
            // 
            // edtEndereco
            // 
            this.edtEndereco.BackColor = System.Drawing.Color.White;
            this.edtEndereco.Location = new System.Drawing.Point(19, 126);
            this.edtEndereco.Name = "edtEndereco";
            this.edtEndereco.Size = new System.Drawing.Size(171, 20);
            this.edtEndereco.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço:";
            // 
            // edtNome
            // 
            this.edtNome.BackColor = System.Drawing.Color.White;
            this.edtNome.Location = new System.Drawing.Point(19, 41);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(486, 20);
            this.edtNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome:";
            // 
            // dtNacimento
            // 
            this.dtNacimento.CustomFormat = "dd/MM/yyyy";
            this.dtNacimento.Location = new System.Drawing.Point(19, 80);
            this.dtNacimento.Name = "dtNacimento";
            this.dtNacimento.Size = new System.Drawing.Size(171, 20);
            this.dtNacimento.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 64);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Data Nascimento:";
            // 
            // ckAtivo
            // 
            this.ckAtivo.AutoSize = true;
            this.ckAtivo.Location = new System.Drawing.Point(455, 80);
            this.ckAtivo.Name = "ckAtivo";
            this.ckAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckAtivo.TabIndex = 20;
            this.ckAtivo.Text = "Ativo";
            this.ckAtivo.UseVisualStyleBackColor = true;
            // 
            // edtTelefone
            // 
            this.edtTelefone.BackColor = System.Drawing.Color.White;
            this.edtTelefone.Location = new System.Drawing.Point(199, 80);
            this.edtTelefone.Name = "edtTelefone";
            this.edtTelefone.Size = new System.Drawing.Size(154, 20);
            this.edtTelefone.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Telefone:";
            // 
            // frmCadPaciente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(546, 289);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.edtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCadPaciente";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Paciente";
            this.Load += new System.EventHandler(this.frmCadPaciente_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtBairro;
        private System.Windows.Forms.TextBox edtUf;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtCep;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtCidade;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DateTimePicker dtNacimento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckAtivo;
        private System.Windows.Forms.TextBox edtTelefone;
        private System.Windows.Forms.Label label10;
    }
}