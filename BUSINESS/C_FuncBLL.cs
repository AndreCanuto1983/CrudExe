using System;
using System.Windows.Forms;
using Loja.FUNCTIONS;
using Loja.DATA;
using Loja.ENTITY;
using System.Data;
using System.Data.SqlTypes;
using System.Text;

namespace Loja.BUSINESS
{
    public class C_FuncBLL
    {
        Funcoes funcoes = new Funcoes();
        Conexao conexao = new Conexao();
        C_FuncionarioENT func = new C_FuncionarioENT();
        StringBuilder sql = new StringBuilder();

        public int contador;
        public string ConsultarGravado(C_FuncionarioENT func)
        {
            string retorno = null;
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@cpf", func.cpf);
                sql.Clear();
                sql.AppendLine("SELECT CPF FROM Funcionario WHERE CPF = @CPF");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    retorno = dr["CPF"].ToString();
                }
                return retorno;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void MostrarSalario(ComboBox cargo, TextBox salario, EventArgs e)
        {
            try
            {
                if (cargo.SelectedIndex > 0)
                {
                    conexao.LimparParametros();
                    conexao.AdicionarParametros("@codigo", cargo.SelectedValue);
                    sql.Clear();
                    sql.AppendLine("SELECT Salario FROM Rh_Cargo_Salario WHERE Codigo = @codigo");
                    DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                    foreach (DataRow dr in dt.Rows)
                    {
                        salario.Text = dr["Salario"].ToString();
                    }
                }
                else
                {
                    salario.Text = "0,00";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao carregar ós dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void BuscarFuncionario(C_FuncionarioENT func)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", func.codigo);
                sql.Clear();
                sql.AppendLine("SELECT F.*, E.Fantasia, FG.Grupo FROM Funcionario F ");
                sql.AppendLine("LEFT JOIN Empresa E ON F.Empresa = E.Codigo ");
                sql.AppendLine("LEFT JOIN Funcionario_Grupo FG ON F.Grupo = FG.Codigo ");
                sql.AppendLine("WHERE F.Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    func.nome = dr["Nome"].ToString();
                    func.data_cadastro = dr["Data_Cadastro"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Data_Cadastro"]);
                    func.data_ult_atual = dr["Data_Ultima_At"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Data_Ultima_At"]);
                    func.data_nascimento = dr["Data_Nascimento"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Data_Nascimento"]);
                    func.genero = dr["Genero"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Genero"]);                    
                    func.nome = dr["Nome"].ToString();
                    func.cpf = dr["Cpf"].ToString();
                    func.rg = dr["Rg"].ToString();
                    func.situacao = dr["situacao"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["situacao"]);                    
                    if (dr["Foto"] != DBNull.Value) //verifico se o retorno da base é null
                    {
                        func.foto = (byte[])dr["Foto"]; //recebo o array de foto do banco
                    }
                    func.emp_contratual = dr["Empresa"].Equals(DBNull.Value) ? 0 : Convert.ToInt64(dr["Empresa"]);                    
                    func.telefone = dr["Telefone"].ToString();
                    func.celular = dr["Celular"].ToString();
                    func.email = dr["Email"].ToString();
                    func.endereco = dr["Endereco"].ToString();
                    func.numero = dr["Numero"].ToString();
                    func.bairro = dr["Bairro"].ToString();
                    func.cep = dr["Cep"].ToString();
                    func.complemento = dr["Complemento"].ToString();
                    func.cidade = dr["Cidade"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Cidade"]);
                    func.estado = dr["Uf"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Uf"]);
                    func.pais = dr["Pais"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Pais"]);                    
                    func.nome_pai = dr["Nome_Pai"].ToString();
                    func.nome_mae = dr["Nome_Mae"].Equals(DBNull.Value) ? "" : dr["Nome_Mae"].ToString();
                    func.raca_cor = dr["Raca_Cor"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Raca_Cor"]);                    
                    func.estado_civil = dr["Estado_Civil"].ToString();
                    func.deficiente = dr["Deficiente"].ToString();
                    func.tipo_deficiencia = dr["Tipo_Deficiencia"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Tipo_Deficiencia"]);                    
                    func.ctps = dr["CTPS"].ToString();
                    func.ctps_serie = dr["CTPS_Serie"].ToString();
                    func.ctps_uf = dr["CTPS_Uf"].ToString();
                    func.ctps_emissao = dr["CTPS_Emissao"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["CTPS_Emissao"]);
                    func.ctps_orgao_expedidor = dr["CTPS_Orgao_Exp"].ToString();
                    func.pis = dr["Pis"].ToString();
                    func.pis_emissao = dr["Pis_Emissao"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Pis_Emissao"]);
                    func.titulo_numero = dr["Titulo_Eleitor"].ToString();
                    func.titulo_zona = dr["Titulo_Zona"].ToString();
                    func.titulo_secao = dr["Titulo_Secao"].ToString();
                    func.reservista_nr = dr["Reservista_Nr"].ToString();
                    func.reservista_ra = dr["Reservista_Ra"].ToString();
                    func.cnh_numero = dr["Cnh"].ToString();
                    func.cnh_validade = dr["Cnh_Validade"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Cnh_Validade"]);
                    func.cnh_orgao_expedidor = dr["Cnh_Orgao"].ToString();
                    func.cnh_categoria = dr["Cnh_Categoria"].ToString();
                    func.cnh_data_emissao = dr["Cnh_Emissao"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Cnh_Emissao"]);
                    func.data_admissao = dr["Data_Admissao"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Data_Admissao"]);
                    func.data_exame_medico = dr["Data_Exame_Medico"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Data_Exame_Medico"]);
                    func.data_inicio_experiencia = dr["Experiencia_Inicio"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Experiencia_Inicio"]);
                    func.data_fim_experiencia = dr["Experiencia_fim"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Experiencia_fim"]);
                    func.data_prorrogacao = dr["Experiencia_Prorrogacao"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Experiencia_Prorrogacao"]);        
                    func.observacao = dr["Observacao"].ToString();
                    func.demitido = dr["Demitido"].ToString();
                    func.data_demissao = dr["Demissao_Data"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Demissao_Data"]);                    
                    func.motivo_demissao = dr["Demissao_Motivo"].ToString();
                    func.rescisao_caged = dr["Rescisao_Caged"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Rescisao_Caged"]);
                    func.cargo = dr["Cargo"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Cargo"]);
                    func.tipo_contrato = dr["Tipo_Contrato"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Tipo_Contrato"]);
                    func.admissao_caged = dr["Admissao_Caged"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Admissao_Caged"]);
                    func.setor = dr["Setor"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Setor"]);
                    func.departamento = dr["Departamento"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Departamento"]);
                    func.grupo_funcionario = dr["Grupo"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Grupo"]);
                    func.banco = dr["Banco"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Banco"]);                    
                    func.agencia = dr["Agencia"].ToString();
                    func.numero_conta = dr["Numero_Conta"].ToString();
                    func.tipo_conta = dr["Tipo_Conta_Bancaria"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Tipo_Conta_Bancaria"]);
                    func.grau_instrucao = dr["Grau_Instrucao"].Equals(DBNull.Value) ? 0 : Convert.ToInt32(dr["Grau_Instrucao"]);
                    func.instituicao_ensino = dr["Instituicao_Ensino"].ToString();
                    func.curso = dr["Curso"].ToString();
                    func.curso_inicio = dr["Curso_Inicio"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Curso_Inicio"]);
                    func.curso_fim = dr["Curso_Fim"].Equals(DBNull.Value) ? DateTime.Now : Convert.ToDateTime(dr["Curso_Fim"]);                    
                    func.outros_cursos = dr["Curso_Outros"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar funcionário. Detalhes" + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string Deletar(C_FuncionarioENT func)
        {
            try
            {
                string excluido = null;
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", func.codigo);
                sql.Clear();
                sql.AppendLine("DELETE FROM Funcionario WHERE Codigo = @codigo ");
                sql.AppendLine("DELETE FROM Funcionario_Empresa_Gerencial WHERE Funcionario = @codigo");
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return excluido = func.codigo.ToString();
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Gravar(C_FuncionarioENT func)
        {
            string retorno = "";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", func.codigo);
                conexao.AdicionarParametros("@dataCadastro", func.data_cadastro);
                conexao.AdicionarParametros("@dataNascimento", func.data_nascimento);
                conexao.AdicionarParametros("@dataUltAtual", func.data_ult_atual);
                conexao.AdicionarParametros("@nome", func.nome);
                conexao.AdicionarParametros("@cpf", func.cpf);
                conexao.AdicionarParametros("@rg", func.rg);
                conexao.AdicionarParametros("@grupoFuncionario", func.grupo_funcionario);
                conexao.AdicionarParametros("@genero", func.genero);
                conexao.AdicionarParametros("@empresaContratual", func.empresa_contratual);
                conexao.AdicionarParametros("@situacao", func.situacao);
                conexao.AdicionarParametros("@foto", func.foto);
                conexao.AdicionarParametros("@telefone", func.telefone);
                conexao.AdicionarParametros("@celular", func.celular);
                conexao.AdicionarParametros("@email", func.email);
                conexao.AdicionarParametros("@endereco", func.endereco);
                conexao.AdicionarParametros("@numero", func.numero);
                conexao.AdicionarParametros("@bairro", func.bairro);
                conexao.AdicionarParametros("@cep", func.cep);
                conexao.AdicionarParametros("@complemento", func.complemento);
                conexao.AdicionarParametros("@cidade", func.cidade);
                conexao.AdicionarParametros("@estado", func.estado);
                conexao.AdicionarParametros("@pais", func.pais);
                conexao.AdicionarParametros("@nome_pai", func.nome_pai);
                conexao.AdicionarParametros("@nome_mae", func.nome_mae);
                conexao.AdicionarParametros("@raca_cor", func.raca_cor);
                conexao.AdicionarParametros("@estado_civil", func.estado_civil);
                conexao.AdicionarParametros("@deficiente", func.deficiente);
                conexao.AdicionarParametros("@tipo_deficiencia", func.tipo_deficiencia);
                conexao.AdicionarParametros("@ctps", func.ctps);
                conexao.AdicionarParametros("@ctps_serie", func.ctps_serie);
                conexao.AdicionarParametros("@ctps_uf", func.ctps_uf);
                conexao.AdicionarParametros("@ctps_emissao", func.ctps_emissao);
                conexao.AdicionarParametros("@ctps_orgao_expedidor", func.ctps_orgao_expedidor);
                conexao.AdicionarParametros("@pis", func.pis);
                conexao.AdicionarParametros("@pis_emissao", func.pis_emissao);
                conexao.AdicionarParametros("@titulo_numero", func.titulo_numero);
                conexao.AdicionarParametros("@titulo_zona", func.titulo_zona);
                conexao.AdicionarParametros("@titulo_secao", func.titulo_secao);
                conexao.AdicionarParametros("@reservista_nr", func.reservista_nr);
                conexao.AdicionarParametros("@reservista_ra", func.reservista_ra);
                conexao.AdicionarParametros("@cnh_numero", func.cnh_numero);
                conexao.AdicionarParametros("@cnh_validade", func.cnh_validade);
                conexao.AdicionarParametros("@cnh_orgao_expedidor", func.cnh_orgao_expedidor);
                conexao.AdicionarParametros("@cnh_categoria", func.cnh_categoria);
                conexao.AdicionarParametros("@cnh_data_emissao", func.cnh_data_emissao);
                conexao.AdicionarParametros("@data_admissao", func.data_admissao);
                conexao.AdicionarParametros("@data_exame_medico", func.data_exame_medico);
                conexao.AdicionarParametros("@data_inicio_experiencia", func.data_inicio_experiencia);
                conexao.AdicionarParametros("@data_fim_experiencia", func.data_fim_experiencia);
                conexao.AdicionarParametros("@data_prorrogacao", func.data_prorrogacao);                
                conexao.AdicionarParametros("@observacao", func.observacao);
                conexao.AdicionarParametros("@demitido", func.demitido);
                conexao.AdicionarParametros("@data_demissao", func.data_demissao);
                conexao.AdicionarParametros("@motivo_demissao", func.motivo_demissao);
                conexao.AdicionarParametros("@rescisao_caged", func.rescisao_caged);
                conexao.AdicionarParametros("@cargo", func.cargo);
                conexao.AdicionarParametros("@tipo_contrato", func.tipo_contrato);
                conexao.AdicionarParametros("@admissao_caged", func.admissao_caged);
                conexao.AdicionarParametros("@setor", func.setor);
                conexao.AdicionarParametros("@departamento", func.departamento);
                conexao.AdicionarParametros("@banco", func.banco);
                conexao.AdicionarParametros("@agencia", func.agencia);
                conexao.AdicionarParametros("@numero_conta", func.numero_conta);
                conexao.AdicionarParametros("@tipo_conta", func.tipo_conta);
                conexao.AdicionarParametros("@grau_instrucao", func.grau_instrucao);
                conexao.AdicionarParametros("@instituicao_ensino", func.instituicao_ensino);
                conexao.AdicionarParametros("@curso", func.curso);
                conexao.AdicionarParametros("@curso_inicio", func.curso_inicio);
                conexao.AdicionarParametros("@curso_fim", func.curso_fim);
                conexao.AdicionarParametros("@outros_cursos", func.outros_cursos);
                sql.Clear();
                sql.AppendLine("INSERT INTO Funcionario (Data_Cadastro, Data_Nascimento,Data_Ultima_At,Nome,CPF,RG,Grupo,Genero, ");
                sql.AppendLine("Situacao,Foto,Empresa,Telefone,Celular,Email,Endereco,Numero,Bairro, ");
                sql.AppendLine("Cep,Complemento,Cidade,Uf,Pais,Nome_Pai,Nome_Mae,Raca_Cor,Estado_Civil,Deficiente, ");
                sql.AppendLine("Tipo_Deficiencia,CTPS,CTPS_Serie,CTPS_UF,CTPS_Emissao,CTPS_Orgao_Exp,PIS,PIS_Emissao, ");
                sql.AppendLine("Titulo_Eleitor,Titulo_Zona,Titulo_Secao,Reservista_Nr,Reservista_Ra,CNH,CNH_Validade, ");
                sql.AppendLine("CNH_Orgao,CNH_Categoria,CNH_Emissao,Data_Admissao,Data_Exame_Medico,Experiencia_Inicio, ");
                sql.AppendLine("Experiencia_Fim,Experiencia_Prorrogacao, ");
                sql.AppendLine("Observacao,Demitido,Demissao_Data,Demissao_Motivo,Rescisao_Caged,Cargo,Tipo_Contrato, ");
                sql.AppendLine("Admissao_Caged,Setor,Departamento,Banco,Agencia,Numero_Conta,Tipo_Conta_Bancaria,Grau_Instrucao, ");
                sql.AppendLine("Instituicao_Ensino,curso,Curso_Inicio,Curso_Fim,Curso_Outros) ");
                sql.AppendLine("VALUES(@dataCadastro,@dataNascimento,@dataUltAtual,@nome,@cpf,@rg,@grupoFuncionario, ");
                sql.AppendLine("@genero,@situacao,@foto,@empresaContratual,@telefone,@celular,@email,@endereco, ");
                sql.AppendLine("@numero,@bairro,@cep,@complemento,@cidade,@estado,@pais,@nome_pai,@nome_mae,@raca_cor,@estado_civil, ");
                sql.AppendLine("@deficiente,@tipo_deficiencia,@ctps,@ctps_serie,@ctps_uf,@ctps_emissao,@ctps_orgao_expedidor, ");
                sql.AppendLine("@pis,@pis_emissao,@titulo_numero,@titulo_zona,@titulo_secao,@reservista_nr,@reservista_ra,@cnh_numero, ");
                sql.AppendLine("@cnh_validade,@cnh_orgao_expedidor,@cnh_categoria,@cnh_data_emissao,@data_admissao,@data_exame_medico, ");
                sql.AppendLine("@data_inicio_experiencia,@data_fim_experiencia,@data_prorrogacao, ");
                sql.AppendLine("@observacao,@demitido,@data_demissao,@motivo_demissao, ");
                sql.AppendLine("@rescisao_caged,@cargo,@tipo_contrato,@admissao_caged,@setor,@departamento,@banco,@agencia, ");
                sql.AppendLine("@numero_conta,@tipo_conta,@grau_instrucao,@instituicao_ensino,@curso,@curso_inicio,@curso_fim, ");
                sql.AppendLine("@outros_cursos) SELECT @@IDENTITY");
                return retorno = conexao.Manipular(CommandType.Text, Convert.ToString(sql)).ToString();
                /*
                int count = func.ListEmpresaGerencial.Count;
                if (count > 0)
                {
                    for (int i = 0; i < func.ListEmpresaGerencial.Count; i++)
                    {
                        conexao.AdicionarParametros("@listaEmpGerencial", func.ListEmpresaGerencial[i]);
                        sql.Clear();
                        sql.AppendLine("INSERT INTO Funcionario_Empresa_Gerencial (Funcionario,Empresa) VALUES (@codigo, @listaEmpGerencial)");
                        conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                    }
                } 
                */
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string Atualizar(C_FuncionarioENT func)
        {
            string retorno = "";
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", func.codigo);
                conexao.AdicionarParametros("@dataCadastro", func.data_cadastro);
                conexao.AdicionarParametros("@dataNascimento", func.data_nascimento);
                conexao.AdicionarParametros("@dataUltAtual", func.data_ult_atual);
                conexao.AdicionarParametros("@nome", func.nome);
                conexao.AdicionarParametros("@cpf", func.cpf);
                conexao.AdicionarParametros("@rg", func.rg);
                conexao.AdicionarParametros("@grupoFuncionario", func.grupo_funcionario);
                conexao.AdicionarParametros("@genero", func.genero);
                conexao.AdicionarParametros("@empresaContratual", func.emp_contratual);
                conexao.AdicionarParametros("@situacao", func.situacao);
                conexao.AdicionarParametros("@foto", func.foto); 
                conexao.AdicionarParametros("@telefone", func.telefone);
                conexao.AdicionarParametros("@celular", func.celular);
                conexao.AdicionarParametros("@email", func.email);
                conexao.AdicionarParametros("@endereco", func.endereco);
                conexao.AdicionarParametros("@numero", func.numero);
                conexao.AdicionarParametros("@bairro", func.bairro);
                conexao.AdicionarParametros("@cep", func.cep);
                conexao.AdicionarParametros("@complemento", func.complemento);
                conexao.AdicionarParametros("@cidade", func.cidade);
                conexao.AdicionarParametros("@estado", func.estado);
                conexao.AdicionarParametros("@pais", func.pais);
                conexao.AdicionarParametros("@nome_pai", func.nome_pai);
                conexao.AdicionarParametros("@nome_mae", func.nome_mae);
                conexao.AdicionarParametros("@raca_cor", func.raca_cor);
                conexao.AdicionarParametros("@estado_civil", func.estado_civil);
                conexao.AdicionarParametros("@deficiente", func.deficiente);
                conexao.AdicionarParametros("@tipo_deficiencia", func.tipo_deficiencia);
                conexao.AdicionarParametros("@ctps", func.ctps);
                conexao.AdicionarParametros("@ctps_serie", func.ctps_serie);
                conexao.AdicionarParametros("@ctps_uf", func.ctps_uf);
                conexao.AdicionarParametros("@ctps_emissao", func.ctps_emissao);
                conexao.AdicionarParametros("@ctps_orgao_expedidor", func.ctps_orgao_expedidor);
                conexao.AdicionarParametros("@pis", func.pis);
                conexao.AdicionarParametros("@pis_emissao", func.pis_emissao);
                conexao.AdicionarParametros("@titulo_numero", func.titulo_numero);
                conexao.AdicionarParametros("@titulo_zona", func.titulo_zona);
                conexao.AdicionarParametros("@titulo_secao", func.titulo_secao);
                conexao.AdicionarParametros("@reservista_nr", func.reservista_nr);
                conexao.AdicionarParametros("@reservista_ra", func.reservista_ra);
                conexao.AdicionarParametros("@cnh_numero", func.cnh_numero);
                conexao.AdicionarParametros("@cnh_validade", func.cnh_validade);
                conexao.AdicionarParametros("@cnh_orgao_expedidor", func.cnh_orgao_expedidor);
                conexao.AdicionarParametros("@cnh_categoria", func.cnh_categoria);
                conexao.AdicionarParametros("@cnh_data_emissao", func.cnh_data_emissao);
                conexao.AdicionarParametros("@data_admissao", func.data_admissao);
                conexao.AdicionarParametros("@data_exame_medico", func.data_exame_medico);
                conexao.AdicionarParametros("@data_inicio_experiencia", func.data_inicio_experiencia);
                conexao.AdicionarParametros("@data_fim_experiencia", func.data_fim_experiencia);
                conexao.AdicionarParametros("@data_prorrogacao", func.data_prorrogacao);
                conexao.AdicionarParametros("@observacao", func.observacao);
                conexao.AdicionarParametros("@demitido", func.demitido);
                conexao.AdicionarParametros("@data_demissao", func.data_demissao);
                conexao.AdicionarParametros("@motivo_demissao", func.motivo_demissao);
                conexao.AdicionarParametros("@rescisao_caged", func.rescisao_caged);
                conexao.AdicionarParametros("@cargo", func.cargo);
                conexao.AdicionarParametros("@tipo_contrato", func.tipo_contrato);
                conexao.AdicionarParametros("@admissao_caged", func.admissao_caged);
                conexao.AdicionarParametros("@setor", func.setor);
                conexao.AdicionarParametros("@departamento", func.departamento);
                conexao.AdicionarParametros("@banco", func.banco);
                conexao.AdicionarParametros("@agencia", func.agencia);
                conexao.AdicionarParametros("@numero_conta", func.numero_conta);
                conexao.AdicionarParametros("@tipo_conta", func.tipo_conta);
                conexao.AdicionarParametros("@grau_instrucao", func.grau_instrucao);
                conexao.AdicionarParametros("@instituicao_ensino", func.instituicao_ensino);
                conexao.AdicionarParametros("@curso", func.curso);
                conexao.AdicionarParametros("@curso_inicio", func.curso_inicio);
                conexao.AdicionarParametros("@curso_fim", func.curso_fim);
                conexao.AdicionarParametros("@outros_cursos", func.outros_cursos);
                //if (func.ListEmpresaGerencial.Count > -1)
                //{
                //    for (int i = 0; i < func.ListEmpresaGerencial.Count; i++)
                //    {
                //        conexao.AdicionarParametros("@listaEmpGerencial", func.ListEmpresaGerencial[i]);
                //        sql = string.Empty;
                //        sql = "UPDATE Funcionario_Empresa_Gerencial SET Funcionario = @codigo, Empresa = @listaEmpGerencial WHERE Funcionario = @codigo";
                //        conexao.Manipular(CommandType.Text, sql);
                //    }
                //} 
                sql.Clear();
                sql.AppendLine("UPDATE Funcionario SET Data_Cadastro = @dataCadastro, Data_Nascimento = @dataNascimento,Data_Ultima_At = @dataUltAtual, ");
                sql.AppendLine("Nome = @nome,CPF = @cpf,RG = @rg, Grupo = @grupoFuncionario, ");
                sql.AppendLine("Genero = @genero, Empresa = @empresaContratual, Situacao = @situacao,Foto = @foto,Telefone = @telefone, ");
                sql.AppendLine("Celular = @celular,Email = @email,Endereco = @endereco, ");
                sql.AppendLine("Numero = @numero,Bairro = @bairro,Cep = @cep,Complemento = @complemento,Cidade = @cidade,Uf = @estado, ");
                sql.AppendLine("Pais = @pais,Nome_Pai = @nome_pai,Nome_Mae = @nome_mae,Raca_Cor = @raca_cor,Estado_Civil = @estado_civil, ");
                sql.AppendLine("Deficiente = @deficiente,Tipo_Deficiencia = @tipo_deficiencia,CTPS = @ctps,CTPS_Serie = @ctps_serie, ");
                sql.AppendLine("CTPS_UF = @ctps_uf,CTPS_Emissao = @ctps_emissao,CTPS_Orgao_Exp = @ctps_orgao_expedidor,PIS = @pis, ");
                sql.AppendLine("PIS_Emissao = @pis_emissao,Titulo_Eleitor = @titulo_numero,Titulo_Zona = @titulo_zona, ");
                sql.AppendLine("Titulo_Secao = @titulo_secao,Reservista_Nr = @reservista_nr,Reservista_Ra = @reservista_ra, ");
                sql.AppendLine("CNH = @cnh_numero,CNH_Validade = @cnh_validade,CNH_Orgao = @cnh_orgao_expedidor,CNH_Categoria = @cnh_categoria, ");
                sql.AppendLine("CNH_Emissao = @cnh_data_emissao,Data_Admissao = @data_admissao,Data_Exame_Medico = @data_exame_medico, ");
                sql.AppendLine("Experiencia_Inicio = @data_inicio_experiencia,Experiencia_Fim = @data_fim_experiencia, ");
                sql.AppendLine("Experiencia_Prorrogacao = @data_prorrogacao, "); 
                sql.AppendLine("Observacao = @observacao,Demitido = @demitido, ");
                sql.AppendLine("Demissao_Data = @data_demissao,Demissao_Motivo = @motivo_demissao,Rescisao_Caged = @rescisao_caged, ");
                sql.AppendLine("Cargo = @cargo,Tipo_Contrato = @tipo_contrato,Admissao_Caged = @admissao_caged,Setor = @setor, ");
                sql.AppendLine("Departamento = @departamento,Banco = @banco,Agencia = @agencia,Numero_Conta = @numero_conta, ");
                sql.AppendLine("Tipo_Conta_Bancaria = @tipo_conta,Grau_Instrucao = @grau_instrucao,Instituicao_Ensino = @instituicao_ensino, ");
                sql.AppendLine("curso = @curso,Curso_Inicio = @curso_inicio,Curso_Fim = @curso_fim,Curso_Outros = @outros_cursos ");
                sql.AppendLine("WHERE Codigo = @codigo");
                conexao.Manipular(CommandType.Text, Convert.ToString(sql));
                return retorno = "1";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public void RacaCor(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Raca_Cor FROM Funcionario_Raca_Cor WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Raca_Cor"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Cidade(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Cidade FROM Cidade WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Cidade"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Estado(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Uf FROM Cidade_Uf WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Uf"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Pais(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Pais FROM Cidade_Pais WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Pais"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TipoDeficiencia(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Tipo_Deficiencia FROM Funcionario_Tipo_Deficiencia WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Tipo_Deficiencia"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void RescisaoCaged(TextBox txtCodigo, TextBox txtCampo1)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Rescisao FROM Rh_Rescisao_Caged WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo1.Text = dr["Rescisao"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Cargo(TextBox txtCodigo, TextBox txtCampo, TextBox txtCampo1 = null)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Cargo, Salario FROM Rh_Cargo_Salario WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Cargo"].ToString();
                    txtCampo1.Text = dr["Salario"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void TipoContrato(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Tipo_Contrato FROM Rh_Tipo_Contrato WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Tipo_Contrato"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void AdmissaoCaged(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Admissao_Caged FROM Rh_Admissao_Caged WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Admissao_Caged"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Setor(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Setor FROM Funcionario_Setor WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Setor"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Departamento(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Departamento FROM Funcionario_Departamento WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Departamento"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void GrupoFuncionario(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Grupo FROM Funcionario_Grupo WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Grupo"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void Banco(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Banco FROM Financeiro_Banco WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Banco"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        public void TipoConta(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Tipo_Conta FROM Financeiro_Tipo_Conta_Bancaria WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Tipo_Conta"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void GrauInstrucao(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Escolaridade FROM Funcionario_Grau_Instrucao WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, Convert.ToString(sql));
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Escolaridade"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Funcionario(TextBox txtCodigo, TextBox txtCampo)
        {
            try
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@codigo", txtCodigo.Text);
                sql.Clear();
                sql.AppendLine("SELECT Codigo, Nome FROM Funcionario WHERE Codigo = @codigo");
                DataTable dt = conexao.Consultar(CommandType.Text, sql.ToString());
                foreach (DataRow dr in dt.Rows)
                {
                    txtCodigo.Text = dr["Codigo"].ToString();
                    txtCampo.Text = dr["Nome"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possívelo carregar dados. Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
//func.pis_emissao.ToString("yyyy-MM-dd HH:mm:ss")