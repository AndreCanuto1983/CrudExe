namespace Loja.VIEW
{
    partial class FrmC_Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmC_Usuario));
            this.gbC_Usuario = new System.Windows.Forms.GroupBox();
            this.txtGrupo = new System.Windows.Forms.TextBox();
            this.btnAbrirGrupo = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.gbEmpresa = new System.Windows.Forms.GroupBox();
            this.btnDesmarcarTodos = new System.Windows.Forms.Button();
            this.clstEmpresa = new System.Windows.Forms.CheckedListBox();
            this.btnMarcarTodos = new System.Windows.Forms.Button();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.brnGravar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.gbGrid = new System.Windows.Forms.GroupBox();
            this.grdC_Usuarios = new System.Windows.Forms.DataGridView();
            this.ckbAtivo = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtCodGrupo = new System.Windows.Forms.TextBox();
            this.lblGrupo = new System.Windows.Forms.Label();
            this.lbldtUltLogin = new System.Windows.Forms.Label();
            this.lbldtatualizacao = new System.Windows.Forms.Label();
            this.lbldtCadastro = new System.Windows.Forms.Label();
            this.dtUltLogin = new System.Windows.Forms.DateTimePicker();
            this.dtAtualizacao = new System.Windows.Forms.DateTimePicker();
            this.dtCadastro = new System.Windows.Forms.DateTimePicker();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gbC_Usuario.SuspendLayout();
            this.gbEmpresa.SuspendLayout();
            this.gbGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdC_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbC_Usuario
            // 
            this.gbC_Usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gbC_Usuario.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.gbC_Usuario.Controls.Add(this.txtGrupo);
            this.gbC_Usuario.Controls.Add(this.btnAbrirGrupo);
            this.gbC_Usuario.Controls.Add(this.btnExcel);
            this.gbC_Usuario.Controls.Add(this.gbEmpresa);
            this.gbC_Usuario.Controls.Add(this.brnGravar);
            this.gbC_Usuario.Controls.Add(this.btnExcluir);
            this.gbC_Usuario.Controls.Add(this.btnLimpar);
            this.gbC_Usuario.Controls.Add(this.txtTotal);
            this.gbC_Usuario.Controls.Add(this.lblTotal);
            this.gbC_Usuario.Controls.Add(this.gbGrid);
            this.gbC_Usuario.Controls.Add(this.ckbAtivo);
            this.gbC_Usuario.Controls.Add(this.btnSair);
            this.gbC_Usuario.Controls.Add(this.txtCodGrupo);
            this.gbC_Usuario.Controls.Add(this.lblGrupo);
            this.gbC_Usuario.Controls.Add(this.lbldtUltLogin);
            this.gbC_Usuario.Controls.Add(this.lbldtatualizacao);
            this.gbC_Usuario.Controls.Add(this.lbldtCadastro);
            this.gbC_Usuario.Controls.Add(this.dtUltLogin);
            this.gbC_Usuario.Controls.Add(this.dtAtualizacao);
            this.gbC_Usuario.Controls.Add(this.dtCadastro);
            this.gbC_Usuario.Controls.Add(this.txtSenha);
            this.gbC_Usuario.Controls.Add(this.lblSenha);
            this.gbC_Usuario.Controls.Add(this.txtUsuario);
            this.gbC_Usuario.Controls.Add(this.lblUsuario);
            this.gbC_Usuario.Controls.Add(this.txtCodigo);
            this.gbC_Usuario.Controls.Add(this.lblCodigo);
            this.gbC_Usuario.Location = new System.Drawing.Point(17, 11);
            this.gbC_Usuario.Name = "gbC_Usuario";
            this.gbC_Usuario.Size = new System.Drawing.Size(907, 592);
            this.gbC_Usuario.TabIndex = 0;
            this.gbC_Usuario.TabStop = false;
            this.gbC_Usuario.Text = " ";
            // 
            // txtGrupo
            // 
            this.txtGrupo.Enabled = false;
            this.txtGrupo.Location = new System.Drawing.Point(339, 89);
            this.txtGrupo.MaxLength = 50;
            this.txtGrupo.Name = "txtGrupo";
            this.txtGrupo.Size = new System.Drawing.Size(156, 20);
            this.txtGrupo.TabIndex = 27;
            // 
            // btnAbrirGrupo
            // 
            this.btnAbrirGrupo.Location = new System.Drawing.Point(499, 86);
            this.btnAbrirGrupo.Name = "btnAbrirGrupo";
            this.btnAbrirGrupo.Size = new System.Drawing.Size(26, 25);
            this.btnAbrirGrupo.TabIndex = 9;
            this.btnAbrirGrupo.Tag = "Clique para cadastrar um novo grupo";
            this.btnAbrirGrupo.Text = "...";
            this.btnAbrirGrupo.UseVisualStyleBackColor = true;
            this.btnAbrirGrupo.Click += new System.EventHandler(this.btnAbrirGrupo_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.Location = new System.Drawing.Point(850, 555);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(35, 30);
            this.btnExcel.TabIndex = 16;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // gbEmpresa
            // 
            this.gbEmpresa.Controls.Add(this.btnDesmarcarTodos);
            this.gbEmpresa.Controls.Add(this.clstEmpresa);
            this.gbEmpresa.Controls.Add(this.btnMarcarTodos);
            this.gbEmpresa.Controls.Add(this.lblEmpresa);
            this.gbEmpresa.Location = new System.Drawing.Point(555, 0);
            this.gbEmpresa.Name = "gbEmpresa";
            this.gbEmpresa.Size = new System.Drawing.Size(341, 152);
            this.gbEmpresa.TabIndex = 15;
            this.gbEmpresa.TabStop = false;
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(265, 127);
            this.btnDesmarcarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(70, 20);
            this.btnDesmarcarTodos.TabIndex = 15;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseVisualStyleBackColor = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // clstEmpresa
            // 
            this.clstEmpresa.CheckOnClick = true;
            this.clstEmpresa.FormattingEnabled = true;
            this.clstEmpresa.Location = new System.Drawing.Point(9, 28);
            this.clstEmpresa.Name = "clstEmpresa";
            this.clstEmpresa.Size = new System.Drawing.Size(326, 94);
            this.clstEmpresa.TabIndex = 19;
            // 
            // btnMarcarTodos
            // 
            this.btnMarcarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarcarTodos.Location = new System.Drawing.Point(191, 127);
            this.btnMarcarTodos.Margin = new System.Windows.Forms.Padding(2);
            this.btnMarcarTodos.Name = "btnMarcarTodos";
            this.btnMarcarTodos.Size = new System.Drawing.Size(70, 20);
            this.btnMarcarTodos.TabIndex = 14;
            this.btnMarcarTodos.Text = "Marcar Todos";
            this.btnMarcarTodos.UseVisualStyleBackColor = true;
            this.btnMarcarTodos.Click += new System.EventHandler(this.btnMarcarTodos_Click);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(8, 10);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(55, 13);
            this.lblEmpresa.TabIndex = 2;
            this.lblEmpresa.Text = "* Empresa";
            // 
            // brnGravar
            // 
            this.brnGravar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brnGravar.Location = new System.Drawing.Point(281, 127);
            this.brnGravar.Margin = new System.Windows.Forms.Padding(2);
            this.brnGravar.Name = "brnGravar";
            this.brnGravar.Size = new System.Drawing.Size(60, 25);
            this.brnGravar.TabIndex = 10;
            this.brnGravar.Text = "Gravar";
            this.brnGravar.UseVisualStyleBackColor = true;
            this.brnGravar.Click += new System.EventHandler(this.brnGravar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(345, 127);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(2);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(60, 25);
            this.btnExcluir.TabIndex = 11;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(409, 127);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(47, 565);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTotal.TabIndex = 26;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(9, 569);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // gbGrid
            // 
            this.gbGrid.Controls.Add(this.grdC_Usuarios);
            this.gbGrid.Location = new System.Drawing.Point(6, 157);
            this.gbGrid.Name = "gbGrid";
            this.gbGrid.Size = new System.Drawing.Size(890, 396);
            this.gbGrid.TabIndex = 24;
            this.gbGrid.TabStop = false;
            // 
            // grdC_Usuarios
            // 
            this.grdC_Usuarios.AllowUserToAddRows = false;
            this.grdC_Usuarios.AllowUserToDeleteRows = false;
            this.grdC_Usuarios.AllowUserToOrderColumns = true;
            this.grdC_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdC_Usuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdC_Usuarios.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdC_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdC_Usuarios.Location = new System.Drawing.Point(6, 17);
            this.grdC_Usuarios.Name = "grdC_Usuarios";
            this.grdC_Usuarios.ReadOnly = true;
            this.grdC_Usuarios.Size = new System.Drawing.Size(878, 373);
            this.grdC_Usuarios.TabIndex = 17;
            this.grdC_Usuarios.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdC_Usuarios_CellClick);
            // 
            // ckbAtivo
            // 
            this.ckbAtivo.AutoSize = true;
            this.ckbAtivo.Location = new System.Drawing.Point(464, 41);
            this.ckbAtivo.Name = "ckbAtivo";
            this.ckbAtivo.Size = new System.Drawing.Size(50, 17);
            this.ckbAtivo.TabIndex = 5;
            this.ckbAtivo.Text = "Ativo";
            this.ckbAtivo.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(473, 127);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 25);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtCodGrupo
            // 
            this.txtCodGrupo.Location = new System.Drawing.Point(295, 89);
            this.txtCodGrupo.MaxLength = 4;
            this.txtCodGrupo.Name = "txtCodGrupo";
            this.txtCodGrupo.Size = new System.Drawing.Size(42, 20);
            this.txtCodGrupo.TabIndex = 8;
            this.txtCodGrupo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtGrupo_KeyPress);
            this.txtCodGrupo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtGrupo_KeyUp);
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(292, 73);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(64, 13);
            this.lblGrupo.TabIndex = 12;
            this.lblGrupo.Text = "* Grupo (F2)";
            // 
            // lbldtUltLogin
            // 
            this.lbldtUltLogin.AutoSize = true;
            this.lbldtUltLogin.Location = new System.Drawing.Point(353, 25);
            this.lbldtUltLogin.Name = "lbldtUltLogin";
            this.lbldtUltLogin.Size = new System.Drawing.Size(100, 13);
            this.lbldtUltLogin.TabIndex = 11;
            this.lbldtUltLogin.Text = "Data Último Acesso";
            // 
            // lbldtatualizacao
            // 
            this.lbldtatualizacao.AutoSize = true;
            this.lbldtatualizacao.Location = new System.Drawing.Point(239, 25);
            this.lbldtatualizacao.Name = "lbldtatualizacao";
            this.lbldtatualizacao.Size = new System.Drawing.Size(88, 13);
            this.lbldtatualizacao.TabIndex = 10;
            this.lbldtatualizacao.Text = "Data Atualização";
            // 
            // lbldtCadastro
            // 
            this.lbldtCadastro.AutoSize = true;
            this.lbldtCadastro.Location = new System.Drawing.Point(124, 25);
            this.lbldtCadastro.Name = "lbldtCadastro";
            this.lbldtCadastro.Size = new System.Drawing.Size(75, 13);
            this.lbldtCadastro.TabIndex = 9;
            this.lbldtCadastro.Text = "Data Cadastro";
            // 
            // dtUltLogin
            // 
            this.dtUltLogin.Enabled = false;
            this.dtUltLogin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtUltLogin.Location = new System.Drawing.Point(356, 38);
            this.dtUltLogin.Name = "dtUltLogin";
            this.dtUltLogin.Size = new System.Drawing.Size(91, 20);
            this.dtUltLogin.TabIndex = 4;
            // 
            // dtAtualizacao
            // 
            this.dtAtualizacao.Enabled = false;
            this.dtAtualizacao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAtualizacao.Location = new System.Drawing.Point(242, 38);
            this.dtAtualizacao.Name = "dtAtualizacao";
            this.dtAtualizacao.Size = new System.Drawing.Size(91, 20);
            this.dtAtualizacao.TabIndex = 3;
            // 
            // dtCadastro
            // 
            this.dtCadastro.Enabled = false;
            this.dtCadastro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCadastro.Location = new System.Drawing.Point(127, 38);
            this.dtCadastro.Name = "dtCadastro";
            this.dtCadastro.Size = new System.Drawing.Size(91, 20);
            this.dtCadastro.TabIndex = 2;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(203, 89);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(85, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(200, 73);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(45, 13);
            this.lblSenha.TabIndex = 4;
            this.lblSenha.Text = "* Senha";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(12, 89);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(184, 20);
            this.txtUsuario.TabIndex = 6;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(9, 73);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(50, 13);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "* Usuário";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(12, 38);
            this.txtCodigo.MaxLength = 4;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(91, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(9, 25);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(61, 13);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código (F2)";
            // 
            // FrmC_Usuario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(940, 615);
            this.ControlBox = false;
            this.Controls.Add(this.gbC_Usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FrmC_Usuario";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Cadastro de Usuário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmC_Usuario_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmC_Usuario_KeyUp);
            this.gbC_Usuario.ResumeLayout(false);
            this.gbC_Usuario.PerformLayout();
            this.gbEmpresa.ResumeLayout(false);
            this.gbEmpresa.PerformLayout();
            this.gbGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdC_Usuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbC_Usuario;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lbldtUltLogin;
        private System.Windows.Forms.Label lbldtatualizacao;
        private System.Windows.Forms.Label lbldtCadastro;
        private System.Windows.Forms.DateTimePicker dtUltLogin;
        private System.Windows.Forms.DateTimePicker dtAtualizacao;
        private System.Windows.Forms.DateTimePicker dtCadastro;
        private System.Windows.Forms.TextBox txtCodGrupo;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.GroupBox gbEmpresa;
        public System.Windows.Forms.Button btnDesmarcarTodos;
        public System.Windows.Forms.CheckedListBox clstEmpresa;
        public System.Windows.Forms.Button btnMarcarTodos;
        private System.Windows.Forms.Label lblEmpresa;
        public System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.CheckBox ckbAtivo;
        private System.Windows.Forms.GroupBox gbGrid;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.DataGridView grdC_Usuarios;
        public System.Windows.Forms.Button brnGravar;
        public System.Windows.Forms.Button btnExcluir;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnAbrirGrupo;
        private System.Windows.Forms.TextBox txtGrupo;
    }
}