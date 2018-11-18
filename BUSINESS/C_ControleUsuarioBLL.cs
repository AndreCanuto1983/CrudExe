//using Loja.DATA;
//using Loja.ENTITY;
//using Loja.FUNCTIONS;
//using System;
//using System.Data;
//using System.Text;
//using System.Windows.Forms;

//namespace Loja.BUSINESS
//{
//    class C_ControleUsuarioBLL
//    {
//        Funcoes funcoes = new Funcoes();
//        Conexao conexao = new Conexao();
//        public Int16 contador;

//        public string Gravar(C_ControleUsuarioENT c_controleUsuarioEnt)
//        {
//            try
//            {
//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@codigo", c_controleUsuarioEnt.codigo);
//                conexao.AdicionarParametros("@codModulo", c_controleUsuarioEnt.codModulo);
//                conexao.AdicionarParametros("@modulo", c_controleUsuarioEnt.modulo);
//                conexao.AdicionarParametros("@bloquearModulo", c_controleUsuarioEnt.bloquearModulo);
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("INSERT INTO Usuario (Usuario,Senha,Grupo,Data_Cadastro,Data_Atualizacao,Maquina,Versao,Data_Ult_Login,Ativo) ");
//                sql.AppendLine("VALUES(@usuario,@senha,@grupo,getdate(),getdate(),@maquina,@versao,getdate(),@ativo) ");
//                sql.AppendLine("SELECT @@IDENTITY AS retorno");
//                string codigo = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
//                return codigo;
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }

//        public string Atualizar(C_ControleUsuarioENT c_controleUsuarioEnt)
//        {
//            try
//            {
//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@codigo", c_controleUsuarioEnt.codigo);
//                conexao.AdicionarParametros("@codModulo", c_controleUsuarioEnt.codModulo);
//                conexao.AdicionarParametros("@modulo", c_controleUsuarioEnt.modulo);
//                conexao.AdicionarParametros("@bloquearModulo", c_controleUsuarioEnt.bloquearModulo);
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("UPDATE Usuario Set Usuario = @usuario, Senha = @senha, Grupo = @codigo_grupo, Data_Cadastro = @data_cadastro, ");
//                sql.AppendLine("Data_Atualizacao = getdate(), Maquina = @maquina, Versao = @versao, Data_Ult_Login = getdate(), Ativo = @ativo ");
//                sql.AppendLine("WHERE Codigo = @codigo ");
//                sql.AppendLine("SELECT Codigo FROM Usuario WHERE Codigo = @codigo AND Usuario = @usuario");
//                string codigo = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
//                return codigo;
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }

//        public string achou = "0";
//        public string BuscarPorCodigo(C_ControleUsuarioENT c_controleUsuarioEnt)
//        {
//            try
//            {
//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@codigo", c_controleUsuarioEnt.codigo);
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("SELECT u.Codigo,u.Usuario,u.Senha,u.Grupo AS 'Cód Grupo',ug.Grupo,u.Data_Cadastro, ");
//                sql.AppendLine("u.Data_Atualizacao,u.Maquina,u.Versao,u.Data_Ult_Login,u.Ativo FROM Usuario u  ");
//                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo  ");
//                sql.AppendLine("WHERE u.Codigo = @codigo");
//                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
//                foreach (DataRow dr in dt.Rows)
//                {
//                    c_controleUsuarioEnt.codigo = Convert.ToInt16(dr["Codigo"]);
//                    c_controleUsuarioEnt.codModulo = Convert.ToInt16(dr["Codigo"]);
//                    c_controleUsuarioEnt.modulo = dr["Senha"].ToString();
//                    c_controleUsuarioEnt.bloquearModulo = Convert.ToBoolean(dr["Ativo"]);
//                    return achou = "1";
//                }
//                return achou = "0";
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }

//        public string BuscarPorNome(C_ControleUsuarioENT c_controleUsuarioEnt)
//        {
//            try
//            {
//                achou = "0";
//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@usuario", usuario.usuario);
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("SELECT u.Codigo,u.Usuario,u.Senha,u.Grupo AS 'Cód Grupo',ug.Grupo,u.Data_Cadastro, ");
//                sql.AppendLine("u.Data_Atualizacao,u.Maquina,u.Versao,u.Data_Ult_Login,u.Ativo FROM Usuario u  ");
//                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo  ");
//                sql.AppendLine("WHERE u.Usuario = @usuario");
//                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
//                foreach (DataRow dr in dt.Rows)
//                {
//                    usuario.codigo = Convert.ToInt16(dr["Codigo"]);
//                    usuario.usuario = dr["Usuario"].ToString();
//                    usuario.senha = dr["Senha"].ToString();
//                    usuario.codigo_grupo = dr["Cód Grupo"].ToString();
//                    usuario.grupo = dr["Grupo"].ToString();
//                    usuario.data_cadastro = Convert.ToDateTime(dr["Data_Cadastro"]);
//                    usuario.data_atualizacao = Convert.ToDateTime(dr["Data_Atualizacao"]);
//                    usuario.maquina = dr["Maquina"].ToString();
//                    usuario.versao = dr["Versao"].ToString();
//                    usuario.data_ult_login = Convert.ToDateTime(dr["Data_Ult_Login"]);
//                    usuario.ativo = Convert.ToBoolean(dr["Ativo"]);
//                    return achou = "1";
//                }
//                return achou = "0";
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }
//        public string Excluir(C_ControleUsuarioENT c_controleUsuarioEnt)
//        {
//            try
//            {
//                string excluido = null;

//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
//                StringBuilder sqlExcluir = new StringBuilder();
//                sqlExcluir.Clear();
//                sqlExcluir.AppendLine("DELETE FROM Usuario_Empresa WHERE Usuario = @codigo ");
//                conexao.Manipular(CommandType.Text, Convert.ToString(sqlExcluir));

//                conexao.LimparParametros();
//                conexao.AdicionarParametros("@codigo", c_usuarioEnt.codigo);
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("DELETE FROM Usuario WHERE Codigo = @codigo ");
//                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
//                return excluido = c_usuarioEnt.codigo.ToString();
//            }
//            catch (Exception ex)
//            {
//                return ex.Message;
//            }
//        }
//        public string CarregarGrade(DataGridView grade)
//        {
//            string qtd_linhas = "0";
//            try
//            {
//                StringBuilder sql = new StringBuilder();
//                sql.Clear();
//                sql.AppendLine("SELECT u.Codigo AS 'Código', u.Usuario AS 'Usuário', u.Senha, u.Grupo AS 'Cód Grupo',ug.Grupo, ");
//                sql.AppendLine("u.Data_Cadastro  AS 'Data Cadastro', u.Data_Atualizacao AS 'Data Atualização', u.Maquina AS 'Máquina', u.Versao AS 'Versão', ");
//                sql.AppendLine("u.Data_Ult_Login AS 'Último Acesso', u.Ativo FROM Usuario u ");
//                sql.AppendLine("INNER JOIN Usuario_Grupo ug ON u.Grupo = ug.Codigo");
//                return qtd_linhas = conexao.PreencherGrade(grade, Convert.ToString(sql));
//            }
//            catch (Exception ex)
//            {
//                grade.Columns.Clear();
//                return ex.Message;
//            }
//        }
//    }
//}
