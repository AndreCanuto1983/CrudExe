using System;
using System.Windows.Forms;
using Loja.DATA;
using Loja.FUNCTIONS;
using Loja.ENTITY;
using Loja.BUSINESS;
using System.Data.SqlTypes;
using System.IO;

namespace Loja.VIEW
{
    public partial class FrmC_Func : Form
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        LoginENT loginEnt = new LoginENT();
        C_FuncionarioENT c_funcionarioEnt = new C_FuncionarioENT();
        PesquisarBLL pesquisarBLL = new PesquisarBLL();
        C_FuncBLL cadFuncBLL = new C_FuncBLL();
        string imagemPadrao = @"E:\Sistema\Repositorio\Loja\IMAGENS\PNG\usuario.png";
              
        public FrmC_Func()
        {
            InitializeComponent();
        }

        private void DesabilitarCheckedData()
        {
            dtpDataNascimento.Checked = false;
            dtpAdmissao.Checked = false;
            dtpExameMedico.Checked = false;
            dtpInicioExperiencia.Checked = false;
            dtpFimExperiencia.Checked = false;
            dtpProrrogacaoAte.Checked = false;
            dtpDemissao.Checked = false;
            dtpCtpsEmissao.Checked = false;
            dtpPisEmissao.Checked = false;
            dtpCnhValidade.Checked = false;
            dtpCnhEmissao.Checked = false;
            dtpCursoInicio.Checked = false;
            dtpCursoTermino.Checked = false;
        }

        int contador;
        private void FrmCadFunc_Load(object sender, EventArgs e)
        {
            loginEnt.maquina = funcoes.VerificarMaquina(); //preencho para poder verificar o usuário logado
            funcoes.VerificarLogadoPorMarquina(loginEnt);
            DesabilitarCheckedData();
            conexao.PreencherCombo(cboSituacao, "Funcionario_Situacao", "Codigo", "Situacao");
            conexao.PreencherCombo(cboGenero, "Genero", "Codigo", "Genero");
            conexao.PreencherCombo(cboEmpresaContratual, "Empresa", "Codigo", "Fantasia");
            conexao.PreencherCombo(cboEmpresaContratual, "Empresa", "Codigo", "Fantasia");
            contador = funcoes.PreencherTodasEmpresas(clstEmpGerencial); //preencho a empresa gerencial              
            txtCodigo.Focus();
            if (File.Exists(imagemPadrao)) //se o diretório da imagem existir eu informo para o componente abaixo
            {
                imgFuncionario.ImageLocation = imagemPadrao;
            }
            //Se diferente de verdadeiro  
            //if (!File.Exists("Destino do arquivo"))
            //{
            //    Cria o arquivo
            //    File.Copy("Caminho do arquivo", "Destino do arquivo");
            //}
        }

