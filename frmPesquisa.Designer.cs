namespace SysOdonto
{
    partial class frmPesquisa
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.edtCodigo = new System.Windows.Forms.TextBox();
            this.edtNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtResult = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sYSODONTOEntitiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnNovoCliente = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSODONTOEntitiesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // edtCodigo
            // 
            this.edtCodigo.BackColor = System.Drawing.Color.White;
            this.edtCodigo.Location = new System.Drawing.Point(61, 9);
            this.edtCodigo.Name = "edtCodigo";
            this.edtCodigo.Size = new System.Drawing.Size(84, 20);
            this.edtCodigo.TabIndex = 1;
            this.edtCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // edtNome
            // 
            this.edtNome.BackColor = System.Drawing.Color.White;
            this.edtNome.Location = new System.Drawing.Point(61, 35);
            this.edtNome.Name = "edtNome";
            this.edtNome.Size = new System.Drawing.Size(235, 20);
            this.edtNome.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(316, 33);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(75, 23);
            this.btnBusca.TabIndex = 4;
            this.btnBusca.Text = "Pesquisar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtResult);
            this.groupBox1.Location = new System.Drawing.Point(15, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Resultado da Busca ";
            // 
            // dtResult
            // 
            this.dtResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtResult.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNome,
            this.colEndereco});
            this.dtResult.Location = new System.Drawing.Point(6, 19);
            this.dtResult.Name = "dtResult";
            this.dtResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtResult.Size = new System.Drawing.Size(590, 125);
            this.dtResult.TabIndex = 0;
            this.dtResult.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtResult_CellDoubleClick);
            // 
            // colCodigo
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.colCodigo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            // 
            // colNome
            // 
            this.colNome.FillWeight = 150F;
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 150;
            // 
            // colEndereco
            // 
            this.colEndereco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colEndereco.HeaderText = "Endereço";
            this.colEndereco.Name = "colEndereco";
            this.colEndereco.ReadOnly = true;
            // 
            // sYSODONTOEntitiesBindingSource
            // 
            this.sYSODONTOEntitiesBindingSource.DataSource = typeof(SysOdonto.SYSODONTOEntities);
            // 
            // btnNovoCliente
            // 
            this.btnNovoCliente.Location = new System.Drawing.Point(467, 272);
            this.btnNovoCliente.Name = "btnNovoCliente";
            this.btnNovoCliente.Size = new System.Drawing.Size(150, 23);
            this.btnNovoCliente.TabIndex = 6;
            this.btnNovoCliente.Text = "Cadastrar Novo Paciente";
            this.btnNovoCliente.UseVisualStyleBackColor = true;
            this.btnNovoCliente.Click += new System.EventHandler(this.btnNovoCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(293, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "* de um duplo clique na linha para editar o registro";
            // 
            // frmPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(629, 307);
            this.Controls.Add(this.btnNovoCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.edtNome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.edtCodigo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmPesquisa";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busca de Pacientes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sYSODONTOEntitiesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtCodigo;
        private System.Windows.Forms.TextBox edtNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtResult;
        private System.Windows.Forms.BindingSource sYSODONTOEntitiesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEndereco;
        private System.Windows.Forms.Button btnNovoCliente;
        private System.Windows.Forms.Label label3;
    }
}