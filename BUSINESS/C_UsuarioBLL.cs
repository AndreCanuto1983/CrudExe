using Loja.DATA;
using Loja.ENTITY;
using Loja.FUNCTIONS;
using System;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Loja.BUSINESS
{
    class C_UsuarioBLL
    {
        Funcoes funcoes = new Funcoes();
        Conexao conexao = new Conexao();        
        public Int16 contador;

        public string Gravar(C_UsuarioENT c_usuarioEnt)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@usuario", c_usuarioEnt.usuario);
                conexao.AdicionarParametros("@senha", c_usuarioEnt.senha);
                conexao.AdicionarParametros("@grupo", c_usuarioEnt.codigo_grupo);
                conexao.AdicionarParametros("@data_cadastro", c_usuarioEnt.data_cadastro);
                conexao.AdicionarParametros("@data_atualizacao", c_usuarioEnt.data_atualizacao);
                conexao.AdicionarParametros("@maquina", c_usuarioEnt.maquina);
                conexao.AdicionarParametros("@versao", c_usuarioEnt.versao);
                conexao.AdicionarParametros("@data", c_usuarioEnt.data_ult_login);
                conexao.AdicionarParametros("@ativo", c_usuarioEnt.ativo);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("INSERT INTO Usuario (Usuario,Senha,Grupo,Data_Cadastro,Data_Atualizacao,Maquina,Versao,Data_Ult_Login,Ativo) ");
                sql.AppendLine("VALUES(@usuario,@senha,@grupo,getdate(),getdate(),@maquina,@versao,getdate(),@ativo) ");
                sql.AppendLine("SELECT @@IDENTITY AS retorno");
                string codigo = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();

                sql.Clear();
                foreach (Int16 lista_empresa in c_usuarioEnt.lista_empresa)
                {
                    conexao.LimparParametros();
                    conexao.AdicionarParametros("@lista_empresa", lista_empresa);
                    conexao.AdicionarParametros("@codigo", Convert.ToInt16(codigo));
                    sql.AppendLine("INSERT INTO Usuario_Empresa (Usuario,Empresa) ");
                    sql.AppendLine("VALUES(@codigo,@lista_empresa)");
                    conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                    sql.Clear();                    
                }
                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }            
        }

        public string Atualizar(C_UsuarioENT c_usuarioEnt)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
                conexao.AdicionarParametros("@usuario", c_usuarioEnt.usuario);
                conexao.AdicionarParametros("@senha", c_usuarioEnt.senha);
                conexao.AdicionarParametros("@codigo_grupo", c_usuarioEnt.codigo_grupo);
                conexao.AdicionarParametros("@grupo", c_usuarioEnt.grupo);
                conexao.AdicionarParametros("@data_cadastro", c_usuarioEnt.data_cadastro);
                conexao.AdicionarParametros("@data_atualizacao", c_usuarioEnt.data_atualizacao);
                conexao.AdicionarParametros("@maquina", c_usuarioEnt.maquina);
                conexao.AdicionarParametros("@versao", c_usuarioEnt.versao);
                conexao.AdicionarParametros("@data", c_usuarioEnt.data_ult_login);                
                conexao.AdicionarParametros("@ativo", c_usuarioEnt.ativo);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("UPDATE Usuario Set Usuario = @usuario, Senha = @senha, Grupo = @codigo_grupo, Data_Cadastro = @data_cadastro, ");
                sql.AppendLine("Data_Atualizacao = getdate(), Maquina = @maquina, Versao = @versao, Data_Ult_Login = getdate(), Ativo = @ativo ");
                sql.AppendLine("WHERE Codigo = @codigo ");
                sql.AppendLine("SELECT Codigo FROM Usuario WHERE Codigo = @codigo AND Usuario = @usuario" );
                string codigo = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();

                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
                StringBuilder sqlExcluir = new StringBuilder();
                sqlExcluir.Clear();
                sqlExcluir.AppendLine("DELETE FROM Usuario_Empresa WHERE Usuario = @codigo ");
                conexao.Manipular(CommandType.Text, Convert.ToString(sqlExcluir));

                sql.Clear();
                foreach (Int16 lista_empresa in c_usuarioEnt.lista_empresa)
                {
                    conexao.LimparParametros();
                    conexao.AdicionarParametros("@lista_empresa", lista_empresa);
                    conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
                    sql.AppendLine("INSERT INTO Usuario_Empresa (Usuario,Empresa) ");
                    sql.AppendLine("VALUES(@codigo,@lista_empresa)");
                    conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                    sql.Clear();
                }
                return codigo;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string achou = "0";
        public string BuscarPorCodigo(C_UsuarioENT usuario)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", usuario.codigo);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("SELECT u.Codigo,u.Usuario,u.Senha,u.Grupo AS 'Cód Grupo',ug.Grupo,u.Data_Cadastro, ");
                sql.AppendLine("u.Data_Atualizacao,u.Maquina,u.Versao,u.Data_Ult_Login,u.Ativo FROM Usuario u  ");
                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo  ");
                sql.AppendLine("WHERE u.Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    usuario.codigo = Convert.ToInt16(dr["Codigo"]);
                    usuario.usuario = dr["Usuario"].ToString();
                    usuario.senha = dr["Senha"].ToString();
                    usuario.codigo_grupo = dr["Cód Grupo"].ToString();
                    usuario.grupo = dr["Grupo"].ToString();                    
                    usuario.data_cadastro = Convert.ToDateTime(dr["Data_Cadastro"]);
                    usuario.data_atualizacao = Convert.ToDateTime(dr["Data_Atualizacao"]);
                    usuario.maquina = dr["Maquina"].ToString();
                    usuario.versao = dr["Versao"].ToString();
                    usuario.data_ult_login = Convert.ToDateTime(dr["Data_Ult_Login"]);                    
                    usuario.ativo = Convert.ToBoolean(dr["Ativo"]);
                    return achou = "1";
                }
                return achou = "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
                
        public string BuscarPorNome(C_UsuarioENT usuario)
        {
            try
            {
                achou = "0";
                conexao.LimparParametros();
                conexao.AdicionarParametros("@usuario", usuario.usuario);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("SELECT u.Codigo,u.Usuario,u.Senha,u.Grupo AS 'Cód Grupo',ug.Grupo,u.Data_Cadastro, ");
                sql.AppendLine("u.Data_Atualizacao,u.Maquina,u.Versao,u.Data_Ult_Login,u.Ativo FROM Usuario u  ");
                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo  ");
                sql.AppendLine("WHERE u.Usuario = @usuario");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    usuario.codigo = Convert.ToInt16(dr["Codigo"]);
                    usuario.usuario = dr["Usuario"].ToString();
                    usuario.senha = dr["Senha"].ToString();
                    usuario.codigo_grupo = dr["Cód Grupo"].ToString();
                    usuario.grupo = dr["Grupo"].ToString();
                    usuario.data_cadastro = Convert.ToDateTime(dr["Data_Cadastro"]);
                    usuario.data_atualizacao = Convert.ToDateTime(dr["Data_Atualizacao"]);
                    usuario.maquina = dr["Maquina"].ToString();
                    usuario.versao = dr["Versao"].ToString();
                    usuario.data_ult_login = Convert.ToDateTime(dr["Data_Ult_Login"]);
                    usuario.ativo = Convert.ToBoolean(dr["Ativo"]);
                    return achou = "1";
                }
                return achou = "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        public string Excluir(C_UsuarioENT c_usuarioEnt)
        {
            try
            {
                string excluido = null;

                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
                StringBuilder sqlExcluir = new StringBuilder();
                sqlExcluir.Clear();
                sqlExcluir.AppendLine("DELETE FROM Usuario_Empresa WHERE Usuario = @codigo ");
                conexao.Manipular(CommandType.Text, Convert.ToString(sqlExcluir));

                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("DELETE FROM Usuario WHERE Codigo = @codigo ");                
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return excluido = c_usuarioEnt.codigo.ToString();
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
                StringBuilder sql = new StringBuilder();
                sql.Clear();
                sql.AppendLine("SELECT u.Codigo AS 'Código', u.Usuario AS 'Usuário', u.Senha, u.Grupo AS 'Cód Grupo',ug.Grupo, ");
                sql.AppendLine("u.Data_Cadastro  AS 'Data Cadastro', u.Data_Atualizacao AS 'Data Atualização', u.Maquina AS 'Máquina', u.Versao AS 'Versão', ");
                sql.AppendLine("u.Data_Ult_Login AS 'Último Acesso', u.Ativo FROM Usuario u ");
                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo");
                return qtd_linhas = conexao.PreencherGrade(grade, Convert.ToString(sql));
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();
                return ex.Message;
            }
        }   
    }
}
