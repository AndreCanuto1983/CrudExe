namespace Loja.VIEW
{
    partial class FrmC_GrupoUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmC_GrupoUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbCadPerfilFunc = new System.Windows.Forms.GroupBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnImpressao = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.grdCadFuncGrupo = new System.Windows.Forms.DataGridView();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPerfil = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbCadPerfilFunc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadFuncGrupo)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCadPerfilFunc
            // 
            this.gbCadPerfilFunc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbCadPerfilFunc.Controls.Add(this.btnSair);
            this.gbCadPerfilFunc.Controls.Add(this.txtTotal);
            this.gbCadPerfilFunc.Controls.Add(this.btnLimpar);
            this.gbCadPerfilFunc.Controls.Add(this.btnExcel);
            this.gbCadPerfilFunc.Controls.Add(this.btnImpressao);
            this.gbCadPerfilFunc.Controls.Add(this.lblTotal);
            this.gbCadPerfilFunc.Controls.Add(this.grdCadFuncGrupo);
            this.gbCadPerfilFunc.Controls.Add(this.btnExcluir);
            this.gbCadPerfilFunc.Controls.Add(this.btnGravar);
            this.gbCadPerfilFunc.Controls.Add(this.txtGrupo);
            this.gbCadPerfilFunc.Controls.Add(this.txtCodigo);
            this.gbCadPerfilFunc.Controls.Add(this.lblPerfil);
            this.gbCadPerfilFunc.Controls.Add(this.lblCodigo);
            this.gbCadPerfilFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbCadPerfilFunc.Location = new System.Drawing.Point(17, 18);
            this.gbCadPerfilFunc.Name = "gbCadPerfilFunc";
            this.gbCadPerfilFunc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gbCadPerfilFunc.Size = new System.Drawing.Size(640, 583);
            this.gbCadPerfilFunc.TabIndex = 1;
            this.gbCadPerfilFunc.TabStop = false;
            this.gbCadPerfilFunc.Text = "Grupo de Usuários";
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(563, 70);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 25);
            this.btnSair.TabIndex = 5;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(57, 549);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 14;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(499, 70);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(583, 540);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(40, 38);
            this.btnExcel.TabIndex = 7;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnImpressao
            // 
            this.btnImpressao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnImpressao.Image = ((System.Drawing.Image)(resources.GetObject("btnImpressao.Image")));
            this.btnImpressao.Location = new System.Drawing.Point(537, 540);
            this.btnImpressao.Margin = new System.Windows.Forms.Padding(2);
            this.btnImpressao.Name = "btnImpressao";
            this.btnImpressao.Size = new System.Drawing.Size(42, 38);
            this.btnImpressao.TabIndex = 8;
            this.btnImpressao.UseVisualStyleBackColor = true;
            this.btnImpressao.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(11, 552);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total:";
            // 
            // grdCadFuncGrupo
            // 
            this.grdCadFuncGrupo.AllowUserToAddRows = false;
            this.grdCadFuncGrupo.AllowUserToDeleteRows = false;
            this.grdCadFuncGrupo.AllowUserToOrderColumns = true;
            this.grdCadFuncGrupo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdCadFuncGrupo.BackgroundColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdCadFuncGrupo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdCadFuncGrupo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCadFuncGrupo.Location = new System.Drawing.Point(14, 99);
            this.grdCadFuncGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.grdCadFuncGrupo.MultiSelect = false;
            this.grdCadFuncGrupo.Name = "grdCadFuncGrupo";
            this.grdCadFuncGrupo.ReadOnly = true;
            this.grdCadFuncGrupo.RowTemplate.Height = 24;
            this.grdCadFuncGrupo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdCadFuncGrupo.Size = new System.Drawing.Size(609, 437);
            this.grdCadFuncGrupo.TabIndex = 6;
            this.grdCadFuncGrupo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdCadPerfil_CellClick);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(435, 70);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 25);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnGravar
            // 
            this.btnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGravar.Location = new System.Drawing.Point(371, 70);
            this.btnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(60, 25);
            this.btnGravar.TabIndex = 2;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // txtGrupo
            // 
            this.txtGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrupo.Location = new System.Drawing.Point(138, 46);
            this.txtGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(485, 20);
            this.txtGrupo.TabIndex = 1;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(14, 46);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(2);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(106, 20);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lblPerfil
            // 
            this.lblPerfil.AutoSize = true;
            this.lblPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerfil.Location = new System.Drawing.Point(135, 28);
            this.lblPerfil.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPerfil.Name = "lblPerfil";
            this.lblPerfil.Size = new System.Drawing.Size(46, 13);
            this.lblPerfil.TabIndex = 1;
            this.lblPerfil.Text = "* Grupo:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.Location = new System.Drawing.Point(12, 28);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(43, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código:";
            // 
            // FrmC_GrupoUsuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(674, 619);
            this.ControlBox = false;
            this.Controls.Add(this.gbCadPerfilFunc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmC_GrupoUsuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Grupo de Usuários";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CadPerfilFunc_FormClosed);
            this.Load += new System.EventHandler(this.CadPerfilFunc_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCadGrupoFunc_KeyUp);
            this.gbCadPerfilFunc.ResumeLayout(false);
            this.gbCadPerfilFunc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdCadFuncGrupo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCadFuncGrupo;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnGravar;
        public System.Windows.Forms.TextBox txtGrupo;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPerfil;
        private System.Windows.Forms.Label lblCodigo;
        internal System.Windows.Forms.GroupBox gbCadPerfilFunc;
        private System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Button btnImpressao;
        public System.Windows.Forms.Button btnExcel;
        public System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTotal;
        public System.Windows.Forms.Button btnSair;
    }
}