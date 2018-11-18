using Loja.BUSINESS;
using Loja.ENTITY;
using Loja.DATA;
using Loja.FUNCTIONS;
using System;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmC_CargosSal : Form
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        C_CargosSalariosENT cargosSalarios = new C_CargosSalariosENT();
        C_CargoSalBLL cadCargoSalBLL = new C_CargoSalBLL();

        public FrmC_CargosSal()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txtCodigo.Text = string.Empty;
            txtCodigo.Focus();
            txtCargo.Text = string.Empty;
            txtSalario.Text = string.Empty;
            txtDescricao.Text = string.Empty;
        }

        private void frmCadCargosSal_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
        }

        private void frmCadCargosSal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void grdCadFuncionarioCargoSalario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdCadCargoSal.Rows[e.RowIndex];
                txtCodigo.Text = row.Cells["Código"].Value.ToString();
                dtpDataCadastro.Value = Convert.ToDateTime(row.Cells["Data Cadastro"].Value);
                dtpDataAtualizacao.Value = Convert.ToDateTime(row.Cells["Data Atualização"].Value);
                txtCargo.Text = row.Cells["Cargo"].Value.ToString();           
                txtSalario.Text = funcoes.ConverterPontoParaVirgula(row.Cells["Salário"].Value.ToString()); 
                txtDescricao.Text = row.Cells["Descrição"].Value.ToString();
            }
        }        
        private void FrmCadCargosSal_Load(object sender, EventArgs e)
        {
            string retorno = cadCargoSalBLL.CarregarGrade(grdCadCargoSal);
            try
            {
                Convert.ToInt32(retorno);
                txtTotal.Text = retorno;
            }
            catch
            {
                MessageBox.Show("Falha ao carregar grade. "+retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }            
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {            
            funcoes.ApenasNumeros(e);
            if ((txtCodigo.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cargosSalarios.codigo = Convert.ToInt16(txtCodigo.Text);
                string retorno = cadCargoSalBLL.CarregarDados(cargosSalarios);
                if (retorno == "1")
                {
                    try
                    {
                        Convert.ToInt32(retorno);
                        PreencherTela();
                    }
                    catch
                    {
                        MessageBox.Show("Falha ao carregar os dados. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else if (retorno == "0")
                {
                    MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    MessageBox.Show("Falha ao carregar os dados. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        public void PreencherCargosSalarios()
        {
            if (txtCodigo.Text != string.Empty)
            {
                cargosSalarios.codigo = Convert.ToInt16(txtCodigo.Text);
            }
            cargosSalarios.data = dtpDataCadastro.Value;
            cargosSalarios.dataAtualizacao = dtpDataAtualizacao.Value;
            cargosSalarios.cargo = txtCargo.Text;
            cargosSalarios.salario = funcoes.ConverterVirgulaParaPonto(txtSalario.Text);
            cargosSalarios.descricao = txtDescricao.Text;            
        }

        public void PreencherTela()
        {
            if (cargosSalarios.codigo != null)
            {
                txtCodigo.Text = cargosSalarios.codigo.ToString();
            }
            dtpDataCadastro.Value = cargosSalarios.data;
            dtpDataAtualizacao.Value = cargosSalarios.dataAtualizacao;
            txtCargo.Text = cargosSalarios.cargo;
            if(cargosSalarios.salario != null)
            {
                txtSalario.Text = cargosSalarios.salario;
            }
            else
            {
                txtSalario.Text = "0.00";
            }
            txtDescricao.Text = cargosSalarios.descricao;     
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty)
            {
                DialogResult dialogo = MessageBox.Show("Deseja mesmo alterar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogo == DialogResult.Yes)
                {
                    if (txtCargo.Text == string.Empty)
                    {
                        MessageBox.Show("Informe o cargo!");
                        txtCargo.Focus();
                    }
                    else if (txtSalario.Text == string.Empty)
                    {
                        MessageBox.Show("Informe o salário!");
                        txtSalario.Focus();
                    }
                    else
                    {
                        string retorno = string.Empty;
                        try
                        {                           
                            PreencherCargosSalarios();
                            retorno = cadCargoSalBLL.Atualizar(cargosSalarios);
                            Convert.ToInt32(retorno);
                            MessageBox.Show("Registro " + retorno + " atualizado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            retorno = string.Empty;
                            retorno = cadCargoSalBLL.CarregarGrade(grdCadCargoSal);
                            Convert.ToInt32(retorno);
                            txtTotal.Text = retorno;
                            retorno = string.Empty;
                            retorno = cadCargoSalBLL.CarregarDados(cargosSalarios);
                            Convert.ToInt32(retorno);
                            PreencherTela();                            
                        }
                        catch
                        {
                            MessageBox.Show("Houve uma inconsistência ao tentar atualizar. Detalhes: "+retorno,"Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                if (txtCargo.Text == string.Empty)
                {
                    MessageBox.Show("Informe o cargo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCargo.Focus();
                }
                else if (txtSalario.Text == string.Empty)
                {
                    MessageBox.Show("Informe o salário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtSalario.Focus();
                }
                else
                {
                    string retorno = null;
                    try
                    {
                        PreencherCargosSalarios();
                        retorno = cadCargoSalBLL.ConsultarPorNome(cargosSalarios);                        
                        if(retorno != null)
                        {
                            MessageBox.Show("O cargo " + retorno + " já existe!");
                            txtCargo.Focus();
                        }
                        else
                        {
                            PreencherCargosSalarios();
                            retorno = cadCargoSalBLL.Gravar(cargosSalarios);
                            Convert.ToInt32(retorno);
                            cargosSalarios.codigo = Convert.ToInt16(retorno);
                            MessageBox.Show("Registro " + retorno + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                            retorno = cadCargoSalBLL.CarregarGrade(grdCadCargoSal);
                            Convert.ToInt32(retorno);
                            txtTotal.Text = retorno;
                            
                            retorno = cadCargoSalBLL.CarregarDados(cargosSalarios);
                            Convert.ToInt32(retorno);
                            PreencherTela();                            
                        }                        
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao gravar. Detalhes: "+retorno,"Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if ((txtCodigo.Text == string.Empty) && (txtCargo.Text == string.Empty) && (txtSalario.Text == string.Empty))
            {
                MessageBox.Show("Informe um registro para exclusão!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult dialogo = MessageBox.Show("Deseja realmente excluir este registro?", "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    string retorno = null;
                    try
                    {
                        PreencherCargosSalarios();
                        retorno = cadCargoSalBLL.Excluir(cargosSalarios);
                        Convert.ToInt32(retorno);
                        MessageBox.Show("Registro " + retorno + " excluido com sucesso!");
                        retorno = null;
                        retorno = cadCargoSalBLL.CarregarGrade(grdCadCargoSal);
                        txtTotal.Text = retorno;
                    }
                    catch
                    {
                        MessageBox.Show("Inconsistência ao carregar grade. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    LimparCampos();
                }
            }            
        }

        private void txtSalario_KeyPress(object sender, KeyPressEventArgs e)
        {
             funcoes.ApenasNumerosVirgula(e);
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (grdCadCargoSal.Rows.Count > 0)
            {
                funcoes.ExportarExcel(grdCadCargoSal, "Cadastro de Cargos e Salários");
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

