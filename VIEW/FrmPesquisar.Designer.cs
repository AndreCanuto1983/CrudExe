namespace Loja.VIEW
{
    partial class FrmPesquisar
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
            this.gbPesquisar = new System.Windows.Forms.GroupBox();
            this.chkConsiderarInativo = new System.Windows.Forms.CheckBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblDica = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtPesquisar = new System.Windows.Forms.TextBox();
            this.lblPesquisar = new System.Windows.Forms.Label();
            this.grdPesquisar = new System.Windows.Forms.DataGridView();
            this.gbPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisar)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPesquisar
            // 
            this.gbPesquisar.Controls.Add(this.chkConsiderarInativo);
            this.gbPesquisar.Controls.Add(this.btnSair);
            this.gbPesquisar.Controls.Add(this.txtTotal);
            this.gbPesquisar.Controls.Add(this.lblTotal);
            this.gbPesquisar.Controls.Add(this.btnLimpar);
            this.gbPesquisar.Controls.Add(this.lblDica);
            this.gbPesquisar.Controls.Add(this.btnPesquisar);
            this.gbPesquisar.Controls.Add(this.txtPesquisar);
            this.gbPesquisar.Controls.Add(this.lblPesquisar);
            this.gbPesquisar.Controls.Add(this.grdPesquisar);
            this.gbPesquisar.Location = new System.Drawing.Point(12, 12);
            this.gbPesquisar.Name = "gbPesquisar";
            this.gbPesquisar.Size = new System.Drawing.Size(920, 491);
            this.gbPesquisar.TabIndex = 0;
            this.gbPesquisar.TabStop = false;
            // 
            // chkConsiderarInativo
            // 
            this.chkConsiderarInativo.AutoSize = true;
            this.chkConsiderarInativo.Location = new System.Drawing.Point(588, 25);
            this.chkConsiderarInativo.Name = "chkConsiderarInativo";
            this.chkConsiderarInativo.Size = new System.Drawing.Size(116, 17);
            this.chkConsiderarInativo.TabIndex = 1;
            this.chkConsiderarInativo.Text = "Considerar Inativos";
            this.chkConsiderarInativo.UseVisualStyleBackColor = true;
            this.chkConsiderarInativo.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(842, 22);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 25);
            this.btnSair.TabIndex = 4;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(63, 460);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(120, 20);
            this.txtTotal.TabIndex = 6;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(17, 463);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(40, 13);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "Total:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(776, 22);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 25);
            this.btnLimpar.TabIndex = 3;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.Color.Red;
            this.lblDica.Location = new System.Drawing.Point(682, 464);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(220, 13);
            this.lblDica.TabIndex = 1;
            this.lblDica.Text = "Utilize * para pesquisar por todos os registros.";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(710, 22);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(60, 25);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtPesquisar
            // 
            this.txtPesquisar.Location = new System.Drawing.Point(63, 25);
            this.txtPesquisar.MaxLength = 20;
            this.txtPesquisar.Name = "txtPesquisar";
            this.txtPesquisar.Size = new System.Drawing.Size(505, 20);
            this.txtPesquisar.TabIndex = 0;
            this.txtPesquisar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisar_KeyPress);
            // 
            // lblPesquisar
            // 
            this.lblPesquisar.AutoSize = true;
            this.lblPesquisar.Location = new System.Drawing.Point(14, 28);
            this.lblPesquisar.Name = "lblPesquisar";
            this.lblPesquisar.Size = new System.Drawing.Size(38, 13);
            this.lblPesquisar.TabIndex = 4;
            this.lblPesquisar.Text = "Nome:";
            // 
            // grdPesquisar
            // 
            this.grdPesquisar.AllowUserToAddRows = false;
            this.grdPesquisar.AllowUserToDeleteRows = false;
            this.grdPesquisar.AllowUserToOrderColumns = true;
            this.grdPesquisar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdPesquisar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.grdPesquisar.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grdPesquisar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPesquisar.Location = new System.Drawing.Point(17, 59);
            this.grdPesquisar.Name = "grdPesquisar";
            this.grdPesquisar.ReadOnly = true;
            this.grdPesquisar.Size = new System.Drawing.Size(885, 391);
            this.grdPesquisar.TabIndex = 5;
            this.grdPesquisar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPesquisar_CellClick);
            // 
            // FrmPesquisar
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(945, 515);
            this.ControlBox = false;
            this.Controls.Add(this.gbPesquisar);
            this.KeyPreview = true;
            this.Name = "FrmPesquisar";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmPesquisar_FormClosed);
            this.Load += new System.EventHandler(this.FrmPesquisar_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmPesquisar_KeyUp);
            this.gbPesquisar.ResumeLayout(false);
            this.gbPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPesquisar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPesquisar;
        public System.Windows.Forms.DataGridView grdPesquisar;
        public System.Windows.Forms.TextBox txtPesquisar;
        public System.Windows.Forms.Label lblPesquisar;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label lblDica;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnSair;
        public System.Windows.Forms.CheckBox chkConsiderarInativo;
    }
}