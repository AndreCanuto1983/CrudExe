using Loja.ENTITY;
using System;
using System.Data;
using Loja.DATA;
using System.Text;

namespace Loja.BUSINESS
{
    public class LoginBLL
    {
        Conexao conexao = new Conexao();       

        public string InserirUsuarioNaTemp(LoginENT login)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", login.codigo);
                conexao.AdicionarParametros("@usuario", login.usuario);
                conexao.AdicionarParametros("@ativo", login.ativo);
                conexao.AdicionarParametros("@grupo", login.grupo);
                conexao.AdicionarParametros("@maquina", login.maquina);
                conexao.AdicionarParametros("@versao", login.versao);
                conexao.AdicionarParametros("@data", login.data_ult_login);
                conexao.AdicionarParametros("@empresa", login.empresa_fantasia = "Empresas Canuto");
                StringBuilder sql = new StringBuilder();               
                sql.Clear();
                sql.AppendLine("INSERT INTO Temp (Codigo,Usuario,Ativo,Grupo,Empresa,Maquina,Versao,Data) ");
                sql.AppendLine("VALUES(@codigo,@usuario,@ativo,@grupo,@empresa,@maquina,@versao,@data) ");
                //sql.AppendLine("INSERT INTO Temp_Empresa (Codigo_Usuario,Empresa) ");
                //sql.AppendLine("VALUES(@codigo,@empresa) ");
                sql.AppendLine("SELECT Codigo FROM Temp WHERE Usuario = @usuario");
                string codigo = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
                return codigo;                
                //inserir usuário logado no controle, USAR QDO FINALIZAR O SISTEMA
                //sq.Clear();
                //sql.AppendLine("INSERT INTO Funcionario_Controle (Cod_Funcionario, Funcionario, Maquina, Data_Acesso, Versao) ");
                //sql.AppendLine("VALUES(@codigo,@usuario,@maquina,GETDATE(),@versao)");
                //conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AtualizarUsuarioLogado(LoginENT login)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", login.codigo);
                conexao.AdicionarParametros("@maquina", login.maquina);
                conexao.AdicionarParametros("@versao", login.versao);
                conexao.AdicionarParametros("@data", login.data_ult_login);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("UPDATE Usuario Set Maquina = @maquina, Versao = @versao, Data_Ult_Login = getdate() ");
                sql.AppendLine("WHERE Codigo = @codigo");                
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                string codigo = login.codigo.ToString();
                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string entrou = "";
        public string VerificarUsuarioDoLogin(LoginENT login)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@usuario", login.usuario);
                conexao.AdicionarParametros("@senha", login.senha);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("SELECT u.Codigo, u.Usuario, u.Senha, ug.grupo, u.Data_Cadastro, u.Data_Atualizacao,  ");
                sql.AppendLine("u.Maquina, u.Versao, u.Data_Ult_Login, U.Ativo FROM usuario u --, ue.Empresa, e.Fantasia, ue.Contratual ");
                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo ");
                sql.AppendLine("--INNER JOIN Usuario_Empresa ue ON u.Codigo = ue.Usuario ");
                sql.AppendLine("--INNER JOIN Empresa e ON ue.Empresa = e.Codigo ");
                sql.AppendLine("WHERE u.Usuario = @usuario AND u.Senha = @senha");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    login.codigo = Convert.ToInt16(dr["Codigo"]);
                    login.usuario = dr["Usuario"].ToString();
                    login.senha = dr["Senha"].ToString();
                    login.grupo = dr["Grupo"].ToString();
                    login.data_cadastro = Convert.ToDateTime(dr["Data_Cadastro"]);
                    login.data_atualizacao = Convert.ToDateTime(dr["Data_Atualizacao"]);
                    login.maquina = dr["Maquina"].ToString();
                    login.versao = dr["Versao"].ToString();
                    login.data_ult_login = Convert.ToDateTime(dr["Data_Ult_Login"]);
                    login.ativo = Convert.ToBoolean(dr["Ativo"]);
                    //login.empresa = Convert.ToInt16(dr["Empresa"]);
                    //login.empresa_fantasia = dr["Fantasia"].ToString();
                    return entrou = "1";
                }
                return entrou = "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}