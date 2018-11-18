using Loja.BUSINESS;
using Loja.ENTITY;
using Loja.DATA;
using Loja.FUNCTIONS;
using System;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmC_ContaBancaria : Form
    {
        Funcoes funcoes = new Funcoes();
        Conexao conexao = new Conexao();
        C_ContaBancariaENT c_contaBancariaEnt = new C_ContaBancariaENT();
        C_ContaBancariaBLL c_contaBancariaBll = new C_ContaBancariaBLL();

        public FrmC_ContaBancaria()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            dtpDataCadastro.ResetText();
            dtpDataAtualizacao.ResetText();
            cboEmpresa.SelectedIndex = -1; //limpar combobox sem perder o list
            cboBanco.SelectedIndex = -1;
            txtAgencia.Text = string.Empty;
            txtContaCorrente.Text = string.Empty;
            cboTipoConta.SelectedIndex = -1;
            txtSaldo.Text = string.Empty;
        }

        private void FrmCadContaBancaria_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void FrmCadContaBancaria_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
        }

        private void grdContaBancaria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdContaBancaria.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Código"].Value.ToString();
                dtpDataCadastro.Value = Convert.ToDateTime(row.Cells["Data Cadastro"].Value);
                dtpDataAtualizacao.Value = Convert.ToDateTime(row.Cells["Data Atualização"].Value);
                cboEmpresa.SelectedValue = row.Cells["Cód. Empresa"].Value.ToString();
                cboBanco.SelectedValue = row.Cells["Cód. Banco"].Value.ToString();
                txtAgencia.Text = row.Cells["Agência"].Value.ToString();
                txtContaCorrente.Text = row.Cells["Conta Corrente"].Value.ToString();
                cboTipoConta.SelectedValue = row.Cells["Cód. Tipo Conta"].Value.ToString();
                txtSaldo.Text = funcoes.ConverterPontoParaVirgula(row.Cells["Saldo"].Value.ToString());
            }
        }

        private void txtAgencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumerosTracos(e);
            txtAgencia.Focus();
        }

        private void txtContaCorrente_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumerosTracos(e);
            txtContaCorrente.Focus();
        }

        private void FrmCadContaBancaria_Load(object sender, EventArgs e)
        {
            string retorno = c_contaBancariaBll.CarregarGrade(grdContaBancaria);
            try
            {
                Convert.ToInt32(retorno);
                txtTotal.Text = retorno.ToString();
            }
            catch
            {
                MessageBox.Show("Inconsistência ao carregar a grade: " + retorno, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            conexao.PreencherCombo(cboEmpresa, "Empresa", "Codigo", "Fantasia"); //método genérico de carregar combobox
            conexao.PreencherCombo(cboBanco, "Financeiro_Banco", "Codigo", "Banco");
            conexao.PreencherCombo(cboTipoConta, "Financeiro_Tipo_Conta_Bancaria", "Codigo", "Tipo_Conta");
        }

        public void PreencherContaBancaria()
        {
            if(txtCodigo.Text != string.Empty)
            {
                c_contaBancariaEnt.codigo = Convert.ToInt64(txtCodigo.Text);
            }            
            c_contaBancariaEnt.dataCadastro = dtpDataCadastro.Value;
            c_contaBancariaEnt.dataAtualizacao = dtpDataAtualizacao.Value;
            c_contaBancariaEnt.empresa = Convert.ToInt32(cboEmpresa.SelectedValue);
            c_contaBancariaEnt.banco = Convert.ToInt32(cboBanco.SelectedValue);
            c_contaBancariaEnt.agencia = txtAgencia.Text;
            c_contaBancariaEnt.contaCorrente = txtContaCorrente.Text;
            c_contaBancariaEnt.tipoConta = Convert.ToInt32(cboTipoConta.SelectedValue);
            if (txtSaldo.Text == string.Empty)
            { c_contaBancariaEnt.saldo = "0"; txtSaldo.Text = "0,00"; }
            else
            { c_contaBancariaEnt.saldo = funcoes.ConverterVirgulaParaPonto(txtSaldo.Text); }
        }

        public void PreencherTela()
        {
            txtCodigo.Text = c_contaBancariaEnt.codigo.ToString();
            dtpDataCadastro.Value = c_contaBancariaEnt.dataCadastro;
            dtpDataAtualizacao.Value = c_contaBancariaEnt.dataAtualizacao;
            cboEmpresa.SelectedValue = c_contaBancariaEnt.empresa;
            cboBanco.SelectedValue = c_contaBancariaEnt.banco;
            txtAgencia.Text = c_contaBancariaEnt.agencia;
            txtContaCorrente.Text = c_contaBancariaEnt.contaCorrente;
            cboTipoConta.SelectedValue = c_contaBancariaEnt.tipoConta;
            if (c_contaBancariaEnt.saldo != null)
            { txtSaldo.Text = funcoes.ConverterPontoParaVirgula(c_contaBancariaEnt.saldo); }
            else
            { txtSaldo.Text = "0,00"; }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e) //ao inserir o código carrego a tela
        {
            funcoes.ApenasNumeros(e);            
            if ((txtCodigo.Text != "") && (e.KeyChar == (char)Keys.Enter))
            {
                c_contaBancariaEnt.codigo = Convert.ToInt64(txtCodigo.Text);
                string retorno = c_contaBancariaBll.CarregarDados(c_contaBancariaEnt);
                if (retorno == "1")
                {
                    try
                    {
                        Convert.ToInt32(retorno);                        
                        PreencherTela();
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao carregar os dados. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (retorno == "0")
                {
                    MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Inconsitêcia ao carregar os dados. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) && (txtContaCorrente.Text == string.Empty))
            {
                MessageBox.Show("Informe um registro para exclusão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    PreencherContaBancaria();
                    string retornoDel = c_contaBancariaBll.Deletar(c_contaBancariaEnt);
                    string retornoGrade = c_contaBancariaBll.CarregarGrade(grdContaBancaria);
                    try
                    {
                        Convert.ToInt32(retornoDel);
                        MessageBox.Show("O registro " + c_contaBancariaEnt.codigo + " foi excluído com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Convert.ToInt32(retornoGrade);
                        txtTotal.Text = retornoGrade.ToString();
                        LimparCampos();
                        txtCodigo.Focus();
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao atualizar a grade. Detalhes: " + retornoGrade, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    if(cboEmpresa.SelectedIndex < 1)
                    {
                        MessageBox.Show("Informe a empresa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboEmpresa.Focus();
                    }
                    else if (cboBanco.SelectedIndex < 1)
                    {
                        MessageBox.Show("Informe o banco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboBanco.Focus();
                    }
                    else if (txtAgencia.Text == string.Empty)
                    {
                        MessageBox.Show("Informe a agência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAgencia.Focus();
                    }
                    else if (txtContaCorrente.Text == string.Empty)
                    {
                        MessageBox.Show("Informe a conta corrente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtContaCorrente.Focus();
                    }
                    else if (cboTipoConta.SelectedIndex < 1)
                    {
                        MessageBox.Show("Informe o tipo da conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboTipoConta.Focus();
                    }
                    else
                    {
                        string retorno = null;                 
                        try
                        {
                            PreencherContaBancaria();
                            retorno = c_contaBancariaBll.Atualizar(c_contaBancariaEnt);
                            Convert.ToInt32(retorno);
                            MessageBox.Show("Registro " + retorno + " alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            retorno = "";
                            retorno = c_contaBancariaBll.CarregarDados(c_contaBancariaEnt);
                            PreencherTela();
                            retorno = "";
                            retorno = c_contaBancariaBll.CarregarGrade(grdContaBancaria);
                            Convert.ToInt32(retorno);
                            txtTotal.Text = retorno;
                        }
                        catch
                        {
                            MessageBox.Show("Não foi possível atualizar. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (cboEmpresa.SelectedIndex < 1)
                {
                    MessageBox.Show("Informe a empresa!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboEmpresa.Focus();
                }
                else if (cboBanco.SelectedIndex < 1)
                {
                    MessageBox.Show("Informe o banco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboBanco.Focus();
                }
                else if (txtAgencia.Text == string.Empty)
                {
                    MessageBox.Show("Informe a agência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtAgencia.Focus();
                }
                else if (txtContaCorrente.Text == string.Empty)
                {
                    MessageBox.Show("Informe a conta corrente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtContaCorrente.Focus();
                }
                else if (cboTipoConta.SelectedIndex < 1)
                {
                    MessageBox.Show("Informe o tipo da conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboTipoConta.Focus();
                }
                else
                {
                    try
                    {
                        PreencherContaBancaria();
                        string retorno = c_contaBancariaBll.ConsultarGravado(c_contaBancariaEnt);
                        if (retorno == "1")
                        {
                            try
                            {
                                Convert.ToInt32(retorno);
                                MessageBox.Show("A conta corrente: " + c_contaBancariaEnt.contaCorrente + " já foi gravado!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtContaCorrente.Focus();
                            }
                            catch
                            {
                                MessageBox.Show("Houve uma Inconsistência: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else if (retorno == "0" || retorno != "1")
                        {
                            retorno = string.Empty;
                            retorno = c_contaBancariaBll.Gravar(c_contaBancariaEnt);
                            try
                            {
                                Convert.ToInt32(retorno);
                                txtCodigo.Text = retorno.ToString();
                                MessageBox.Show("Registro " + retorno + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                retorno = string.Empty;
                                retorno = c_contaBancariaBll.CarregarGrade(grdContaBancaria);
                                Convert.ToInt32(retorno);
                                txtTotal.Text = retorno;
                            }
                            catch
                            {
                                MessageBox.Show("Não foi possível gravar. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Houve uma Inconsistência: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void txtSaldo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.VerificarDigitoDecimal(e, txtSaldo);
            funcoes.ApenasNumerosPonto(e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (grdContaBancaria.Rows.Count > 0)
            {
                funcoes.ExportarExcel(grdContaBancaria, "Cadastro de Contas Bancárias");
            }
            else
            {
                MessageBox.Show("Não há registros para expotar!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
            }
        }
    }
}
