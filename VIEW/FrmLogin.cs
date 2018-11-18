using Loja.BUSINESS;
using Loja.ENTITY;
using Loja.FUNCTIONS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmLogin : Form
    {
        Funcoes funcoes = new Funcoes();
        LoginBLL loginBll = new LoginBLL();
        LoginENT loginEnt = new LoginENT();
        string maquina = "";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtUsuario.Focus();
            //funcoes.LetrasMaiusculas(e, txtUsuario); //converter texto para caixa alta
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            string retorno = string.Empty;
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Informe o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == string.Empty)
            {
                MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtSenha.Focus();
            }
            else
            {
                loginEnt.usuario = txtUsuario.Text;
                loginEnt.senha = txtSenha.Text;
                try
                {
                    retorno = loginBll.VerificarUsuarioDoLogin(loginEnt); //verifico e ja preencho o loginEnt
                    Convert.ToInt16(retorno);
                    if (retorno == "0")
                    {
                        MessageBox.Show("Informe um usuário e senha válidos!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                    }
                    if (retorno == "1")
                    {
                        if ((loginEnt.usuario == txtUsuario.Text) && (loginEnt.senha == txtSenha.Text))
                        {
                            if ((maquina != "ALCS-PC") && (maquina != "EDNA-PC"))
                            {
                                MessageBox.Show("Sua máquina não tem permissão para acesso! Favor contatar o administrador do sistema através do telefone: (16)99799-5718.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                            else
                            {
                                if (loginEnt.ativo == false)
                                {
                                    MessageBox.Show("O usuário: " + loginEnt.usuario + ", está inativo no sistema e não poderá logar até que o administrador reative.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    txtUsuario.Focus();
                                }
                                else
                                {
                                    try
                                    {
                                        loginEnt.versao = funcoes.GetVersion();
                                        loginEnt.data_ult_login = DateTime.Now;
                                        loginEnt.maquina = maquina;
                                        retorno = "";
                                        retorno = loginBll.InserirUsuarioNaTemp(loginEnt);
                                        Convert.ToInt32(retorno); //se não conseguir converter é pq deu erro    
                                        retorno = "";
                                        retorno = loginBll.AtualizarUsuarioLogado(loginEnt);
                                        Convert.ToInt32(retorno); //se não conseguir converter é pq deu erro    
                                        FrmMDI principal = new FrmMDI();
                                        principal.Show();
                                        this.Hide();
                                    }
                                    catch
                                    {
                                        MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                }
                            }
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void Login_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.Text = "Login - Versão: " + funcoes.GetVersion();
            maquina = funcoes.VerificarMaquina();
        }
    }
}