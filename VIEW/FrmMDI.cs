using Loja.BUSINESS;
using Loja.ENTITY;
using Loja.DATA;
using Loja.FUNCTIONS;
using System;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmMDI : Form
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        LoginENT login = new LoginENT();
        string imagemMdi = @"E:\Sistema\Repositorio\Loja\IMAGENS\Mdi\mdi.jpg";

        public FrmMDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            string maquina = funcoes.VerificarMaquina();
            login.maquina = maquina;
            funcoes.VerificarLogadoPorMarquina(login);
            try
            {
                FrmLogin frmlogin = new FrmLogin();
                frmlogin.Dispose();
                mnuPrincipal.Enabled = true;
                lblUsuario.Text = login.usuario;
                lblPerfil.Text = login.grupo.ToString();
                lblEmpresa.Text = login.empresa_fantasia;
                if (System.IO.File.Exists(imagemMdi)) //verifico se a imagem existe no caminho
                {
                    this.BackgroundImage = System.Drawing.Bitmap.FromFile(imagemMdi); //pego o caminho da imagem e seto de fundo do mdi                     
                }
                else if (System.IO.File.Exists(imagemMdi))
                {
                    this.BackgroundImage = System.Drawing.Bitmap.FromFile(imagemMdi); //pego o caminho da imagem e seto de fundo do mdi  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void MDI_FormClosed(object sender, FormClosedEventArgs e)
        {
            funcoes.ExcluirTemp(login);
            this.Dispose();
            Application.Exit();
        }

        private void mnuCadPerfil_Click(object sender, EventArgs e)
        {
            FrmC_GrupoUsuario cadGrupo = new FrmC_GrupoUsuario();
            cadGrupo.MdiParent = this;
            cadGrupo.Show();
        }

        private void cadastroDeCargosESaláriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmC_CargosSal cadCargosSal = new FrmC_CargosSal();
            cadCargosSal.MdiParent = this;
            cadCargosSal.Show();
        }

        private void cadastroDeContasBancáriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmC_ContaBancaria frmContaBancaria = new FrmC_ContaBancaria();
            frmContaBancaria.MdiParent = this;
            frmContaBancaria.Show();
        }

        private void mnuCadFunc_Click(object sender, EventArgs e)
        {
            FrmC_Func frmCadFunc = new FrmC_Func();
            frmCadFunc.MdiParent = this;
            frmCadFunc.Show();
        }

        private void permissõesDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBloqModulos frmPermissoes = new FrmBloqModulos();
            frmPermissoes.MdiParent = this;
            frmPermissoes.Show();
        }

        private void cadastroDeUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmC_Usuario frmC_Usuario = new FrmC_Usuario();
            frmC_Usuario.MdiParent = this;
            frmC_Usuario.Show();
        }

        private void smBloqTelasMod_Click(object sender, EventArgs e)
        {
            FrmBloqTelas frmBloqTelas = new FrmBloqTelas();
            frmBloqTelas.MdiParent = this;
            frmBloqTelas.Show();
        }

        private void bloqueioDeMódulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBloqModulos frmBloqModulos = new FrmBloqModulos();
            frmBloqModulos.MdiParent = this;
            frmBloqModulos.Show();
        }
    }
}