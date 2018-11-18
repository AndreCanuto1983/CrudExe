namespace Loja.VIEW
{
    partial class FrmC_CargosSal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmC_CargosSal));
            this.gbCadCargosSalarios = new System.Windows.Forms.GroupBox();
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
            this.grdCadCargoSal = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSalario = new System.Windows.Forms.TextBox();
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtCargo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbCadCargosSalarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadCargoSal)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadCargosSalarios
            // 
            this.gbCadCargosSalarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadCargosSalarios.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbCadCargosSalarios.Controls.Add(this.btnSair);
            this.gbCadCargosSalarios.Controls.Add(this.txtTotal);
            this.gbCadCargosSalarios.Controls.Add(this.btnExcel);
            this.gbCadCargosSalarios.Controls.Add(this.btnImpressao);
            this.gbCadCargosSalarios.Controls.Add(this.btnLimpar);
            this.gbCadCargosSalarios.Controls.Add(this.lblDataAtualizacao);
            this.gbCadCargosSalarios.Controls.Add(this.lblDataCadastro);
            this.gbCadCargosSalarios.Controls.Add(this.dtpDataAtualizacao);
            this.gbCadCargosSalarios.Controls.Add(this.dtpDataCadastro);
            this.gbCadCargosSalarios.Controls.Add(this.lblTotal);
            this.gbCadCargosSalarios.Controls.Add(this.grdCadCargoSal);
            this.gbCadCargosSalarios.Controls.Add(this.btnExcluir);
            this.gbCadCargosSalarios.Controls.Add(this.btnGravar);
            this.gbCadCargosSalarios.Controls.Add(this.txtDescricao);
            this.gbCadCargosSalarios.Controls.Add(this.label1);
            this.gbCadCargosSalarios.Controls.Add(this.txtSalario);
            this.gbCadCargosSalarios.Controls.Add(this.lblSalario);
            this.gbCadCargosSalarios.Controls.Add(this.txtCargo);
            this.gbCadCargosSalarios.Controls.Add(this.txtCodigo);
            this.gbCadCargosSalarios.Controls.Add(this.lblCargo);
            this.gbCadCargosSalarios.Controls.Add(this.lblCodigo);
            this.gbCadCargosSalarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadCargosSalarios.Location = new System.Drawing.Point(11, 11);
            this.gbCadCargosSalarios.Margin = new System.Windows.Forms.Padding(2);
            this.gbCadCargosSalarios.Name = "gbCadCargosSalarios";
            this.gbCadCargosSalarios.Padding = new System.Windows.Forms.Padding(2);
            this.gbCadCargosSalarios.Size = new System.Drawing.Size(903, 544);
            this.gbCadCargosSalarios.TabIndex = 1;
            this.gbCadCargosSalarios.TabStop = false;
            this.gbCadCargosSalarios.Text = "Cargos e Salários";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(828, 119);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 25);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(56, 510);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(848, 501);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 38);
            this.btnExcel.TabIndex = 9;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImpressao
            // 
            this.btnImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.Location = new System.Drawing.Point(802, 501);
            this.btnImpressao.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(42, 38);
            this.btnImpressao.TabIndex = 10;
            this.btnImpressao.UseVisualStyleBackColor = true;
            this.btnImpressao.Visible = false;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(764, 119);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDataAtualizacao
            // 
            this.lblDataAtualizacao.AutoSize = true;
            this.lblDataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataAtualizacao.Location = new System.Drawing.Point(273, 27);
            this.lblDataAtualizacao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataAtualizacao.Name = "lblDataAtualizacao";
            this.lblDataAtualizacao.Size = new System.Drawing.Size(91, 13);
            this.lblDataAtualizacao.TabIndex = 25;
            this.lblDataAtualizacao.Text = "Data Atualização:";
            // 
            // lblDataCadastro
            // 
            this.lblDataCadastro.AutoSize = true;
            this.lblDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataCadastro.Location = new System.Drawing.Point(143, 27);
            this.lblDataCadastro.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataCadastro.Name = "lblDataCadastro";
            this.lblDataCadastro.Size = new System.Drawing.Size(78, 13);
            this.lblDataCadastro.TabIndex = 24;
            this.lblDataCadastro.Text = "Data Cadastro:";
            // 
            // dtpDataAtualizacao
            // 
            this.dtpDataAtualizacao.Enabled = false;
            this.dtpDataAtualizacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataAtualizacao.Location = new System.Drawing.Point(275, 46);
            this.dtpDataAtualizacao.Name = "dtpDataAtualizacao";
            this.dtpDataAtualizacao.Size = new System.Drawing.Size(99, 20);
            this.dtpDataAtualizacao.TabIndex = 23;
            // 
            // dtpDataCadastro
            // 
            this.dtpDataCadastro.Enabled = false;
            this.dtpDataCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDataCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataCadastro.Location = new System.Drawing.Point(146, 46);
            this.dtpDataCadastro.Name = "dtpDataCadastro";
            this.dtpDataCadastro.Size = new System.Drawing.Size(99, 20);
            this.dtpDataCadastro.TabIndex = 22;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblTotal.Location = new System.Drawing.Point(10, 513);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 14;
            this.lblTotal.Text = "Total:";
            // 
            // grdCadCargoSal
            // 
            this.grdCadCargoSal.AllowUserToAddRows = false;
            this.grdCadCargoSal.AllowUserToDeleteRows = false;
            this.grdCadCargoSal.AllowUserToOrderColumns = true;
            this.grdCadCargoSal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdCadCargoSal.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdCadCargoSal.Location = new System.Drawing.Point(13, 147);
            this.grdCadCargoSal.Margin = new System.Windows.Forms.Padding(2);
            this.grdCadCargoSal.Name = "grdCadCargoSal";
            this.grdCadCargoSal.ReadOnly = true;
            this.grdCadCargoSal.RowTemplate.Height = 24;
            this.grdCadCargoSal.Size = new System.Drawing.Size(875, 350);
            this.grdCadCargoSal.TabIndex = 8;
            this.grdCadCargoSal.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCadFuncionarioCargoSalario_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(700, 119);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 25);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(636, 119);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(60, 25);
            this.btnGravar.TabIndex = 4;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricao.Location = new System.Drawing.Point(404, 46);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescricao.MaxLength = 300;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(484, 53);
            this.txtDescricao.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(401, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Descrição:";
            // 
            // txtSalario
            // 
            this.txtSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalario.Location = new System.Drawing.Point(254, 94);
            this.txtSalario.Margin = new System.Windows.Forms.Padding(2);
            this.txtSalario.MaxLength = 8;
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(120, 20);
            this.txtSalario.TabIndex = 2;
            this.txtSalario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalario_KeyPress);
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(251, 75);
            this.lblSalario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(49, 13);
            this.lblSalario.TabIndex = 4;
            this.lblSalario.Text = "* Salário:";
            // 
            // txtCargo
            // 
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCargo.Location = new System.Drawing.Point(13, 94);
            this.txtCargo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCargo.MaxLength = 48;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.Size = new System.Drawing.Size(232, 20);
            this.txtCargo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(13, 46);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(103, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(10, 75);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(45, 13);
            this.lblCargo.TabIndex = 1;
            this.lblCargo.Text = "* Cargo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 25);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // FrmC_CargosSal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(919, 549);
            this.ControlBox = false;
            this.Controls.Add(this.gbCadCargosSalarios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmC_CargosSal";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Cargos e Salários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCadCargosSal_FormClosed);
            this.Load += new System.EventHandler(this.FrmCadCargosSal_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmCadCargosSal_KeyUp);
            this.gbCadCargosSalarios.ResumeLayout(false);
            this.gbCadCargosSalarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadCargoSal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbCadCargosSalarios;
        private System.Windows.Forms.DataGridView grdCadCargoSal;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtSalario;
        private System.Windows.Forms.Label lblSalario;
        public System.Windows.Forms.TextBox txtCargo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblCodigo;
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