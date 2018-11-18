using Loja.FUNCTIONS;
using Loja.BUSINESS;
using System;
using System.Windows.Forms;

namespace Loja.VIEW
{
    public partial class FrmPesquisar : Form
    {
        PesquisarBLL pesquisarBLL = new PesquisarBLL();
        Funcoes funcoes = new Funcoes();        
        public string codigo; //Pegar o código clicado na linha e devolver para outra tela
        public string buscar; //Saber o que será pesquisado

        public FrmPesquisar()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtPesquisar.Clear();
            grdPesquisar.Columns.Clear();
            txtTotal.Clear();
            chkConsiderarInativo.Checked = false;
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            switch (buscar)
            {
                case "Usuario":
                    pesquisarBLL.Usuario(chkConsiderarInativo, txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Funcionario":                   
                    pesquisarBLL.Funcionario(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Cidade":
                    pesquisarBLL.Cidade(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Estado":
                    pesquisarBLL.Estado(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Pais":
                    pesquisarBLL.Pais(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Raca":
                    pesquisarBLL.RacaCor(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "TipoDeficiencia":
                    pesquisarBLL.TipoDeficiencia(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Rescisao":
                    pesquisarBLL.RescisaoCaged(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Cargo":
                    pesquisarBLL.Cargo(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "TipoContrato":
                    pesquisarBLL.TipoContrato(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "AdmissaoCaged":
                    pesquisarBLL.AdmissaoCaged(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Setor":
                    pesquisarBLL.Setor(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Departamento":
                    pesquisarBLL.Departamento(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "GrupoUsuario":
                    pesquisarBLL.GrupoUsuario(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "Banco":
                    pesquisarBLL.Banco(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "TipoConta":
                    pesquisarBLL.TipoConta(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                case "GrauInstrucao":
                    pesquisarBLL.GrauInstrucao(txtPesquisar.Text, txtTotal, grdPesquisar);
                    break;
                default:
                    MessageBox.Show("Sr programador, favor definir o que será pesquisado!");
                    break;
            }
        }

        private void txtPesquisar_KeyPress(object sender, KeyPressEventArgs e)
        {            
            funcoes.ApenasLetrasAsteristicos(e);
        }

        private void grdPesquisar_CellClick(object sender, DataGridViewCellEventArgs e)
        {   //pego os dados do click da grade e devolvo para tela que está solicitando pesquisa
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.grdPesquisar.Rows[e.RowIndex];
                this.codigo = row.Cells["Código"].Value.ToString();                
                this.Dispose();
            }            
        }

        private void FrmPesquisar_KeyUp(object sender, KeyEventArgs e)
        {
            funcoes.Sair(e, this);
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    LimparCampos();
                    break;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void FrmPesquisar_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void FrmPesquisar_Load(object sender, EventArgs e)
        {
            if(buscar == "Usuario")
            {
                chkConsiderarInativo.Visible = true;
            }
            else
            {
                chkConsiderarInativo.Visible = false;
            }
        }
    }
}

/* "tipo de pesquisar diferente"
 
 int Digitado;

 //a função abaixo tenta converter a variável CodigoDigitado para int, e devolve true se conseguiu e false se não conseguiu
 if (int.TryParse(txtPesquisar.Text, out Digitado) == true)    //verificar se é número ou texto
 {
    //é número
 }
 else
 {
    //é texto
 }
 
 */