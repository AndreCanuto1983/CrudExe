using Loja.FUNCTIONS;
using Loja.DATA;
using System;
using System.Data;
using System.Windows.Forms;
using Loja.ENTITY;
using System.Text;

namespace Loja.BUSINESS
{
    public class C_ContaBancariaBLL
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        C_ContaBancariaENT contaBancaria = new C_ContaBancariaENT();
        StringBuilder sql = new StringBuilder();
        public string CarregarDados(C_ContaBancariaENT contaBancaria)
        {
            string retorno = "0";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", contaBancaria.codigo);
                sql.Clear();
                sql.AppendLine("SELECT * FROM Financeiro_Conta_Bancaria WHERE Codigo = @codigo ");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    contaBancaria.codigo = Convert.ToInt64(dr["Codigo"]);
                    contaBancaria.dataCadastro = Convert.ToDateTime(dr["Data_Cadastro"].ToString());
                    contaBancaria.dataAtualizacao = Convert.ToDateTime(dr["Data_Atualizacao"].ToString());
                    contaBancaria.empresa = Convert.ToInt32(dr["Empresa"]);
                    contaBancaria.banco = Convert.ToInt32(dr["Banco"]);
                    contaBancaria.agencia = dr["Agencia"].ToString();
                    contaBancaria.contaCorrente = dr["Conta_Corrente"].ToString();
                    contaBancaria.tipoConta = Convert.ToInt32(dr["Conta_Tipo"]);
                    contaBancaria.saldo = dr["Saldo"].ToString();
                    retorno = "1";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ConsultarGravado(C_ContaBancariaENT contaBancaria)
        {
            string retorno = "0";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@contaCorrente", contaBancaria.contaCorrente);
                sql.Clear();
                sql.AppendLine("SELECT Conta_Corrente FROM Financeiro_Conta_Bancaria WHERE Conta_Corrente = @contaCorrente");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    contaBancaria.contaCorrente = dr["Conta_Corrente"].ToString();
                    retorno = "1";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CarregarGrade(DataGridView grade)
        {
            string qtd_linhas = "0";
            try
            {
                sql.Clear();
                sql.AppendLine("SELECT cb.Codigo AS Código, cb.Data_Cadastro AS 'Data Cadastro', cb.Data_Atualizacao AS 'Data Atualização', ");
                sql.AppendLine("cb.Empresa AS 'Cód. Empresa', e.Fantasia AS 'Empresa', cb.Banco AS 'Cód. Banco', b.Banco, ");
                sql.AppendLine("cb.Agencia AS Agência,cb.Conta_Corrente AS 'Conta Corrente', cb.Conta_Tipo AS 'Cód. Tipo Conta', ");
                sql.AppendLine("tc.Tipo_Conta AS 'Tipo Conta', cb.Saldo FROM Financeiro_Conta_Bancaria cb ");
                sql.AppendLine("LEFT JOIN Empresa e ON cb.Empresa = e.Codigo ");
                sql.AppendLine("LEFT JOIN Financeiro_Banco b ON cb.Banco = b.Codigo ");
                sql.AppendLine("LEFT JOIN Financeiro_Tipo_Conta_Bancaria tc ON cb.Conta_Tipo = tc.Codigo");
                return qtd_linhas = conexao.PreencherGrade(grade, Convert.ToString(sql));
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();
                return ex.Message;
            }
        }

        public string Deletar(C_ContaBancariaENT contaBancaria)
        {
            string excluido = null;
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", contaBancaria.codigo);
                sql.Clear();
                sql.AppendLine("DELETE Financeiro_Conta_Bancaria WHERE Codigo = @codigo");
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return excluido = "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(C_ContaBancariaENT contaBancaria)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", contaBancaria.codigo);
                conexao.AdicionarParametros("@dataCadastro", contaBancaria.dataCadastro);
                conexao.AdicionarParametros("@dataAtualizacao", contaBancaria.dataAtualizacao);
                conexao.AdicionarParametros("@empresa", contaBancaria.empresa);
                conexao.AdicionarParametros("@banco", contaBancaria.banco);
                conexao.AdicionarParametros("@agencia", contaBancaria.agencia);
                conexao.AdicionarParametros("@contaCorrente", contaBancaria.contaCorrente);
                conexao.AdicionarParametros("@tipoConta", contaBancaria.tipoConta);
                conexao.AdicionarParametros("@saldo", contaBancaria.saldo);
                sql.Clear();
                sql.AppendLine("UPDATE Financeiro_Conta_Bancaria SET Data_Cadastro = @dataCadastro, Data_Atualizacao = getdate(), ");
                sql.AppendLine("Empresa = @empresa, Banco = @banco, Agencia = @agencia, Conta_Corrente = @contaCorrente, ");
                sql.AppendLine("Conta_Tipo = @tipoConta, Saldo = @saldo WHERE Codigo = @codigo ");
                sql.AppendLine("SELECT Codigo FROM Financeiro_Conta_Bancaria WHERE Conta_Corrente = @contaCorrente");
                string retorno = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
                return retorno.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Gravar(C_ContaBancariaENT contaBancaria)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", contaBancaria.codigo);
                conexao.AdicionarParametros("@dataCadastro", contaBancaria.dataCadastro);
                conexao.AdicionarParametros("@dataAtualizacao", contaBancaria.dataAtualizacao);
                conexao.AdicionarParametros("@empresa", contaBancaria.empresa);
                conexao.AdicionarParametros("@banco", contaBancaria.banco);
                conexao.AdicionarParametros("@agencia", contaBancaria.agencia);
                conexao.AdicionarParametros("@contaCorrente", contaBancaria.contaCorrente);
                conexao.AdicionarParametros("@tipoConta", contaBancaria.tipoConta);
                conexao.AdicionarParametros("@saldo", contaBancaria.saldo);
                sql.Clear();
                sql.AppendLine("INSERT INTO Financeiro_Conta_Bancaria(Data_Cadastro, Data_Atualizacao, Empresa, Banco, Agencia, ");
                sql.AppendLine("Conta_Corrente, Conta_Tipo, Saldo) VALUES (@dataCadastro, @dataAtualizacao, @empresa, @banco, @agencia, ");
                sql.AppendLine("@contaCorrente, @tipoConta, @saldo) SELECT @@IDENTITY AS retorno");
                string retorno = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}