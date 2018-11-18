namespace Loja.VIEW
{
    partial class FrmC_ContaBancaria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmC_ContaBancaria));
            this.gbContaBancaria = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImpressao = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDataAtualizacao = new System.Windows.Forms.Label();
            this.lblDataCadastro = new System.Windows.Forms.Label();
            this.dtpDataAtualizacao = new System.Windows.Forms.DateTimePicker();
            this.dtpDataCadastro = new System.Windows.Forms.DateTimePicker();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grdContaBancaria = new System.Windows.Forms.DataGridView();
            this.btnGravar = new System.Windows.Forms.Button();
            this.cboTipoConta = new System.Windows.Forms.ComboBox();
            this.lblTipoConta = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.txtContaCorrente = new System.Windows.Forms.TextBox();
            this.lblContaCorrente = new System.Windows.Forms.Label();
            this.txtAgencia = new System.Windows.Forms.TextBox();
            this.lblAgencia = new System.Windows.Forms.Label();
            this.cboBanco = new System.Windows.Forms.ComboBox();
            this.lblBanco = new System.Windows.Forms.Label();
            this.cboEmpresa = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.gbContaBancaria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContaBancaria)).BeginInit();
            this.SuspendLayout();
            // 
            // gbContaBancaria
            // 
            this.gbContaBancaria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbContaBancaria.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbContaBancaria.Controls.Add(this.btnSair);
            this.gbContaBancaria.Controls.Add(this.txtTotal);
            this.gbContaBancaria.Controls.Add(this.btnExcel);
            this.gbContaBancaria.Controls.Add(this.btnImpressao);
            this.gbContaBancaria.Controls.Add(this.btnLimpar);
            this.gbContaBancaria.Controls.Add(this.lblDataAtualizacao);
            this.gbContaBancaria.Controls.Add(this.lblDataCadastro);
            this.gbContaBancaria.Controls.Add(this.dtpDataAtualizacao);
            this.gbContaBancaria.Controls.Add(this.dtpDataCadastro);
            this.gbContaBancaria.Controls.Add(this.lblTotal);
            this.gbContaBancaria.Controls.Add(this.btnExcluir);
            this.gbContaBancaria.Controls.Add(this.grdContaBancaria);
            this.gbContaBancaria.Controls.Add(this.btnGravar);
            this.gbContaBancaria.Controls.Add(this.cboTipoConta);
            this.gbContaBancaria.Controls.Add(this.lblTipoConta);
            this.gbContaBancaria.Controls.Add(this.txtCodigo);
            this.gbContaBancaria.Controls.Add(this.lblCodigo);
            this.gbContaBancaria.Controls.Add(this.txtSaldo);
            this.gbContaBancaria.Controls.Add(this.lblSaldo);
            this.gbContaBancaria.Controls.Add(this.txtContaCorrente);
            this.gbContaBancaria.Controls.Add(this.lblContaCorrente);
            this.gbContaBancaria.Controls.Add(this.txtAgencia);
            this.gbContaBancaria.Controls.Add(this.lblAgencia);
            this.gbContaBancaria.Controls.Add(this.cboBanco);
            this.gbContaBancaria.Controls.Add(this.lblBanco);
            this.gbContaBancaria.Controls.Add(this.cboEmpresa);
            this.gbContaBancaria.Controls.Add(this.lblEmpresa);
            this.gbContaBancaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbContaBancaria.Location = new System.Drawing.Point(11, 15);
            this.gbContaBancaria.Margin = new System.Windows.Forms.Padding(2);
            this.gbContaBancaria.Name = "gbContaBancaria";
            this.gbContaBancaria.Padding = new System.Windows.Forms.Padding(2);
            this.gbContaBancaria.Size = new System.Drawing.Size(1000, 619);
            this.gbContaBancaria.TabIndex = 1;
            this.gbContaBancaria.TabStop = false;
            this.gbContaBancaria.Text = "Cadastro de Contas Bancárias";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(926, 133);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 25);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(58, 584);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 22;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(945, 573);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 38);
            this.btnExcel.TabIndex = 12;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImpressao
            // 
            this.btnImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.Location = new System.Drawing.Point(899, 573);
            this.btnImpressao.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(42, 38);
            this.btnImpressao.TabIndex = 13;
            this.btnImpressao.UseVisualStyleBackColor = true;
            this.btnImpressao.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(862, 133);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDataAtualizacao
            // 
            this.lblDataAtualizacao.AutoSize = true;
            this.lblDataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtualizacao.Location = new System.Drawing.Point(268, 28);
            this.lblDataAtualizacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAtualizacao.Name = "lblDataAtualizacao";
            this.lblDataAtualizacao.Size = new System.Drawing.Size(91, 13);
            this.lblDataAtualizacao.TabIndex = 21;
            this.lblDataAtualizacao.Text = "Data Atualização:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(138, 28);
            this.lblDataCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 20;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // dtpDataAtualizacao
            // 
            this.dtpDataAtualizacao.Enabled = false;
            this.dtpDataAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAtualizacao.Location = new System.Drawing.Point(271, 47);
            this.dtpDataAtualizacao.Name = "dtpDataAtualizacao";
            this.dtpDataAtualizacao.Size = new System.Drawing.Size(99, 20);
            this.dtpDataAtualizacao.TabIndex = 19;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(141, 47);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(99, 20);
            this.dtpDataCadastro.TabIndex = 18;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(12, 587);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(798, 133);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 25);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grdContaBancaria
            // 
            this.grdContaBancaria.AllowUserToAddRows = false;
            this.grdContaBancaria.AllowUserToDeleteRows = false;
            this.grdContaBancaria.AllowUserToOrderColumns = true;
            this.grdContaBancaria.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdContaBancaria.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdContaBancaria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.grdContaBancaria.Location = new System.Drawing.Point(17, 161);
            this.grdContaBancaria.Margin = new System.Windows.Forms.Padding(2);
            this.grdContaBancaria.Name = "grdContaBancaria";
            this.grdContaBancaria.ReadOnly = true;
            this.grdContaBancaria.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdContaBancaria.RowTemplate.Height = 24;
            this.grdContaBancaria.Size = new System.Drawing.Size(969, 408);
            this.grdContaBancaria.TabIndex = 11;
            this.grdContaBancaria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdContaBancaria_CellClick);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(734, 133);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(60, 25);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // cboTipoConta
            // 
            this.cboTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoConta.FormattingEnabled = true;
            this.cboTipoConta.Location = new System.Drawing.Point(711, 99);
            this.cboTipoConta.Margin = new System.Windows.Forms.Padding(2);
            this.cboTipoConta.Name = "cboTipoConta";
            this.cboTipoConta.Size = new System.Drawing.Size(142, 21);
            this.cboTipoConta.TabIndex = 5;
            // 
            // lblTipoConta
            // 
            this.lblTipoConta.AutoSize = true;
            this.lblTipoConta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConta.Location = new System.Drawing.Point(708, 80);
            this.lblTipoConta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoConta.Name = "lblTipoConta";
            this.lblTipoConta.Size = new System.Drawing.Size(84, 13);
            this.lblTipoConta.TabIndex = 14;
            this.lblTipoConta.Text = "* Tipo de Conta:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(17, 47);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(99, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(14, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 10;
            this.lblCodigo.Text = "Código:";
            // 
            // txtSaldo
            // 
            this.txtSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSaldo.Location = new System.Drawing.Point(884, 100);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSaldo.MaxLength = 13;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(102, 20);
            this.txtSaldo.TabIndex = 6;
            this.txtSaldo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSaldo_KeyPress);
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.Location = new System.Drawing.Point(881, 81);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 8;
            this.lblSaldo.Text = "Saldo:";
            // 
            // txtContaCorrente
            // 
            this.txtContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContaCorrente.Location = new System.Drawing.Point(568, 100);
            this.txtContaCorrente.Margin = new System.Windows.Forms.Padding(2);
            this.txtContaCorrente.MaxLength = 10;
            this.txtContaCorrente.Name = "txtContaCorrente";
            this.txtContaCorrente.Size = new System.Drawing.Size(112, 20);
            this.txtContaCorrente.TabIndex = 4;
            this.txtContaCorrente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContaCorrente_KeyPress);
            // 
            // lblContaCorrente
            // 
            this.lblContaCorrente.AutoSize = true;
            this.lblContaCorrente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContaCorrente.Location = new System.Drawing.Point(565, 80);
            this.lblContaCorrente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContaCorrente.Name = "lblContaCorrente";
            this.lblContaCorrente.Size = new System.Drawing.Size(88, 13);
            this.lblContaCorrente.TabIndex = 6;
            this.lblContaCorrente.Text = "* Conta Corrente:";
            // 
            // txtAgencia
            // 
            this.txtAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAgencia.Location = new System.Drawing.Point(444, 101);
            this.txtAgencia.Margin = new System.Windows.Forms.Padding(2);
            this.txtAgencia.MaxLength = 10;
            this.txtAgencia.Name = "txtAgencia";
            this.txtAgencia.Size = new System.Drawing.Size(93, 20);
            this.txtAgencia.TabIndex = 3;
            this.txtAgencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAgencia_KeyPress);
            // 
            // lblAgencia
            // 
            this.lblAgencia.AutoSize = true;
            this.lblAgencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgencia.Location = new System.Drawing.Point(441, 81);
            this.lblAgencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAgencia.Name = "lblAgencia";
            this.lblAgencia.Size = new System.Drawing.Size(56, 13);
            this.lblAgencia.TabIndex = 4;
            this.lblAgencia.Text = "* Agência:";
            // 
            // cboBanco
            // 
            this.cboBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboBanco.FormattingEnabled = true;
            this.cboBanco.Location = new System.Drawing.Point(210, 100);
            this.cboBanco.Margin = new System.Windows.Forms.Padding(2);
            this.cboBanco.Name = "cboBanco";
            this.cboBanco.Size = new System.Drawing.Size(203, 21);
            this.cboBanco.TabIndex = 2;
            // 
            // lblBanco
            // 
            this.lblBanco.AutoSize = true;
            this.lblBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBanco.Location = new System.Drawing.Point(207, 80);
            this.lblBanco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBanco.Name = "lblBanco";
            this.lblBanco.Size = new System.Drawing.Size(48, 13);
            this.lblBanco.TabIndex = 2;
            this.lblBanco.Text = "* Banco:";
            // 
            // cboEmpresa
            // 
            this.cboEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmpresa.DropDownWidth = 150;
            this.cboEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEmpresa.FormattingEnabled = true;
            this.cboEmpresa.Location = new System.Drawing.Point(18, 100);
            this.cboEmpresa.Margin = new System.Windows.Forms.Padding(2);
            this.cboEmpresa.Name = "cboEmpresa";
            this.cboEmpresa.Size = new System.Drawing.Size(161, 21);
            this.cboEmpresa.TabIndex = 1;
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Location = new System.Drawing.Point(14, 81);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(58, 13);
            this.lblEmpresa.TabIndex = 0;
            this.lblEmpresa.Text = "* Empresa:";
            // 
            // FrmC_ContaBancaria
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1019, 638);
            this.ControlBox = false;
            this.Controls.Add(this.gbContaBancaria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmC_ContaBancaria";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Contas Bancárias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCadContaBancaria_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadContaBancaria_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCadContaBancaria_KeyUp);
            this.gbContaBancaria.ResumeLayout(false);
            this.gbContaBancaria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdContaBancaria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbContaBancaria;
        public System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.DataGridView grdContaBancaria;
        public System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Label lblTipoConta;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblContaCorrente;
        private System.Windows.Forms.ComboBox cboBanco;
        private System.Windows.Forms.Label lblBanco;
        private System.Windows.Forms.ComboBox cboEmpresa;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.ComboBox cboTipoConta;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtContaCorrente;
        private System.Windows.Forms.TextBox txtAgencia;
        private System.Windows.Forms.Label lblAgencia;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDataAtualizacao;
        private System.Windows.Forms.Label lblDataCadastro;
        private System.Windows.Forms.DateTimePicker dtpDataAtualizacao;
        private System.Windows.Forms.DateTimePicker dtpDataCadastro;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.Button btnImpressao;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button btnSair;
    }
}