        private void FrmCadFunc_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void FrmCadFunc_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    this.Dispose();
                    break;
            }
        }

        private void btnMarcarTodos_Click(object sender, EventArgs e)
        {
            if(clstEmpGerencial.Items.Count < 1)
            {
                MessageBox.Show("Não existem empresas para marcar");
            }
            else
            {
                funcoes.MarcarEmpresas(clstEmpGerencial);
            }            
        }

        private void btnDesmarcarTodos_Click(object sender, EventArgs e)
        {
            if (clstEmpGerencial.Items.Count < 1)
            {
                MessageBox.Show("Não existem empresas para desmarcar");
            }
            else
            {
                funcoes.DesmarcarEmpresas(clstEmpGerencial);
            }
        }

        public void LimparCampos()
        {
            txtCodigo.Clear();
            txtCodigo.Focus();
            dtpDataCadastro.ResetText();
            dtpDataUltimaAt.ResetText();
            dtpDataNascimento.ResetText();
            dtpDataNascimento.Checked = false;
            txtNome.Clear();
            txtCpf.Clear();
            txtRg.Clear();
            cboSituacao.SelectedValue = -1;
            cboGenero.SelectedValue = -1;
            cboEmpresaContratual.SelectedValue = -1;
            for (int count = contador - 1; count > -1; count--) //coloco contador -1 para desconsiderar a opção todos do listbox
            {
                clstEmpGerencial.SetItemChecked(count, false);
            }
            imgFuncionario.ImageLocation = imagemPadrao;
            txtTelefone.Clear();
            txtCelular.Clear();
            txtEmail.Clear();
            txtEndereco.Clear();
            txtNumero.Clear();
            txtBairro.Clear();
            txtCep.Clear();
            txtComplemento.Clear();
            txtCidade.Clear();
            txtCidade1.Clear();
            txtEstado.Clear();
            txtEstado1.Clear();
            txtPais.Clear();
            txtPais1.Clear();
            txtNomePai.Clear();
            txtNomeMae.Clear();
            txtRacaCor.Clear();
            txtRacaCor1.Clear();
            txtEstadoCivil.Clear();
            rdbDeficienciaSim.Checked = false;
            rdbDeficienciaNao.Checked = true;
            txtTipoDeficiencia.Clear();
            txtTipoDeficiencia1.Clear();
            txtCtps.Clear();
            txtCtpsSerie.Clear();
            txtCtpsUf.Clear();
            dtpCtpsEmissao.ResetText();
            dtpCtpsEmissao.Checked = false;
            txtCtpsOrgaoExpedidor.Clear();
            txtPisPasep.Clear();
            dtpPisEmissao.ResetText();
            dtpPisEmissao.Checked = false;
            txtTituloEleitor.Clear();
            txtTituloZona.Clear();
            txtTituloSecao.Clear();
            txtReservistaNr.Clear();
            txtReservistaRa.Clear();
            txtCnh.Clear();
            dtpCnhValidade.ResetText();
            dtpCnhValidade.Checked = false;
            txtCnhOrgaoExpedidor.Clear();
            txtCnhCategoria.Clear();
            dtpCnhEmissao.ResetText();
            dtpCnhEmissao.Checked = false;
            dtpAdmissao.ResetText();
            dtpAdmissao.Checked = false;
            dtpExameMedico.ResetText();
            dtpExameMedico.Checked = false;
            dtpInicioExperiencia.ResetText();
            dtpInicioExperiencia.Checked = false;
            dtpFimExperiencia.ResetText();
            dtpFimExperiencia.Checked = false;
            dtpProrrogacaoAte.ResetText();
            dtpProrrogacaoAte.Checked = false;
            txtObservacao.Clear();
            rdbDemitidoSim.Checked = false;
            rdbDemitidoNao.Checked = true;
            dtpDemissao.ResetText();
            dtpDemissao.Checked = false;
            txtMotivoDemissao.Clear();
            txtRescisaoCaged.Clear();
            txtRescisaoCaged1.Clear();
            txtCargo.Clear();
            txtCargo1.Clear();
            txtSalario.Clear();
            txtTipoContrato.Clear();
            txtTipoContrato1.Clear();
            txtAdmissaoCaged.Clear();
            txtAdmissaoCaged1.Clear();
            txtSetor.Clear();
            txtSetor1.Clear();
            txtDepartamento.Clear();
            txtDepartamento1.Clear();
            txtGrupoFuncionario.Clear();
            txtGrupoFuncionario1.Clear();
            txtBanco.Clear();
            txtBanco1.Clear();
            txtAgencia.Clear();
            txtNumeroConta.Clear();
            txtTipoConta.Clear();
            txtTipoConta1.Clear();
            txtGrauInstrucao.Clear();
            txtGrauInstrucao1.Clear();
            txtInstituicaoEnsino.Clear();
            txtCurso.Clear();
            dtpCursoInicio.ResetText();
            dtpCursoInicio.Checked = false;
            dtpCursoTermino.ResetText();
            dtpCursoTermino.Checked = false;
            txtCursoOutros.Clear();
            lblInformativa1.Text = string.Empty;
            lblInformativa1.Visible = false;
            lblInformativa2.Text = string.Empty;
            lblInformativa2.Visible = false;
            abaCadFuncionario.SelectedIndex = 0;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            odlgCadFunc.FileName = "";
            imgFuncionario.ImageLocation = imagemPadrao;
        }

        private void txtCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtCidade.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Cidade(txtCidade, txtCidade1);
            }
            if (e.KeyChar == (char)Keys.Back)
            {
                txtCidade1.Text = string.Empty;
            }
        }
        private void txtCidade_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                try
                {
                    FrmPesquisar frmPesquisar = new FrmPesquisar();
                    frmPesquisar.buscar = "Cidade"; //passo o que deve ser pesquisado para a pesquisa genérica
                    frmPesquisar.ShowDialog();
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtCidade.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Cidade(txtCidade, txtCidade1);
                    }
                    else
                    {
                        txtCidade.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCidade.Clear();
                    txtCidade1.Clear();
                }
            }
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtCodigo.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                c_funcionarioEnt.LimparFuncionario();
                c_funcionarioEnt.codigo = Convert.ToInt64(txtCodigo.Text);
                cadFuncBLL.BuscarFuncionario(c_funcionarioEnt);
                if (c_funcionarioEnt.nome == string.Empty && c_funcionarioEnt.cpf == string.Empty || c_funcionarioEnt.nome == null && c_funcionarioEnt.cpf == null)
                {
                    MessageBox.Show("Registro inexistente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
                else
                {
                    CarregarTela();
                }
            }
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Funcionario"; //passo o que deve ser pesquisado para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtCodigo.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        PreencherFuncionario();
                        cadFuncBLL.BuscarFuncionario(c_funcionarioEnt); //chamo o método de buscar funcionário e passo o func que será pesquisado
                        CarregarTela(); //chamo o método de carregar o funcionário pesquisado pelo método anterior
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCodigo.Clear();
                }
            }
        }

        private void txtEstado_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtEstado.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Estado(txtEstado, txtEstado1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtEstado1.Text = string.Empty;
            }
        }

        private void txtEstado_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Estado"; //passo o que deve ser pesquisado para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtEstado.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Estado(txtEstado, txtEstado1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtEstado.Clear();
                    txtEstado1.Clear();
                }
            }
        }

        private void txtPais_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtPais.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Pais(txtPais, txtPais1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtPais1.Text = string.Empty;
            }
        }

        private void txtPais_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Pais"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtPais.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Pais(txtPais, txtPais1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPais.Clear();
                    txtPais1.Clear();
                }
            }
        }

        private void txtRacaCor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);

            if ((txtRacaCor.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.RacaCor(txtRacaCor, txtRacaCor1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtRacaCor1.Text = string.Empty;
            }
        }

        private void txtRacaCor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Raca"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtRacaCor.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica            
                        cadFuncBLL.RacaCor(txtRacaCor, txtRacaCor1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRacaCor.Clear();
                    txtRacaCor1.Clear();
                }
            }
        }

        private void txtBanco_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtBanco.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Banco(txtBanco, txtBanco1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtBanco1.Text = string.Empty;
            }
        }

        private void txtBanco_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Banco"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtBanco.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Banco(txtBanco, txtBanco1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBanco.Clear();
                    txtBanco1.Clear();
                }
            }
        }

        private void txtTipoConta_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtTipoConta.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.TipoConta(txtTipoConta, txtTipoConta1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtTipoConta1.Text = string.Empty;
            }
        }

        private void txtTipoConta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "TipoConta"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtTipoConta.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.TipoConta(txtTipoConta, txtTipoConta1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoConta.Clear();
                    txtTipoConta1.Clear();
                }
            }
        }

        private void txtGrauInstrucao_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtGrauInstrucao.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.GrauInstrucao(txtGrauInstrucao, txtGrauInstrucao1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtGrauInstrucao1.Text = string.Empty;
            }
        }

        private void txtGrauInstrucao_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "GrauInstrucao"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtGrauInstrucao.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.GrauInstrucao(txtGrauInstrucao, txtGrauInstrucao1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoConta.Clear();
                    txtTipoConta1.Clear();
                }
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            //valido o campo e-mail
            //em C# é utilizado o evento Leave para verificar quando o campo perde o foco e o evento Enter para verificar ganho do foco
            bool retorno = funcoes.VerificaEmail(txtEmail.Text);
            if ((retorno == false) && (txtEmail.Text != string.Empty))
            {
                MessageBox.Show("Digite um e-mail válido!");
                txtEmail.Focus();
            }
        }

        public void CarregarTela()
        {
            if (c_funcionarioEnt.nome != null)
            {
                dtpDataCadastro.Value = c_funcionarioEnt.data_cadastro.Year == 1 || c_funcionarioEnt.data_cadastro == null ? DateTime.Now : c_funcionarioEnt.data_cadastro;
                dtpDataUltimaAt.Value = c_funcionarioEnt.data_ult_atual.Year == 1 || c_funcionarioEnt.data_ult_atual == null ? c_funcionarioEnt.data_cadastro : c_funcionarioEnt.data_ult_atual;
                if (c_funcionarioEnt.data_nascimento != null)
                {
                    dtpDataNascimento.Checked = true;
                    dtpDataNascimento.Value = c_funcionarioEnt.data_nascimento;
                }
                else
                {
                    dtpDataNascimento.Checked = false;
                }
                cboGenero.SelectedValue = c_funcionarioEnt.genero;
                txtNome.Text = c_funcionarioEnt.nome;
                txtCpf.Text = c_funcionarioEnt.cpf;
                txtRg.Text = c_funcionarioEnt.rg;
                cboSituacao.SelectedValue = c_funcionarioEnt.situacao == 0 ? -1 : c_funcionarioEnt.situacao;
                //byte[] fotoRetorno = new byte[0];
                //func.foto.Length > fotoRetorno.Length
                if (c_funcionarioEnt.foto != null)
                {
                    byte[] foto = c_funcionarioEnt.foto; //converto para array.   
                    imgFuncionario.Image = funcoes.DesconverterFoto(foto);
                    if (imgFuncionario.Image == null)
                    {
                        imgFuncionario.ImageLocation = imagemPadrao;
                    }                    
                }
                cboEmpresaContratual.SelectedValue = c_funcionarioEnt.emp_contratual == 0 ? -1 : c_funcionarioEnt.emp_contratual;
                funcoes.MarcarEmpresaDoUsuario(clstEmpGerencial, txtCodigo.Text); //marcar empresa gerencial
                txtTelefone.Text = c_funcionarioEnt.telefone;
                txtCelular.Text = c_funcionarioEnt.celular;
                txtEmail.Text = c_funcionarioEnt.email;
                txtEndereco.Text = c_funcionarioEnt.endereco;
                txtNumero.Text = c_funcionarioEnt.numero;
                txtBairro.Text = c_funcionarioEnt.bairro;
                txtCep.Text = c_funcionarioEnt.cep;
                txtComplemento.Text = c_funcionarioEnt.complemento;

                txtCidade.Text = c_funcionarioEnt.cidade == 0 ? "" : c_funcionarioEnt.cidade.ToString();
                cadFuncBLL.Cidade(txtCidade, txtCidade1);

                txtEstado.Text = c_funcionarioEnt.estado == 0 ? "" : c_funcionarioEnt.estado.ToString();
                cadFuncBLL.Estado(txtEstado, txtEstado1);

                txtPais.Text = c_funcionarioEnt.pais == 0 ? "" : c_funcionarioEnt.pais.ToString();
                cadFuncBLL.Pais(txtPais, txtPais1);

                txtNomePai.Text = c_funcionarioEnt.nome_pai;
                txtNomeMae.Text = c_funcionarioEnt.nome_mae;
                txtRacaCor.Text = c_funcionarioEnt.raca_cor == 0 ? "" : c_funcionarioEnt.raca_cor.ToString();
                if ((txtRacaCor.Text != null) && (txtRacaCor.Text != ""))
                {
                    cadFuncBLL.RacaCor(txtRacaCor, txtRacaCor1);
                }
                txtEstadoCivil.Text = c_funcionarioEnt.estado_civil;

                if (c_funcionarioEnt.deficiente == "N")
                {
                    rdbDeficienciaNao.Checked = true;
                }
                else
                {
                    rdbDeficienciaSim.Checked = true;
                    txtTipoDeficiencia.Text = c_funcionarioEnt.tipo_deficiencia == 0 ? "" : c_funcionarioEnt.tipo_deficiencia.ToString();
                    cadFuncBLL.Estado(txtTipoDeficiencia, txtTipoDeficiencia1);
                }
                if (c_funcionarioEnt.data_admissao != null || c_funcionarioEnt.data_admissao.Year != 1)
                {
                    dtpAdmissao.Checked = true;
                    dtpAdmissao.Value = c_funcionarioEnt.data_nascimento;
                }
                else
                {
                    dtpAdmissao.Checked = false;
                }

                if (c_funcionarioEnt.data_exame_medico != null || c_funcionarioEnt.data_exame_medico.Year != 1)
                {
                    dtpExameMedico.Checked = true;
                    dtpExameMedico.Value = c_funcionarioEnt.data_exame_medico;
                }
                else
                {
                    dtpExameMedico.Checked = false;
                }

                if (c_funcionarioEnt.data_inicio_experiencia != null || c_funcionarioEnt.data_inicio_experiencia.Year != 1)
                {
                    dtpInicioExperiencia.Checked = true;
                    dtpInicioExperiencia.Value = c_funcionarioEnt.data_inicio_experiencia;
                }
                else
                {
                    dtpInicioExperiencia.Checked = false;
                }

                if (c_funcionarioEnt.data_fim_experiencia != null || c_funcionarioEnt.data_fim_experiencia.Year != 1)
                {
                    dtpFimExperiencia.Checked = true;
                    dtpFimExperiencia.Value = c_funcionarioEnt.data_fim_experiencia;
                }
                else
                {
                    dtpFimExperiencia.Checked = false;
                }

                if (c_funcionarioEnt.data_prorrogacao != null || c_funcionarioEnt.data_prorrogacao.Year != 1)
                {
                    dtpProrrogacaoAte.Checked = true;
                    dtpProrrogacaoAte.Value = c_funcionarioEnt.data_prorrogacao;
                }
                else
                {
                    dtpProrrogacaoAte.Checked = false;
                }

                txtCtps.Text = c_funcionarioEnt.ctps;
                txtCtpsSerie.Text = c_funcionarioEnt.ctps_serie;
                txtCtpsUf.Text = c_funcionarioEnt.ctps_uf;

                if (c_funcionarioEnt.ctps_emissao != null || c_funcionarioEnt.ctps_emissao.Year != 1)
                {
                    dtpCtpsEmissao.Checked = true;
                    dtpCtpsEmissao.Value = c_funcionarioEnt.ctps_emissao;
                }
                else
                {
                    dtpCtpsEmissao.Checked = false;
                }
                txtCtpsOrgaoExpedidor.Text = c_funcionarioEnt.ctps_orgao_expedidor;
                txtPisPasep.Text = c_funcionarioEnt.pis;

                if (c_funcionarioEnt.pis_emissao != null || c_funcionarioEnt.pis_emissao.Year != 1)
                {
                    dtpPisEmissao.Checked = true;
                    dtpPisEmissao.Value = c_funcionarioEnt.pis_emissao;
                }
                else
                {
                    dtpPisEmissao.Checked = false;
                }

                txtTituloEleitor.Text = c_funcionarioEnt.titulo_numero;
                txtTituloZona.Text = c_funcionarioEnt.titulo_zona;
                txtTituloSecao.Text = c_funcionarioEnt.titulo_secao;
                txtReservistaNr.Text = c_funcionarioEnt.reservista_nr;
                txtReservistaRa.Text = c_funcionarioEnt.reservista_ra;
                txtCnh.Text = c_funcionarioEnt.cnh_numero;

                if (c_funcionarioEnt.cnh_validade != null || c_funcionarioEnt.cnh_validade.Year != 1)
                {
                    dtpCnhValidade.Checked = true;
                    dtpCnhValidade.Value = c_funcionarioEnt.cnh_validade;
                }
                else
                {
                    dtpCnhValidade.Checked = false;
                }

                txtCnhOrgaoExpedidor.Text = c_funcionarioEnt.cnh_orgao_expedidor;
                txtCnhCategoria.Text = c_funcionarioEnt.cnh_categoria;

                if (c_funcionarioEnt.cnh_data_emissao != null || c_funcionarioEnt.cnh_data_emissao.Year != 1)
                {
                    dtpCnhEmissao.Checked = true;
                    dtpCnhEmissao.Value = c_funcionarioEnt.cnh_data_emissao;
                }
                else
                {
                    dtpCnhEmissao.Checked = false;
                }

                if (c_funcionarioEnt.demitido == "N")
                {
                    rdbDemitidoNao.Checked = true;
                }
                else
                {
                    rdbDemitidoSim.Checked = true;
                    dtpDemissao.Value = c_funcionarioEnt.data_demissao;
                    txtMotivoDemissao.Text = c_funcionarioEnt.motivo_demissao;
                    txtRescisaoCaged.Text = c_funcionarioEnt.rescisao_caged == 0 ? "" : c_funcionarioEnt.rescisao_caged.ToString();
                    lblInformativa1.Visible = true;
                    lblInformativa1.Text = "Funcionário Demitido";
                }
                txtCargo.Text = c_funcionarioEnt.cargo == 0 ? "" : c_funcionarioEnt.cargo.ToString();
                cadFuncBLL.Cargo(txtCargo, txtCargo1, txtSalario);
                txtTipoContrato.Text = c_funcionarioEnt.tipo_contrato == 0 ? "" : c_funcionarioEnt.tipo_contrato.ToString();
                cadFuncBLL.TipoContrato(txtTipoContrato, txtTipoContrato1);
                txtAdmissaoCaged.Text = c_funcionarioEnt.admissao_caged == 0 ? "" : c_funcionarioEnt.admissao_caged.ToString();
                cadFuncBLL.AdmissaoCaged(txtAdmissaoCaged, txtAdmissaoCaged1);
                txtSetor.Text = c_funcionarioEnt.setor == 0 ? "" : c_funcionarioEnt.setor.ToString();
                cadFuncBLL.Setor(txtSetor, txtSetor1);
                txtDepartamento.Text = c_funcionarioEnt.departamento == 0 ? "" : c_funcionarioEnt.departamento.ToString();
                cadFuncBLL.Departamento(txtDepartamento, txtDepartamento1);
                txtGrupoFuncionario.Text = c_funcionarioEnt.grupo_funcionario == 0 ? "" : c_funcionarioEnt.grupo_funcionario.ToString();
                cadFuncBLL.GrupoFuncionario(txtGrupoFuncionario, txtGrupoFuncionario1);
                txtBanco.Text = c_funcionarioEnt.banco == 0 ? "" : c_funcionarioEnt.banco.ToString();
                cadFuncBLL.Banco(txtBanco, txtBanco1);
                txtAgencia.Text = c_funcionarioEnt.agencia;
                txtNumeroConta.Text = c_funcionarioEnt.numero_conta;
                txtTipoConta.Text = c_funcionarioEnt.tipo_conta == 0 ? "" : c_funcionarioEnt.tipo_conta.ToString();
                cadFuncBLL.TipoConta(txtTipoConta, txtTipoConta1);
                txtGrauInstrucao.Text = c_funcionarioEnt.grau_instrucao == 0 ? "" : c_funcionarioEnt.grau_instrucao.ToString();
                if (txtGrauInstrucao.Text != "")
                {
                    cadFuncBLL.GrauInstrucao(txtGrauInstrucao, txtGrauInstrucao1);
                }
                txtInstituicaoEnsino.Text = c_funcionarioEnt.instituicao_ensino;
                txtCurso.Text = c_funcionarioEnt.curso;
                if (c_funcionarioEnt.curso_inicio != null || c_funcionarioEnt.curso_inicio.Year != 1)
                {
                    dtpCursoInicio.Checked = true;
                    dtpCursoInicio.Value = c_funcionarioEnt.curso_inicio;
                }
                else
                {
                    dtpCursoInicio.Checked = false;
                }

                if (c_funcionarioEnt.curso_fim != null || c_funcionarioEnt.curso_fim.Year != 1)
                {
                    dtpCursoTermino.Checked = true;
                    dtpCursoTermino.Value = c_funcionarioEnt.curso_fim;
                }
                else
                {
                    dtpCursoTermino.Checked = false;
                }
                txtCursoOutros.Text = c_funcionarioEnt.outros_cursos;
                txtObservacao.Text = c_funcionarioEnt.observacao;
                funcoes.VerificarAniversario(dtpDataNascimento, dtpDataCadastro, lblInformativa1, rdbDemitidoSim);
            }
        }

        public void PreencherFuncionario()
        {
            c_funcionarioEnt.LimparFuncionario();
            if (txtNome.Text != "")
            {
                c_funcionarioEnt.codigo = txtCodigo.Text != "" ? Convert.ToInt64(txtCodigo.Text) : 0;
                c_funcionarioEnt.data_cadastro = dtpDataCadastro.Value;
                c_funcionarioEnt.data_ult_atual = dtpDataUltimaAt.Value;
                c_funcionarioEnt.data_nascimento = dtpDataNascimento.Value;
                c_funcionarioEnt.genero = cboGenero.SelectedIndex > -1 ? Convert.ToInt32(cboGenero.SelectedValue) : -1;
                c_funcionarioEnt.nome = txtNome.Text;
                c_funcionarioEnt.cpf = txtCpf.Text;
                c_funcionarioEnt.rg = txtRg.Text == "" ? "" : txtRg.Text;
                c_funcionarioEnt.genero = cboGenero.SelectedIndex > -1 ? Convert.ToInt32(cboGenero.SelectedValue) : -1;
                c_funcionarioEnt.situacao = cboSituacao.SelectedIndex > -1 ? Convert.ToInt32(cboSituacao.SelectedValue) : -1;
                if (imgFuncionario.ImageLocation == imagemPadrao)
                {
                    c_funcionarioEnt.foto = new byte[0];                    
                }
                else
                {
                    c_funcionarioEnt.foto = funcoes.ConverterFoto(imgFuncionario); //converto para array e envio para o banco.                  
                }
                c_funcionarioEnt.emp_contratual = cboEmpresaContratual.SelectedIndex > -1 ? Convert.ToInt64(cboEmpresaContratual.SelectedValue) : -1;
                c_funcionarioEnt.telefone = txtTelefone.Text != "" ? txtTelefone.Text : "";
                c_funcionarioEnt.celular = txtCelular.Text;
                c_funcionarioEnt.email = txtEmail.Text != "" ? txtEmail.Text : "";
                c_funcionarioEnt.endereco = txtEndereco.Text;
                c_funcionarioEnt.numero = txtNumero.Text;
                c_funcionarioEnt.bairro = txtBairro.Text;
                c_funcionarioEnt.cep = txtCep.Text;
                c_funcionarioEnt.complemento = txtComplemento.Text != "" ? txtComplemento.Text : "";
                c_funcionarioEnt.cidade = Convert.ToInt32(txtCidade.Text);
                c_funcionarioEnt.estado = Convert.ToInt32(txtEstado.Text);
                c_funcionarioEnt.pais = Convert.ToInt32(txtPais.Text);
                c_funcionarioEnt.nome_pai = txtNomePai.Text != "" ? txtNomePai.Text : "";
                c_funcionarioEnt.nome_mae = txtNomeMae.Text != "" ? txtNomeMae.Text : "";
                c_funcionarioEnt.raca_cor = txtRacaCor.Text != "" ? Convert.ToInt32(txtRacaCor.Text) : 0;
                c_funcionarioEnt.estado_civil = txtEstadoCivil.Text != "" ? txtEstadoCivil.Text : "";
                if (rdbDeficienciaNao.Checked == true)
                {
                    c_funcionarioEnt.deficiente = "N";
                    c_funcionarioEnt.tipo_deficiencia = 1; //nenhum no banco
                }
                else
                {
                    c_funcionarioEnt.deficiente = "S";
                    c_funcionarioEnt.tipo_deficiencia = txtTipoDeficiencia.Text != "" ? Convert.ToInt32(txtTipoDeficiencia.Text) : 1;
                }
                c_funcionarioEnt.ctps = txtCtps.Text != "" ? txtCtps.Text : "";
                c_funcionarioEnt.ctps_serie = txtCtpsSerie.Text != "" ? txtCtpsSerie.Text : "";
                c_funcionarioEnt.ctps_uf = txtCtpsUf.Text != "" ? txtCtpsUf.Text : "";
                c_funcionarioEnt.ctps_emissao = dtpCtpsEmissao.Value;
                c_funcionarioEnt.ctps_orgao_expedidor = txtCtpsOrgaoExpedidor.Text != "" ? txtCtpsOrgaoExpedidor.Text : "";
                c_funcionarioEnt.pis = txtPisPasep.Text != "" ? txtPisPasep.Text : "";
                c_funcionarioEnt.pis_emissao = dtpPisEmissao.Value;
                c_funcionarioEnt.titulo_numero = txtTituloEleitor.Text != "" ? txtTituloEleitor.Text : "";
                c_funcionarioEnt.titulo_zona = txtTituloZona.Text != "" ? txtTituloZona.Text : "";
                c_funcionarioEnt.titulo_secao = txtTituloSecao.Text != "" ? txtTituloSecao.Text : "";
                c_funcionarioEnt.reservista_nr = txtReservistaNr.Text != "" ? txtReservistaNr.Text : "";
                c_funcionarioEnt.reservista_ra = txtReservistaRa.Text != "" ? txtReservistaRa.Text : "";
                c_funcionarioEnt.cnh_numero = txtCnh.Text != "" ? txtCnh.Text : "";
                c_funcionarioEnt.cnh_validade = dtpCnhValidade.Value;
                c_funcionarioEnt.cnh_orgao_expedidor = txtCnhOrgaoExpedidor.Text != "" ? txtCnhOrgaoExpedidor.Text : "";
                c_funcionarioEnt.cnh_categoria = txtCnhCategoria.Text != "" ? txtCnhCategoria.Text : "";
                c_funcionarioEnt.cnh_data_emissao = dtpCnhEmissao.Value;
                c_funcionarioEnt.data_admissao = dtpAdmissao.Value;
                c_funcionarioEnt.data_exame_medico = dtpExameMedico.Value;
                c_funcionarioEnt.data_inicio_experiencia = dtpInicioExperiencia.Value;
                c_funcionarioEnt.data_fim_experiencia = dtpFimExperiencia.Value;
                c_funcionarioEnt.data_prorrogacao = dtpProrrogacaoAte.Value;
                c_funcionarioEnt.observacao = txtObservacao.Text != "" ? txtObservacao.Text : "";
                if (rdbDemitidoNao.Checked == true)
                {
                    c_funcionarioEnt.demitido = "N";
                    c_funcionarioEnt.rescisao_caged = 1; //nenhum no banco
                }
                else if (rdbDemitidoSim.Checked == true)
                {
                    c_funcionarioEnt.demitido = "S";
                    c_funcionarioEnt.data_demissao = dtpDemissao.Value;
                    c_funcionarioEnt.motivo_demissao = txtMotivoDemissao.Text != "" ? txtMotivoDemissao.Text : "";
                    c_funcionarioEnt.rescisao_caged = txtRescisaoCaged.Text != "" ? Convert.ToInt32(txtRescisaoCaged.Text) : 1;
                }
                c_funcionarioEnt.cargo = txtCargo.Text != "" ? Convert.ToInt32(txtCargo.Text) : 0;
                c_funcionarioEnt.tipo_contrato = txtTipoContrato.Text != "" ? Convert.ToInt32(txtTipoContrato.Text) : 0;
                c_funcionarioEnt.admissao_caged = txtAdmissaoCaged.Text != "" ? Convert.ToInt32(txtAdmissaoCaged.Text) : 0;
                c_funcionarioEnt.setor = txtSetor.Text != "" ? Convert.ToInt32(txtSetor.Text) : 0;
                c_funcionarioEnt.departamento = txtDepartamento.Text != "" ? Convert.ToInt32(txtDepartamento.Text) : 0;
                c_funcionarioEnt.grupo_funcionario = txtGrupoFuncionario.Text == "" ? 0 : Convert.ToInt32(txtGrupoFuncionario.Text);
                c_funcionarioEnt.banco = txtBanco.Text != "" ? Convert.ToInt32(txtBanco.Text) : 0;
                c_funcionarioEnt.agencia = txtAgencia.Text != "" ? txtAgencia.Text : "";
                c_funcionarioEnt.numero_conta = txtNumeroConta.Text != "" ? txtNumeroConta.Text : "";
                c_funcionarioEnt.tipo_conta = txtTipoConta.Text != "" ? Convert.ToInt32(txtTipoConta.Text) : 0;
                c_funcionarioEnt.grau_instrucao = txtGrauInstrucao.Text != "" ? Convert.ToInt32(txtGrauInstrucao.Text) : 7;//seto por padrão ensino médio
                c_funcionarioEnt.instituicao_ensino = txtInstituicaoEnsino.Text != "" ? txtInstituicaoEnsino.Text : "";
                c_funcionarioEnt.curso = txtCurso.Text != "" ? txtCurso.Text : "";
                c_funcionarioEnt.curso_inicio = dtpCursoInicio.Value;
                c_funcionarioEnt.curso_fim = dtpCursoTermino.Value;
                c_funcionarioEnt.outros_cursos = txtCursoOutros.Text != "" ? txtCursoOutros.Text : "";
                for (int i = 0; i < clstEmpGerencial.CheckedIndices.Count; i++)
                {
                    if (clstEmpGerencial.GetItemChecked(i))
                    {
                        clstEmpGerencial.SelectedIndex = i;
                        c_funcionarioEnt.ListEmpresaGerencial.Add(Convert.ToInt64(clstEmpGerencial.SelectedValue));
                    }
                }
            }
        }

        private void ValidarGravacao()
        {
            if (txtCodigo.Text != string.Empty)
            {
                DialogResult dialogo = MessageBox.Show("Deseja mesmo alterar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogo == DialogResult.Yes)
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Informe o nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                    }
                    else if ((txtCpf.Text == "   .   .   -") || (txtCpf.Text == "") || (txtCpf.Text.Length < 14))
                    {
                        MessageBox.Show("Informe um cpf válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCpf.Focus();
                    }
                    else if (cboGenero.SelectedIndex <= -1)
                    {
                        MessageBox.Show("Informe o gênero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboGenero.Focus();
                    }
                    else if (cboSituacao.SelectedIndex <= -1)
                    {
                        MessageBox.Show("Informe a situação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboSituacao.Focus();
                    }
                    else if ((txtCelular.Text == "(  )     -") || (txtCelular.Text == "") || (txtCelular.Text.Length < 14))
                    {
                        MessageBox.Show("Informe um número de celular!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCelular.Focus();
                    }
                    else if (rdbDeficienciaSim.Checked == true && txtTipoDeficiencia.Text == "")
                    {
                        MessageBox.Show("Informe o tipo de deficiência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoDeficiencia.Focus();
                    }
                    else if (txtEndereco.Text == "")
                    {
                        MessageBox.Show("Informe o endereço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEndereco.Focus();
                    }
                    else if (txtNumero.Text == "")
                    {
                        MessageBox.Show("Informe o número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Focus();
                    }
                    else if (txtBairro.Text == "")
                    {
                        MessageBox.Show("Informe o bairro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBairro.Focus();
                    }
                    else if ((txtCep.Text == "  .   -") || (txtCep.Text == "") || (txtCep.Text.Length < 10))
                    {
                        MessageBox.Show("Informe um cep válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCep.Focus();
                    }
                    else if (txtCidade.Text == "")
                    {
                        MessageBox.Show("Informe uma cidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCidade.Focus();
                    }
                    else if (cboEmpresaContratual.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Selecione a empresa contratual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboEmpresaContratual.Focus();
                    }
                    else if (clstEmpGerencial.CheckedItems.Count < 1)
                    {
                        MessageBox.Show("Selecione ao menos uma empresa gerencial!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboEmpresaContratual.Focus();
                    }
                    else if (dtpAdmissao.Checked == false)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Marque e informe a data de Admissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpAdmissao.Focus();
                    }
                    else if (dtpInicioExperiencia.Value.Date < dtpAdmissao.Value.Date)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data do início da experiência não pode ser menor que a data de admissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpInicioExperiencia.Focus();
                    }
                    else if (dtpFimExperiencia.Value < dtpInicioExperiencia.Value)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data do fim da experiência não pode ser menor ou igual a data de início!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpFimExperiencia.Focus();
                    }
                    else if (dtpProrrogacaoAte.Value.Date < dtpFimExperiencia.Value.Date)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data de prorrogação da experiência não pode ser menor que a data do fim da experiência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpProrrogacaoAte.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && dtpDemissao.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a data da demissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpDemissao.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && txtMotivoDemissao.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o motivo da demissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMotivoDemissao.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && txtRescisaoCaged.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a rescisão caged!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRescisaoCaged.Focus();
                    }
                    else if (txtCargo.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o cargo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCargo.Focus();
                    }
                    else if (txtTipoContrato.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o tipo de contrato!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoContrato.Focus();
                    }
                    else if (txtAdmissaoCaged.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a admissão caged!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdmissaoCaged.Focus();
                    }
                    else if (txtSetor.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o setor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSetor.Focus();
                    }
                    else if (txtDepartamento.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o departamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDepartamento.Focus();
                    }
                    else if (txtGrupoFuncionario.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o grupo do funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGrupoFuncionario.Focus();
                    }
                    else if (txtBanco.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o banco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBanco.Focus();
                    }
                    else if (txtAgencia.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a agência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAgencia.Focus();
                    }
                    else if (txtNumeroConta.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o número da conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumeroConta.Focus();
                    }
                    else if (txtTipoConta.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o tipo de conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoConta.Focus();
                    }
                    else if (txtCurso.Text != "" && dtpCursoTermino.Value.Date < dtpCursoInicio.Value.Date)
                    {
                        abaCadFuncionario.SelectedIndex = 4;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data do fim do curso não pode ser menor que data de início do curso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpCursoTermino.Focus();
                    }
                    else
                    {
                        string retorno = "";
                        try
                        {
                            PreencherFuncionario();
                            retorno = cadFuncBLL.Atualizar(c_funcionarioEnt);
                            Convert.ToInt32(retorno);
                            MessageBox.Show("Registro " + txtCodigo.Text + " alterado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch
                        {
                            MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            else //(dialogo == DialogResult.No)
            {
                if (txtCodigo.Text == "")
                {
                    if (txtNome.Text == "")
                    {
                        MessageBox.Show("Informe o nome!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNome.Focus();
                    }
                    else if ((txtCpf.Text == "   .   .   -") || (txtCpf.Text == "") || (txtCpf.Text.Length < 14))
                    {
                        MessageBox.Show("Informe um cpf válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCpf.Focus();
                    }
                    else if (cboGenero.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Informe o gênero!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboGenero.Focus();
                    }
                    else if (cboSituacao.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Informe a situação!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboSituacao.Focus();
                    }
                    else if ((txtCelular.Text == "(  )     -") || (txtCelular.Text == "") || (txtCelular.Text.Length < 14))
                    {
                        MessageBox.Show("Informe um número de celular!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCelular.Focus();
                    }
                    else if (rdbDeficienciaSim.Checked == true && txtTipoDeficiencia.Text == "")
                    {
                        MessageBox.Show("Informe o tipo de deficiência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoDeficiencia.Focus();
                    }
                    else if (txtEndereco.Text == "")
                    {
                        MessageBox.Show("Informe o endereço!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtEndereco.Focus();
                    }
                    else if (txtNumero.Text == "")
                    {
                        MessageBox.Show("Informe o número!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumero.Focus();
                    }
                    else if (txtBairro.Text == "")
                    {
                        MessageBox.Show("Informe o bairro!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBairro.Focus();
                    }
                    else if ((txtCep.Text == "  .   -") || (txtCep.Text == "") || (txtCep.Text.Length < 10))
                    {
                        MessageBox.Show("Informe um cep válido!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCep.Focus();
                    }
                    else if (txtCidade.Text == "")
                    {
                        MessageBox.Show("Informe uma cidade!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCidade.Focus();
                    }
                    else 
                        
                        if (cboEmpresaContratual.SelectedIndex <= 0)
                    {
                        MessageBox.Show("Selecione a empresa contratual!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboEmpresaContratual.Focus();
                    }
                    else if (clstEmpGerencial.CheckedItems.Count < 1)
                    {
                        MessageBox.Show("Selecione ao menos uma empresa gerencial!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboEmpresaContratual.Focus();
                    }
                    else if (dtpAdmissao.Checked == false)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Marque e informe a data de Admissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpAdmissao.Focus();
                    }
                    else if (dtpInicioExperiencia.Value.Date < dtpAdmissao.Value.Date)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data do início da experiência não pode ser menor que a data de admissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpInicioExperiencia.Focus();
                    }
                    else if (dtpFimExperiencia.Value < dtpInicioExperiencia.Value)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data do fim da experiência não pode ser menor ou igual a data de início!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpFimExperiencia.Focus();
                    }
                    else if (dtpProrrogacaoAte.Value.Date < dtpFimExperiencia.Value.Date)
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("A data de prorrogação da experiência não pode ser menor que a data do fim da experiência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpProrrogacaoAte.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && dtpDemissao.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a data da demissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dtpDemissao.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && txtMotivoDemissao.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o motivo da demissão!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtMotivoDemissao.Focus();
                    }
                    else if (rdbDemitidoSim.Checked == true && txtRescisaoCaged.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 0;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a rescisão caged!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRescisaoCaged.Focus();
                    }
                    else if (txtCargo.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o cargo!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtCargo.Focus();
                    }
                    else if (txtTipoContrato.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o tipo de contrato!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoContrato.Focus();
                    }
                    else if (txtAdmissaoCaged.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a admissão caged!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAdmissaoCaged.Focus();
                    }
                    else if (txtSetor.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o setor!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtSetor.Focus();
                    }
                    else if (txtDepartamento.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o departamento!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtDepartamento.Focus();
                    }
                    else if (txtGrupoFuncionario.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 2;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o grupo do funcionário!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtGrupoFuncionario.Focus();
                    }
                    else if (txtBanco.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o banco!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtBanco.Focus();
                    }
                    else if (txtAgencia.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe a agência!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtAgencia.Focus();
                    }
                    else if (txtNumeroConta.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o número da conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtNumeroConta.Focus();
                    }
                    else if (txtTipoConta.Text == "")
                    {
                        abaCadFuncionario.SelectedIndex = 3;//seleciono a aba em que está este campo abaixo
                        MessageBox.Show("Informe o tipo de conta!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtTipoConta.Focus();
                    }
                    else if (txtCurso.Text != "" && dtpCursoTermino.Checked == true && dtpCursoInicio.Checked == true)
                    {
                        if (dtpCursoTermino.Value.Date < dtpCursoInicio.Value.Date)
                        {
                            abaCadFuncionario.SelectedIndex = 4;//seleciono a aba em que está este campo abaixo
                            MessageBox.Show("A data do fim do curso não pode ser menor que data de início do curso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            dtpCursoTermino.Focus();
                        }
                    }
                    else
                    {
                        try
                        {
                            PreencherFuncionario();
                            string retorno = cadFuncBLL.ConsultarGravado(c_funcionarioEnt);
                            Convert.ToInt32(retorno);
                            if (retorno == txtCpf.Text)
                            {
                                MessageBox.Show("O CPF informado já foi gravado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                txtCpf.Focus();
                            }
                            else
                            {
                                retorno = "";
                                retorno = cadFuncBLL.Gravar(c_funcionarioEnt);
                                try
                                {
                                    Convert.ToInt32(retorno);
                                    MessageBox.Show("Registro " + txtCodigo.Text + " gravado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                catch
                                {
                                    MessageBox.Show("Falha: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Erro: " + ex);
                        }
                    }
                }
            }
        }

        private void ValidarExclusao()
        {
            if ((txtCodigo.Text == string.Empty) && (txtNome.Text == string.Empty))
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
                        c_funcionarioEnt.codigo = Convert.ToInt64(txtCodigo.Text);
                        retorno = cadFuncBLL.Deletar(c_funcionarioEnt);
                        Convert.ToInt32(retorno);
                        MessageBox.Show("Registro " + retorno + " excluído com sucesso!");
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possível excluir o registro. Detalhes: " + retorno, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            ValidarGravacao();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ValidarExclusao();
        }

        private void btnImagem_Click(object sender, EventArgs e)
        {
            funcoes.PesquisarImagem(odlgCadFunc, imgFuncionario);
        }

        private void btnLimpar_Click_1(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void txtTipoDeficiencia_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "TipoDeficiencia"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtTipoDeficiencia.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.TipoDeficiencia(txtTipoDeficiencia, txtTipoDeficiencia1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoDeficiencia.Clear();
                    txtTipoDeficiencia1.Clear();
                }
            }
        }

        private void txtTipoDeficiencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);

            if ((txtTipoDeficiencia.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.TipoDeficiencia(txtTipoDeficiencia, txtTipoDeficiencia1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtTipoDeficiencia1.Text = string.Empty;
            }
        }

        private void rdbDeficienciaSim_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbDeficienciaSim.Checked == true)
            {
                lblTipoDeficiencia.Visible = true;
                txtTipoDeficiencia.Visible = true;
                txtTipoDeficiencia1.Visible = true;
            }
        }

        private void rdbDeficienciaNao_CheckedChanged_1(object sender, EventArgs e)
        {
            if (rdbDeficienciaNao.Checked == true)
            {
                lblTipoDeficiencia.Visible = false;
                txtTipoDeficiencia.Visible = false;
                txtTipoDeficiencia1.Visible = false;
                txtTipoDeficiencia.Text = string.Empty;
                txtTipoDeficiencia1.Text = string.Empty;
            }
        }

        private void rdbDemitidoSim_CheckedChanged(object sender, EventArgs e)
        {
            lblDataDemissao.Visible = true;
            dtpDemissao.Visible = true;
            lblMotivoDemissao.Visible = true;
            txtMotivoDemissao.Visible = true;
            lblRescisaoCaged.Visible = true;
            txtRescisaoCaged.Visible = true;
            txtRescisaoCaged1.Visible = true;
            lblInformativa2.Text = "Funcionário Demitido!";
        }

        private void rdbDemitidoNao_CheckedChanged(object sender, EventArgs e)
        {
            lblDataDemissao.Visible = false;
            dtpDemissao.Visible = false;
            lblMotivoDemissao.Visible = false;
            txtMotivoDemissao.Visible = false;
            txtMotivoDemissao.Text = string.Empty;
            lblRescisaoCaged.Visible = false;
            txtRescisaoCaged.Visible = false;
            txtRescisaoCaged.Text = string.Empty;
            txtRescisaoCaged1.Visible = false;
            txtRescisaoCaged1.Text = string.Empty;
            lblInformativa2.Text = string.Empty;
        }

        private void txtRescisaoCaged_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Rescisao"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtRescisaoCaged.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica      
                        cadFuncBLL.RescisaoCaged(txtRescisaoCaged, txtRescisaoCaged1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtRescisaoCaged.Clear();
                    txtRescisaoCaged1.Clear();
                }
            }
        }

        private void txtRescisaoCaged_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);

            if ((txtRescisaoCaged.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.RescisaoCaged(txtRescisaoCaged, txtRescisaoCaged1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtRescisaoCaged1.Text = string.Empty;
            }
        }

        private void txtCargo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Cargo"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtCargo.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Cargo(txtCargo, txtCargo1, txtSalario);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCargo.Clear();
                    txtCargo1.Clear();
                }
            }
        }

        private void txtCargo_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtCargo.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Cargo(txtCargo, txtCargo1, txtSalario);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtCargo1.Text = string.Empty;
                txtSalario.Text = string.Empty;
            }
        }

        private void txtTipoContrato_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) //verifico se foi pressionado delete
            {
                txtTipoContrato1.Text = string.Empty;
            }

            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "TipoContrato"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtTipoContrato.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.TipoContrato(txtTipoContrato, txtTipoContrato1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtTipoContrato.Clear();
                    txtTipoContrato1.Clear();
                }
            }
        }

        private void txtTipoContrato_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtTipoContrato.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.TipoContrato(txtTipoContrato, txtTipoContrato1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtTipoContrato1.Text = string.Empty;
            }
        }

        private void txtAdmissaoCaged_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "AdmissaoCaged"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtAdmissaoCaged.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.AdmissaoCaged(txtAdmissaoCaged, txtAdmissaoCaged1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAdmissaoCaged.Clear();
                    txtAdmissaoCaged1.Clear();
                }
            }
        }

        private void txtAdmissaoCaged_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtAdmissaoCaged.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.AdmissaoCaged(txtAdmissaoCaged, txtAdmissaoCaged1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtAdmissaoCaged1.Text = string.Empty;
            }
        }

        private void txtSetor_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Setor"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtSetor.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Setor(txtSetor, txtSetor1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtSetor.Clear();
                    txtSetor1.Clear();
                }
            }
        }

        private void txtSetor_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);

            if ((txtSetor.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Setor(txtSetor, txtSetor1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtSetor1.Text = string.Empty;
            }
        }

        private void txtDepartamento_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "Departamento"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtDepartamento.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.Departamento(txtDepartamento, txtDepartamento1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDepartamento.Clear();
                    txtDepartamento1.Clear();
                }
            }
        }

        private void txtDepartamento_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtDepartamento.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.Departamento(txtDepartamento, txtDepartamento1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtDepartamento1.Text = string.Empty;
            }
        }

        private void txtGrupoFuncionario_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2) //APLICO NO EVENTO KEYUP PARA VERIFICAR SE O BOTÃO PRESSIONADO É F2
            {
                FrmPesquisar frmPesquisar = new FrmPesquisar();
                frmPesquisar.buscar = "GrupoUsuario"; //passo a coluna para a pesquisa genérica
                frmPesquisar.ShowDialog();
                try
                {
                    string codigo = frmPesquisar.codigo;
                    if (codigo != null)
                    {
                        txtGrupoFuncionario.Text = frmPesquisar.codigo.ToString(); //pego o código de retorno da pesquisa genérica
                        cadFuncBLL.GrupoFuncionario(txtGrupoFuncionario, txtGrupoFuncionario1);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Não foi possível pesquisar. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtGrupoFuncionario.Clear();
                    txtGrupoFuncionario1.Clear();
                }
            }
        }

        private void txtGrupoFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            funcoes.ApenasNumeros(e);
            if ((txtGrupoFuncionario.Text != string.Empty) && (e.KeyChar == (char)Keys.Enter))
            {
                cadFuncBLL.GrupoFuncionario(txtGrupoFuncionario, txtGrupoFuncionario1);
            }
            if (e.KeyChar == (char)Keys.Back) //verifico se foi pressionado backspace
            {
                txtGrupoFuncionario1.Text = string.Empty;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}