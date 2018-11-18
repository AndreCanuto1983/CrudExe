namespace Loja.VIEW
{
    partial class FrmMDI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMDI));
            this.mnuPrincipal = new System.Windows.Forms.MenuStrip();
            this.mPdv = new System.Windows.Forms.ToolStripMenuItem();
            this.mCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.sbCadProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.mAdm = new System.Windows.Forms.ToolStripMenuItem();
            this.mFinanceiro = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBanco = new System.Windows.Forms.ToolStripMenuItem();
            this.smC_ContasBancarias = new System.Windows.Forms.ToolStripMenuItem();
            this.mFiscal = new System.Windows.Forms.ToolStripMenuItem();
            this.mRh = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.smC_Func = new System.Windows.Forms.ToolStripMenuItem();
            this.smC_GrupoFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.smC_CargoSal = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.smC_Usuario = new System.Windows.Forms.ToolStripMenuItem();
            this.smBloqTelasMod = new System.Windows.Forms.ToolStripMenuItem();
            this.mBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.sbPrincipal = new System.Windows.Forms.StatusStrip();
            this.sbUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblPerfil = new System.Windows.Forms.ToolStripStatusLabel();
            this.sbEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEmpresa = new System.Windows.Forms.ToolStripStatusLabel();
            this.tmrPrincipal = new System.Windows.Forms.Timer(this.components);
            this.odlgPrincipal = new System.Windows.Forms.OpenFileDialog();
            this.bloqueioDeMódulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPrincipal.SuspendLayout();
            this.sbPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuPrincipal
            // 
            this.mnuPrincipal.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mPdv,
            this.mCompras,
            this.mAdm,
            this.mFinanceiro,
            this.mFiscal,
            this.mRh,
            this.mBackup});
            this.mnuPrincipal.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.mnuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mnuPrincipal.MaximumSize = new System.Drawing.Size(0, 24);
            this.mnuPrincipal.MinimumSize = new System.Drawing.Size(0, 24);
            this.mnuPrincipal.Name = "mnuPrincipal";
            this.mnuPrincipal.ShowItemToolTips = true;
            this.mnuPrincipal.Size = new System.Drawing.Size(945, 24);
            this.mnuPrincipal.TabIndex = 1;
            this.mnuPrincipal.Text = "menuPrincipal";
            // 
            // mPdv
            // 
            this.mPdv.Name = "mPdv";
            this.mPdv.Size = new System.Drawing.Size(40, 20);
            this.mPdv.Text = "PDV";
            // 
            // mCompras
            // 
            this.mCompras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProduto});
            this.mCompras.Name = "mCompras";
            this.mCompras.Size = new System.Drawing.Size(64, 20);
            this.mCompras.Text = "Compras";
            // 
            // mnuProduto
            // 
            this.mnuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbCadProduto});
            this.mnuProduto.Name = "mnuProduto";
            this.mnuProduto.Size = new System.Drawing.Size(180, 22);
            this.mnuProduto.Text = "Produto";
            // 
            // sbCadProduto
            // 
            this.sbCadProduto.Name = "sbCadProduto";
            this.sbCadProduto.Size = new System.Drawing.Size(181, 22);
            this.sbCadProduto.Text = "Cadastro de Produto";
            // 
            // mAdm
            // 
            this.mAdm.Name = "mAdm";
            this.mAdm.Size = new System.Drawing.Size(92, 20);
            this.mAdm.Text = "Administração";
            // 
            // mFinanceiro
            // 
            this.mFinanceiro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBanco});
            this.mFinanceiro.Name = "mFinanceiro";
            this.mFinanceiro.Size = new System.Drawing.Size(73, 20);
            this.mFinanceiro.Text = "Financeiro";
            // 
            // mnuBanco
            // 
            this.mnuBanco.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smC_ContasBancarias});
            this.mnuBanco.Name = "mnuBanco";
            this.mnuBanco.Size = new System.Drawing.Size(106, 22);
            this.mnuBanco.Text = "Banco";
            // 
            // smC_ContasBancarias
            // 
            this.smC_ContasBancarias.Name = "smC_ContasBancarias";
            this.smC_ContasBancarias.Size = new System.Drawing.Size(227, 22);
            this.smC_ContasBancarias.Text = "Cadastro de Contas Bancárias";
            this.smC_ContasBancarias.Click += new System.EventHandler(this.cadastroDeContasBancáriasToolStripMenuItem_Click);
            // 
            // mFiscal
            // 
            this.mFiscal.Name = "mFiscal";
            this.mFiscal.Size = new System.Drawing.Size(47, 20);
            this.mFiscal.Text = "Fiscal";
            // 
            // mRh
            // 
            this.mRh.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFuncionario,
            this.mnuUsuario});
            this.mRh.Name = "mRh";
            this.mRh.Size = new System.Drawing.Size(34, 20);
            this.mRh.Text = "RH";
            // 
            // mnuFuncionario
            // 
            this.mnuFuncionario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smC_Func,
            this.smC_GrupoFuncionario,
            this.smC_CargoSal});
            this.mnuFuncionario.Name = "mnuFuncionario";
            this.mnuFuncionario.Size = new System.Drawing.Size(180, 22);
            this.mnuFuncionario.Text = "Funcionário";
            // 
            // smC_Func
            // 
            this.smC_Func.Name = "smC_Func";
            this.smC_Func.Size = new System.Drawing.Size(253, 22);
            this.smC_Func.Text = "Cadastro de Funcionário";
            this.smC_Func.Click += new System.EventHandler(this.mnuCadFunc_Click);
            // 
            // smC_GrupoFuncionario
            // 
            this.smC_GrupoFuncionario.Name = "smC_GrupoFuncionario";
            this.smC_GrupoFuncionario.Size = new System.Drawing.Size(253, 22);
            this.smC_GrupoFuncionario.Text = "Cadastro de Grupo de Funcionário";
            this.smC_GrupoFuncionario.Click += new System.EventHandler(this.mnuCadPerfil_Click);
            // 
            // smC_CargoSal
            // 
            this.smC_CargoSal.Name = "smC_CargoSal";
            this.smC_CargoSal.Size = new System.Drawing.Size(253, 22);
            this.smC_CargoSal.Text = "Cadastro de Cargos e Salários";
            this.smC_CargoSal.Click += new System.EventHandler(this.cadastroDeCargosESaláriosToolStripMenuItem_Click);
            // 
            // mnuUsuario
            // 
            this.mnuUsuario.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smC_Usuario,
            this.smBloqTelasMod,
            this.bloqueioDeMódulosToolStripMenuItem});
            this.mnuUsuario.Name = "mnuUsuario";
            this.mnuUsuario.Size = new System.Drawing.Size(180, 22);
            this.mnuUsuario.Text = "Usuário";
            // 
            // smC_Usuario
            // 
            this.smC_Usuario.Name = "smC_Usuario";
            this.smC_Usuario.Size = new System.Drawing.Size(186, 22);
            this.smC_Usuario.Text = "Cadastro de Usuário";
            this.smC_Usuario.Click += new System.EventHandler(this.cadastroDeUsuárioToolStripMenuItem_Click);
            // 
            // smBloqTelasMod
            // 
            this.smBloqTelasMod.Name = "smBloqTelasMod";
            this.smBloqTelasMod.Size = new System.Drawing.Size(186, 22);
            this.smBloqTelasMod.Text = "Bloqueio de Telas";
            this.smBloqTelasMod.Click += new System.EventHandler(this.smBloqTelasMod_Click);
            // 
            // mBackup
            // 
            this.mBackup.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBackup});
            this.mBackup.Name = "mBackup";
            this.mBackup.Size = new System.Drawing.Size(57, 20);
            this.mBackup.Text = "Backup";
            // 
            // mnuBackup
            // 
            this.mnuBackup.Name = "mnuBackup";
            this.mnuBackup.Size = new System.Drawing.Size(112, 22);
            this.mnuBackup.Text = "Backup";
            // 
            // sbPrincipal
            // 
            this.sbPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sbUsuario,
            this.lblUsuario,
            this.sbPerfil,
            this.lblPerfil,
            this.sbEmpresa,
            this.lblEmpresa});
            this.sbPrincipal.Location = new System.Drawing.Point(0, 435);
            this.sbPrincipal.Name = "sbPrincipal";
            this.sbPrincipal.ShowItemToolTips = true;
            this.sbPrincipal.Size = new System.Drawing.Size(945, 22);
            this.sbPrincipal.TabIndex = 2;
            this.sbPrincipal.Text = "sbPrincipal";
            // 
            // sbUsuario
            // 
            this.sbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbUsuario.Name = "sbUsuario";
            this.sbUsuario.Size = new System.Drawing.Size(54, 17);
            this.sbUsuario.Text = "Usuário:";
            this.sbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbUsuario.ToolTipText = "Usuário logado no sistema";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(53, 17);
            this.lblUsuario.Text = "lblUsuario";
            this.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbPerfil
            // 
            this.sbPerfil.AutoSize = false;
            this.sbPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbPerfil.Name = "sbPerfil";
            this.sbPerfil.Size = new System.Drawing.Size(70, 17);
            this.sbPerfil.Text = "Grupo:";
            this.sbPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbPerfil.ToolTipText = "Perfil do usuário logado";
            // 
            // lblPerfil
            // 
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(40, 17);
            this.lblPerfil.Text = "lblPerfil";
            this.lblPerfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // sbEmpresa
            // 
            this.sbEmpresa.AutoSize = false;
            this.sbEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sbEmpresa.Name = "sbEmpresa";
            this.sbEmpresa.Size = new System.Drawing.Size(80, 17);
            this.sbEmpresa.Text = "Empresa:";
            this.sbEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sbEmpresa.ToolTipText = "Empresa do usuário logado";
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(58, 17);
            this.lblEmpresa.Text = "lblEmpresa";
            this.lblEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tmrPrincipal
            // 
            this.tmrPrincipal.Enabled = true;
            // 
            // bloqueioDeMódulosToolStripMenuItem
            // 
            this.bloqueioDeMódulosToolStripMenuItem.Name = "bloqueioDeMódulosToolStripMenuItem";
            this.bloqueioDeMódulosToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.bloqueioDeMódulosToolStripMenuItem.Text = "Bloqueio de Módulos";
            this.bloqueioDeMódulosToolStripMenuItem.Click += new System.EventHandler(this.bloqueioDeMódulosToolStripMenuItem_Click);
            // 
            // FrmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(945, 457);
            this.Controls.Add(this.sbPrincipal);
            this.Controls.Add(this.mnuPrincipal);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.MainMenuStrip = this.mnuPrincipal;
            this.Name = "FrmMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loja";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDI_FormClosed);
            this.Load += new System.EventHandler(this.MDI_Load);
            this.mnuPrincipal.ResumeLayout(false);
            this.mnuPrincipal.PerformLayout();
            this.sbPrincipal.ResumeLayout(false);
            this.sbPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem mPdv;
        private System.Windows.Forms.ToolStripMenuItem mAdm;
        private System.Windows.Forms.ToolStripMenuItem mRh;
        private System.Windows.Forms.ToolStripMenuItem mCompras;
        private System.Windows.Forms.ToolStripMenuItem mFinanceiro;
        private System.Windows.Forms.ToolStripMenuItem mFiscal;
        public System.Windows.Forms.StatusStrip sbPrincipal;
        private System.Windows.Forms.ToolStripStatusLabel sbUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.ToolStripStatusLabel sbPerfil;
        private System.Windows.Forms.ToolStripStatusLabel lblPerfil;
        private System.Windows.Forms.ToolStripStatusLabel sbEmpresa;
        private System.Windows.Forms.ToolStripStatusLabel lblEmpresa;
        public System.Windows.Forms.Timer tmrPrincipal;
        public System.Windows.Forms.MenuStrip mnuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuFuncionario;
        private System.Windows.Forms.ToolStripMenuItem smC_Func;
        private System.Windows.Forms.ToolStripMenuItem smC_GrupoFuncionario;
        private System.Windows.Forms.ToolStripMenuItem smC_CargoSal;
        private System.Windows.Forms.ToolStripMenuItem mnuBanco;
        private System.Windows.Forms.ToolStripMenuItem smC_ContasBancarias;
        private System.Windows.Forms.ToolStripMenuItem mBackup;
        private System.Windows.Forms.ToolStripMenuItem mnuBackup;
        private System.Windows.Forms.OpenFileDialog odlgPrincipal;
        private System.Windows.Forms.ToolStripMenuItem mnuProduto;
        private System.Windows.Forms.ToolStripMenuItem sbCadProduto;
        private System.Windows.Forms.ToolStripMenuItem mnuUsuario;
        private System.Windows.Forms.ToolStripMenuItem smC_Usuario;
        private System.Windows.Forms.ToolStripMenuItem smBloqTelasMod;
        private System.Windows.Forms.ToolStripMenuItem bloqueioDeMódulosToolStripMenuItem;
    }
}