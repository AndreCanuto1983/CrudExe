namespace Loja.VIEW
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.grbCadeado = new System.Windows.Forms.GroupBox();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.gbAcesso = new System.Windows.Forms.GroupBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.grbCadeado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.gbAcesso.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbCadeado
            // 
            this.grbCadeado.Controls.Add(this.imgLogin);
            this.grbCadeado.Controls.Add(this.gbAcesso);
            this.grbCadeado.Location = new System.Drawing.Point(17, 14);
            this.grbCadeado.Name = "grbCadeado";
            this.grbCadeado.Size = new System.Drawing.Size(257, 306);
            this.grbCadeado.TabIndex = 13;
            this.grbCadeado.TabStop = false;
            // 
            // imgLogin
            // 
            this.imgLogin.Image = ((System.Drawing.Image)(resources.GetObject("imgLogin.Image")));
            this.imgLogin.Location = new System.Drawing.Point(13, 14);
            this.imgLogin.Margin = new System.Windows.Forms.Padding(2);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(231, 136);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogin.TabIndex = 10;
            this.imgLogin.TabStop = false;
            // 
            // gbAcesso
            // 
            this.gbAcesso.Controls.Add(this.lblUsuario);
            this.gbAcesso.Controls.Add(this.lblSenha);
            this.gbAcesso.Controls.Add(this.btnEntrar);
            this.gbAcesso.Controls.Add(this.txtUsuario);
            this.gbAcesso.Controls.Add(this.txtSenha);
            this.gbAcesso.Location = new System.Drawing.Point(13, 155);
            this.gbAcesso.Name = "gbAcesso";
            this.gbAcesso.Size = new System.Drawing.Size(231, 135);
            this.gbAcesso.TabIndex = 15;
            this.gbAcesso.TabStop = false;
            this.gbAcesso.Text = "Acesso";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(23, 36);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 0;
            this.lblUsuario.Text = "Usuário:";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenha.Location = new System.Drawing.Point(23, 69);
            this.lblSenha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 1;
            this.lblSenha.Text = "Senha:";
            // 
            // btnEntrar
            // 
            this.btnEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrar.Location = new System.Drawing.Point(148, 90);
            this.btnEntrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(60, 25);
            this.btnEntrar.TabIndex = 2;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.Location = new System.Drawing.Point(73, 33);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txtUsuario.MaxLength = 15;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(135, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            // 
            // txtSenha
            // 
            this.txtSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(73, 66);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.MaxLength = 8;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(135, 20);
            this.txtSenha.TabIndex = 1;
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(290, 335);
            this.Controls.Add(this.grbCadeado);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Login_FormClosed);
            this.Load += new System.EventHandler(this.Login_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Login_KeyUp);
            this.grbCadeado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.gbAcesso.ResumeLayout(false);
            this.gbAcesso.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox grbCadeado;
        public System.Windows.Forms.TextBox txtSenha;
        public System.Windows.Forms.TextBox txtUsuario;
        public System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.GroupBox gbAcesso;
    }
}