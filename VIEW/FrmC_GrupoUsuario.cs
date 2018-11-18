using Loja.BUSINESS;
using Loja.ENTITY;
using System;
using System.Windows.Forms;
using Loja.FUNCTIONS;

namespace Loja.VIEW
{
    public partial class FrmC_GrupoUsuario : Form
    {
        C_GrupoUsuarioENT funcionarioGrupo = new C_GrupoUsuarioENT();
        C_GrupoUsuarioBLL cadFuncGrupoBLL = new C_GrupoUsuarioBLL();
        Funcoes funcoes = new Funcoes();
        public FrmC_GrupoUsuario()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtCodigo.Clear();
            txtGrupo.Clear();
        }

        public void PreencherGrupo()
        {
            funcionarioGrupo.codigo = Convert.ToInt16(txtCodigo.Text);
            funcionarioGrupo.grupo = txtGrupo.Text;
        }

        public void PreencherTela()
        {
            txtCodigo.Text = funcionarioGrupo.codigo.ToString();
            txtGrupo.Text = funcionarioGrupo.grupo;
        }

        private void CadPerfilFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void grdCadPerfil_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdCadFuncGrupo.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Código"].Value.ToString();
                txtGrupo.Text = row.Cells["Grupo"].Value.ToString();
            }
        }

        private void CadPerfilFunc_Load(object sender, EventArgs e)
        {
            string retorno = cadFuncGrupoBLL.CarregarGrade(grdCadFuncGrupo);
            try
            {
                Convert.ToInt32(retorno);
                txtTotal.Text = retorno.ToString();
            }
            catch
            {
                MessageBox.Show("Inconsistência ao carregar a grade: " + retorno);
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtCodigo.Text != "") && (e.KeyChar == (char)Keys.Enter))
            {
                funcionarioGrupo.codigo = Convert.ToInt16(txtCodigo.Text);
                string retorno = cadFuncGrupoBLL.ConsultarPorCodigo(funcionarioGrupo);
                if (retorno == "1")
                {
                    try
                    {
                        Convert.ToInt32(retorno);
                        PreencherTela();
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao carregar os dados. Detalhes: " + retorno, "Possível falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (retorno == "0")
                {
                    MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Inconsitêcia ao carregar os dados. Detalhes: " + retorno, "Possível falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) && (txtGrupo.Text == string.Empty))
            {
                MessageBox.Show("Informe um registro para exclusão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    PreencherGrupo();
                    string retornoDel = cadFuncGrupoBLL.Excluir(funcionarioGrupo);
                    string retornoGrade = cadFuncGrupoBLL.CarregarGrade(grdCadFuncGrupo);
                    try
                    {
                        Convert.ToInt32(retornoDel);
                        MessageBox.Show("O registro " + funcionarioGrupo.codigo + " foi excluído com sucesso!","Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Convert.ToInt32(retornoGrade);
                        txtTotal.Text = retornoGrade.ToString();
                        LimparCampos();
                        txtCodigo.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao atualizar a grade. Detalhes: " + retornoGrade);
                    }
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente alterar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dialogo == DialogResult.Yes)
                {
                    if (txtGrupo.Text == string.Empty)
                    {
                        MessageBox.Show("Informe o Grupo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGrupo.Focus();
                    }
                    else
                    {
                        string retorno = string.Empty;
                        try
                        {
                            PreencherGrupo();
                            retorno = cadFuncGrupoBLL.Atualizar(funcionarioGrupo);
                            Convert.ToInt32(retorno);
                            MessageBox.Show("Registro " + retorno + " alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            retorno = string.Empty;
                            retorno = cadFuncGrupoBLL.CarregarGrade(grdCadFuncGrupo);
                            Convert.ToInt32(retorno);
                            txtTotal.Text = retorno;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível atualizar. Detalhes: " + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                else //(dialogo == DialogResult.No)
                {
                    txtCodigo.Focus();
                }
            }
            else if (txtCodigo.Text == string.Empty)
            {
                if (txtGrupo.Text == string.Empty)
                {
                    MessageBox.Show("Informe o grupo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtGrupo.Focus();
                }
                else
                {
                    try
                    {
                        funcionarioGrupo.grupo = txtGrupo.Text;
                        string retorno = cadFuncGrupoBLL.ConsultarPorNome(funcionarioGrupo);
                        if (retorno == "1")
                        {
                            try
                            {
                                Convert.ToInt32(retorno);
                                MessageBox.Show("O grupo: " + funcionarioGrupo.grupo + " já foi gravado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtGrupo.Focus();
                            }
                            catch
                            {
                                MessageBox.Show("Houve uma Inconsistência: " + retorno, "Possível falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (retorno == "0" || retorno != "1")
                        {
                            retorno = string.Empty;
                            retorno = cadFuncGrupoBLL.Gravar(funcionarioGrupo);
                            try
                            {
                                Convert.ToInt32(retorno);
                                txtCodigo.Text = retorno.ToString();
                                MessageBox.Show("Registro " + retorno + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                retorno = string.Empty;
                                retorno = cadFuncGrupoBLL.CarregarGrade(grdCadFuncGrupo);
                                Convert.ToInt32(retorno);
                                txtTotal.Text = retorno;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possível gravar. Detalhes: " + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Houve uma Inconsistência: " + ex.Message, "Possível falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void FrmCadGrupoFunc_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (grdCadFuncGrupo.Rows.Count > 0)
            {
                funcoes.ExportarExcel(grdCadFuncGrupo, "Cadastro de Grupo de Funcionário");
            }
            else
            {
                MessageBox.Show("Não há registros para expotar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    LimparCampos();
                    break;
                case Keys.Back:
                    txtGrupo.Text = "";
                    break;
            }
        }
    }
}