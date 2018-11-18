using System;
using System.Data;
using System.Windows.Forms;
using Loja.ENTITY;
using Loja.DATA;
using Loja.FUNCTIONS;
using System.Text;

namespace Loja.BUSINESS
{
    public class C_GrupoUsuarioBLL
    {
        Conexao conexao = new Conexao();
        Funcoes funcoes = new Funcoes();
        StringBuilder sql = new StringBuilder();
        public string ConsultarPorCodigo(C_GrupoUsuarioENT c_grupoUsuarioEnt)
        {
            string retorno = "0";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_grupoUsuarioEnt.codigo);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Grupo FROM Usuario_Grupo WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    c_grupoUsuarioEnt.codigo = Convert.ToInt16(dr["Codigo"]);
                    c_grupoUsuarioEnt.grupo = dr["Grupo"].ToString();
                    retorno = "1";
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        
        public string ConsultarPorNome(C_GrupoUsuarioENT c_grupoUsuarioEnt)
        {
            string retorno = "0";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@grupo", c_grupoUsuarioEnt.grupo);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Grupo FROM Usuario_Grupo WHERE Grupo = @grupo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    c_grupoUsuarioEnt.codigo = Convert.ToInt16(dr["Codigo"]);
                    c_grupoUsuarioEnt.grupo = dr["Grupo"].ToString();
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
                conexao.LimparParametros();
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Grupo FROM Usuario_Grupo");
                return qtd_linhas = conexao.PreencherGrade(grade, Convert.ToString(sql));
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();                
                return ex.Message;
            }
        }

        public string Excluir(C_GrupoUsuarioENT c_grupoUsuarioEnt)
        {
            string excluido = "0";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_grupoUsuarioEnt.codigo);
                sql.Clear();
                sql.AppendLine("DELETE Usuario_Grupo WHERE Codigo = @codigo");
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));                
                return excluido = "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(C_GrupoUsuarioENT c_grupoUsuarioEnt)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_grupoUsuarioEnt.codigo);
                conexao.AdicionarParametros("@grupo", c_grupoUsuarioEnt.grupo);
                sql.Clear();
                sql.AppendLine("UPDATE Usuario_Grupo SET Grupo = @grupo WHERE Codigo = @codigo ");
                sql.AppendLine("SELECT Codigo FROM Usuario_Grupo WHERE Grupo = @grupo");
                string retorno = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Gravar(C_GrupoUsuarioENT c_grupoUsuarioEnt)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@grupo", c_grupoUsuarioEnt.grupo);
                sql.Clear();
                sql.AppendLine("INSERT INTO Usuario_Grupo (Grupo) VALUES (@grupo) SELECT @@IDENTITY AS retorno");                
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