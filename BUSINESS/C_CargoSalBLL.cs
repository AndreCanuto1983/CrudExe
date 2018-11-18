using Loja.FUNCTIONS;
using Loja.ENTITY;
using Loja.DATA;
using System;
using System.Data;
using System.Windows.Forms;
using System.Text;

namespace Loja.BUSINESS
{   
    public class C_CargoSalBLL
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        StringBuilder sql = new StringBuilder();
        public string CarregarDados(C_CargosSalariosENT cargosSalarios)
        {
            string retorno = "0";
            try
            {                
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", cargosSalarios.codigo);
                sql.Clear();
                sql.AppendLine("SELECT * FROM Rh_Cargo_Salario WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    cargosSalarios.codigo = Convert.ToInt16(dr["Codigo"]);
                    cargosSalarios.data = Convert.ToDateTime(dr["Data"].ToString());
                    cargosSalarios.dataAtualizacao = Convert.ToDateTime(dr["Data_Atualizacao"].ToString());
                    cargosSalarios.cargo = dr["Cargo"].ToString();
                    cargosSalarios.salario = (dr["Salario"].ToString());
                    cargosSalarios.descricao = dr["Descricao"].ToString();                    
                    retorno = "1";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ConsultarPorNome(C_CargosSalariosENT cargosSalarios)
        {
            string retorno = null;
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@cargo", cargosSalarios.cargo);
                sql.Clear();
                sql.AppendLine("SELECT Cargo FROM Rh_Cargo_Salario WHERE cargo = @cargo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    retorno = cargosSalarios.cargo = dr["Cargo"].ToString();                    
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
            try
            {
                sql.Clear();
                string qtd_linhas = "0";
                sql.AppendLine("SELECT Codigo AS Código, Data AS 'Data Cadastro', Data_Atualizacao AS 'Data Atualização', ");
                sql.AppendLine("Cargo, Salario AS 'Salário', Descricao AS 'Descrição' ");
                sql.AppendLine("FROM Rh_Cargo_Salario");
                qtd_linhas = conexao.PreencherGrade(grade, Convert.ToString(sql));
                return qtd_linhas;
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();
                return ex.Message;
            }
        }

        public string Excluir(C_CargosSalariosENT cargosSalarios)
        {            
            try
            {
                string excluido = null;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", cargosSalarios.codigo);
                sql.Clear();
                sql.AppendLine("DELETE Rh_Cargo_Salario WHERE Codigo = @codigo");
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return excluido = cargosSalarios.codigo.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(C_CargosSalariosENT cargosSalarios)
        {            
            try
            {
                string retorno = null;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", cargosSalarios.codigo);
                conexao.AdicionarParametros("@data", cargosSalarios.data);                
                conexao.AdicionarParametros("@cargo", cargosSalarios.cargo);
                conexao.AdicionarParametros("@salario", cargosSalarios.salario);
                conexao.AdicionarParametros("@descricao", cargosSalarios.descricao);
                sql.Clear();
                sql.AppendLine("UPDATE Rh_Cargo_Salario SET Data = @data, Data_Atualizacao = GETDATE(), ");
                sql.AppendLine("Cargo = @cargo, Salario = @salario, descricao = @descricao WHERE Codigo = @codigo");                
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return retorno = cargosSalarios.codigo.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Gravar(C_CargosSalariosENT cargosSalarios)
        {
            try
            {
                string retorno = null;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", cargosSalarios.codigo);
                conexao.AdicionarParametros("@data", cargosSalarios.data);                
                conexao.AdicionarParametros("@cargo", cargosSalarios.cargo);
                conexao.AdicionarParametros("@salario", Convert.ToDecimal(cargosSalarios.salario)); //cargosSalarios.salario.Replace(".",",")
                conexao.AdicionarParametros("@descricao", cargosSalarios.descricao);
                sql.Clear();
                sql.AppendLine("INSERT INTO Rh_Cargo_Salario(Data, Data_Atualizacao, Cargo, Salario, Descricao) ");
                sql.AppendLine("VALUES (@data, GETDATE(), @cargo, @salario, @descricao) ");
                sql.AppendLine("SELECT @@IDENTITY AS retorno");
                return retorno = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();               
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }        
    }
}


//public void ConfigurarGrade(DataGridView grade)
//{
//    //setando os nomes das colunas
//    grade.Columns[0].HeaderText = "Código";
//    grade.Columns[1].HeaderText = "Cargo";
//    grade.Columns[2].HeaderText = "Salário";
//    grade.Columns[3].HeaderText = "Descrição";
//    //setando o tamanho das colunas
//    grade.Columns[0].Width = 60;
//    grade.Columns[1].Width = 150;
//    grade.Columns[2].Width = 80;
//    grade.Columns[3].Width = 310;
//}
