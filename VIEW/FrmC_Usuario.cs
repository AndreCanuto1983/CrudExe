using Loja.BUSINESS;
using Loja.ENTITY;
using Loja.DATA;
using Loja.FUNCTIONS;
using System;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmC_Usuario : Form
    {
        Funcoes funcoes = new Funcoes();
        C_UsuarioENT c_usuarioEnt = new C_UsuarioENT();
        C_UsuarioBLL c_usuarioBll = new C_UsuarioBLL();

        public FrmC_Usuario()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (grdC_Usuarios.Rows.Count > 0)
            {
                funcoes.ExportarExcel(grdC_Usuarios, "Cadastro de Usuários");
            }
            else
            {
                MessageBox.Show("Não há registros para exportar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAbrirGrupo_Click(object sender, EventArgs e)
        {
            FrmC_GrupoUsuario frmC_GrupoFunc = new FrmC_GrupoUsuario();
            frmC_GrupoFunc.ShowDialog();
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            if (clstEmpresa.Items.Count < 1)
            {
                MessageBox.Show("Não existe empresas para marcar","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else
            {
                funcoes.MarcarEmpresas(clstEmpresa);
            }
        }      

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            if (clstEmpresa.Items.Count < 1)
            {
                MessageBox.Show("Não existe empresas para desmarcar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                funcoes.DesmarcarEmpresas(clstEmpresa);
            }
        }
        private void LimparCampos()
        {
            txtCodigo.Text = "";
            txtCodGrupo.Text = "";
            txtGrupo.Text = "";
            txtSenha.Text = "";
            //txtTotal.Text = "";
            txtUsuario.Text = "";
            dtAtualizacao.ResetText();
            dtCadastro.ResetText();
            dtUltLogin.ResetText();
            ckbAtivo.Checked = false;
            if (clstEmpresa.Items.Count > 0)
            {
                funcoes.DesmarcarEmpresas(clstEmpresa);
            }
            txtCodigo.Focus();
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "")
            {
                MessageBox.Show("Iforme um registro para ser excluído");
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                {
                    switch (dialogo)
                    {
                        case DialogResult.Yes:
                            try
                            {
                                c_usuarioEnt.codigo = Convert.ToInt16(txtCodigo.Text);
                                string retorno = c_usuarioBll.Excluir(c_usuarioEnt);
                                Convert.ToInt16(retorno);
                                MessageBox.Show("O registro " + retorno + " foi excluído com sucesso!");
                                LimparCampos();
                                retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
                                Convert.ToInt16(retorno);
                                txtTotal.Text = retorno;
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Falha:" + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            break;
                    }
                }
            }
        }
        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    LimparCampos();
                    break;

                case Keys.F2:
                    FrmPesquisar frmPesquisar = new FrmPesquisar();
                    frmPesquisar.buscar = "Usuario"; //passo o que deve ser pesquisado para a pesquisa genérica
                    frmPesquisar.ShowDialog();
                    try
                    {
                        string codigo = frmPesquisar.codigo;
                        if (codigo != null)
                        {
                            txtCodigo.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                            PreencherUsuario();
                            c_usuarioBll.BuscarPorCodigo(c_usuarioEnt); //chamo o método de buscar funcionário e passo o func que será pesquisado
                            LimparCampos();                            
                            CarregarTela(); //chamo o método de carregar o funcionário pesquisado pelo método anterior
                            funcoes.MarcarEmpresaDoUsuario(clstEmpresa, txtCodigo.Text);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Clear();
                    }
                    break;
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtCodigo.Text != "") && (e.KeyChar == (char)Keys.Enter))
            {
                string retorno = "";
                try
                {
                    c_usuarioEnt.codigo = Convert.ToInt16(txtCodigo.Text);
                    retorno = c_usuarioBll.BuscarPorCodigo(c_usuarioEnt);
                    Convert.ToInt16(retorno);
                    if (c_usuarioEnt.usuario == "")
                    {
                        MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LimparCampos();
                    }
                    else
                    {
                        LimparCampos();
                        CarregarTela();
                        funcoes.MarcarEmpresaDoUsuario(clstEmpresa,txtCodigo.Text);
                    }
                }
                catch
                {
                    MessageBox.Show("Falha: " + retorno);
                }

            }
        }

        private void FrmC_Usuario_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
            switch (e.KeyCode)
            {
                ///case Keys.Delete:
                // LimparCampos();                    
                //break;
                case Keys.Escape:
                    this.Dispose();
                    break;
            }
        }

        private void PreencherUsuario()
        {
            //preencho a classe C_UsuarioENT
            if (txtCodigo.Text != "")
            {
                c_usuarioEnt.codigo = Convert.ToInt16(txtCodigo.Text);
            }
            c_usuarioEnt.data_atualizacao = dtAtualizacao.Value;
            c_usuarioEnt.data_cadastro = dtCadastro.Value;
            c_usuarioEnt.data_ult_login = dtUltLogin.Value;
            c_usuarioEnt.usuario = txtUsuario.Text;
            c_usuarioEnt.senha = txtSenha.Text;
            c_usuarioEnt.codigo_grupo = txtCodGrupo.Text;
            c_usuarioEnt.grupo = txtGrupo.Text;
            c_usuarioEnt.ativo = Convert.ToBoolean(ckbAtivo.CheckState);
            c_usuarioEnt.maquina = funcoes.VerificarMaquina();
            c_usuarioEnt.versao = funcoes.GetVersion();
            
        }
        private void CarregarTela()
        {
            //Exibo os dados na tela
            txtCodigo.Text = c_usuarioEnt.codigo.ToString();
            dtAtualizacao.Value = c_usuarioEnt.data_atualizacao;
            dtCadastro.Value = c_usuarioEnt.data_cadastro;
            dtUltLogin.Value = c_usuarioEnt.data_ult_login;
            txtUsuario.Text = c_usuarioEnt.usuario;
            txtSenha.Text = c_usuarioEnt.senha;
            txtCodGrupo.Text = c_usuarioEnt.codigo_grupo;
            txtGrupo.Text = c_usuarioEnt.grupo;
            switch (c_usuarioEnt.ativo)
            {
                case true:
                    ckbAtivo.Checked = true;
                    break;
                case false:
                    ckbAtivo.Checked = false;
                    break;
            }
        }

        private void brnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "") //rotina para atualizar
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente alterar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    if (txtUsuario.Text == "")
                    {
                        MessageBox.Show("Informe o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtUsuario.Focus();
                    }
                    else if (txtSenha.Text == "")
                    {
                        MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSenha.Focus();
                    }
                    else if (txtCodGrupo.Text == "")
                    {
                        MessageBox.Show("Informe o grupo.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCodGrupo.Focus();
                    }
                    else if(clstEmpresa.CheckedItems.Count < 1)
                    {
                        MessageBox.Show("Marque ao menos uma empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        clstEmpresa.Focus();
                    }
                    else
                    {                        
                        string retorno = "";
                        try
                        {
                            funcoes.PreencherListaEmpresasDoUsuario(c_usuarioEnt, clstEmpresa); //esta funcção pega as empresas do usuário
                            PreencherUsuario();
                            retorno = c_usuarioBll.Atualizar(c_usuarioEnt);
                            Convert.ToInt16(retorno);
                            MessageBox.Show("Registro " + retorno + " alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            retorno = string.Empty;
                            retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
                            Convert.ToInt16(retorno);
                            txtTotal.Text = retorno;
                        }
                        catch
                        {
                            MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else //(dialogo == DialogResult.No)
                {
                    txtCodigo.Focus();
                }
            }
            else if (txtCodigo.Text == "") //rotina para gravar
            {
                if (txtUsuario.Text == "")
                {
                    MessageBox.Show("Informe o usuário.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                }
                else if (txtSenha.Text == "")
                {
                    MessageBox.Show("Informe a senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSenha.Focus();
                }
                else if (txtCodGrupo.Text == "" || txtGrupo.Text == "")
                {
                    MessageBox.Show("Informe o grupo corretamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodGrupo.Focus();
                }
                else if (clstEmpresa.CheckedItems.Count < 1)
                {
                    MessageBox.Show("Marque ao menos uma empresa.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clstEmpresa.Focus();
                }
                else
                {
                    
                    try
                    {
                        PreencherUsuario();
                        string retorno = c_usuarioBll.BuscarPorNome(c_usuarioEnt);
                        if (retorno == "1")
                        {
                            try
                            {
                                Convert.ToInt16(retorno);
                                MessageBox.Show("O usuário: " + c_usuarioEnt.usuario + ", já existe no banco de dados e está cadastrado com o código "+c_usuarioEnt.codigo+".", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCodigo.Focus();
                            }
                            catch
                            {
                                MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (retorno == "0" || retorno != "1")
                        {
                            retorno = "";                            
                            try
                            {
                                funcoes.PreencherListaEmpresasDoUsuario(c_usuarioEnt, clstEmpresa); //esta funcção pega as empresas do usuário
                                retorno = c_usuarioBll.Gravar(c_usuarioEnt);
                                Convert.ToInt16(retorno);
                                txtCodigo.Text = retorno.ToString();
                                MessageBox.Show("Registro " + retorno + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                retorno = "";
                                retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
                                Convert.ToInt16(retorno);
                                txtTotal.Text = retorno;
                            }
                            catch
                            {
                                MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Falha: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }

        }

        private void grdC_Usuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimparCampos();
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdC_Usuarios.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Código"].Value.ToString();
                funcoes.MarcarEmpresaDoUsuario(clstEmpresa,txtCodigo.Text); //preencho a list empresa 
                txtUsuario.Text = row.Cells["Usuário"].Value.ToString();
                txtSenha.Text = row.Cells["Senha"].Value.ToString();
                txtCodGrupo.Text = row.Cells["Cód Grupo"].Value.ToString();
                txtGrupo.Text = row.Cells["Grupo"].Value.ToString();
                dtCadastro.Value = Convert.ToDateTime(row.Cells["Data Cadastro"].Value);
                dtAtualizacao.Value = Convert.ToDateTime(row.Cells["Data Atualização"].Value);
                dtUltLogin.Value = Convert.ToDateTime(row.Cells["Último Acesso"].Value);
                ckbAtivo.Checked = Convert.ToBoolean(row.Cells["Ativo"].Value);
            }
        }

        private void FrmC_Usuario_Load(object sender, EventArgs e)
        {
            string retorno = c_usuarioBll.CarregarGrade(grdC_Usuarios);
            try
            {
                Convert.ToInt16(retorno);
                txtTotal.Text = retorno.ToString();
                grdC_Usuarios.Columns["Senha"].Visible = false; //oculto a coluna senha
            }
            catch
            {
                MessageBox.Show("Ocorreu uma falha ao carregar a grade: \n" + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            int contador = funcoes.PreencherTodasEmpresas(clstEmpresa); //preencho a empresa gerencial   
        }

        private void txtGrupo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            C_GrupoUsuarioENT c_grupoUsuarioEnt = new C_GrupoUsuarioENT();
            C_GrupoUsuarioBLL c_grupoUsuarioBll = new C_GrupoUsuarioBLL();
            funcoes.ApenasNumeros(e);
            if ((txtCodGrupo.Text != "") && (e.KeyChar == (char)Keys.Enter))
            {
                c_grupoUsuarioEnt.codigo = Convert.ToInt16(txtCodGrupo.Text);
                string retorno = c_grupoUsuarioBll.ConsultarPorCodigo(c_grupoUsuarioEnt);
                if (retorno == "0")
                {
                    MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodGrupo.Clear();
                    txtGrupo.Clear();
                }
                else
                {
                    txtCodGrupo.Text = c_grupoUsuarioEnt.codigo.ToString();
                    txtGrupo.Text = c_grupoUsuarioEnt.grupo;
                }
            }
        }

        private void txtGrupo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Back:
                    txtCodGrupo.Text = "";
                    txtGrupo.Text = "";
                    break;
                case Keys.Delete:
                    txtCodGrupo.Text = "";
                    txtGrupo.Text = "";
                    break;
            }
            if (e.KeyCode == Keys.F2)
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "GrupoUsuario"; //passo o que deve ser pesquisado para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        C_GrupoUsuarioENT c_grupoUsuarioEnt = new C_GrupoUsuarioENT();
                        C_GrupoUsuarioBLL c_grupoUsuarioBll = new C_GrupoUsuarioBLL();
                        txtCodGrupo.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        c_grupoUsuarioEnt.codigo = Convert.ToInt16(txtCodGrupo.Text);
                        string retorno = c_grupoUsuarioBll.ConsultarPorCodigo(c_grupoUsuarioEnt);
                        Convert.ToInt16(retorno);
                        txtCodGrupo.Text = c_grupoUsuarioEnt.codigo.ToString();
                        txtGrupo.Text = c_grupoUsuarioEnt.grupo;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Falha: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Clear();
                }
            }
        }
    }
}