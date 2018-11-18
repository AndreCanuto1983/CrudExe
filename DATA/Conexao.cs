using System;
using System.Data;
using System.Data.SqlClient;
using Loja.Properties;
using System.Windows.Forms;

namespace Loja.DATA
{
    public class Conexao
    {
        private SqlParameterCollection sqlParameterCollection = new SqlCommand().Parameters;

        private SqlConnection CriarConexao()
        {
            return new SqlConnection(Settings.Default.stringConexao);
        }

        public void LimparParametros()
        {
            sqlParameterCollection.Clear();
        }

        public void AdicionarParametros(string nomeParametro, object valorParametro)
        {
            sqlParameterCollection.Add(new SqlParameter(nomeParametro, valorParametro));
        }

        public object Manipular(CommandType commandType, string nomeTextoSql)  //inserir, alterar e excluir
        {
            SqlConnection sqlConnection = CriarConexao();  //Criar a conexão
            try
            {
                sqlConnection.Open(); //Abir conexão            
                SqlCommand sqlCommand = sqlConnection.CreateCommand(); //comando que vai levar os dados para o banco                
                sqlCommand.CommandType = commandType;//coloca dados dos parametros dentro do comando para levar para o banco
                sqlCommand.CommandText = nomeTextoSql;
                sqlCommand.CommandTimeout = 600; //o sistema fecha a conexão e exibe um erro (tempo em segunndos = 10 minutos)                
                foreach (SqlParameter sqlParameter in sqlParameterCollection)//Adicionar os parâmetros no comando. Foreach = para cada.
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                return sqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Dispose();
            }
        }

        public DataTable Consultar(CommandType commandType, string nomeTextoSql) //Consultar registros no banco de dados
        {
            SqlConnection sqlConnection = CriarConexao(); //Criar a conexão  
            try
            {
                sqlConnection.Open(); //Abir conexão
                SqlCommand sqlCommand = sqlConnection.CreateCommand(); //criar o comando que vai levar os dados para o banco                
                sqlCommand.CommandType = commandType; //coloca dados dos parametros dentro do comando para levar para o banco
                sqlCommand.CommandText = nomeTextoSql;
                sqlCommand.CommandTimeout = 500; //o sistema fecha a conexão e exibe um erro(tempo em segundos)
                foreach (SqlParameter sqlParameter in sqlParameterCollection) //Adicionar os parâmetros no comando. Foreach = para cada.
                {
                    sqlCommand.Parameters.Add(new SqlParameter(sqlParameter.ParameterName, sqlParameter.Value));
                }
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                sqlConnection.Dispose();
            }
        }

        public void PreencherCombo(ComboBox combo, string tabela, string colunaId, string colunaDescricao, string valor = null)
        {
            try
            {
                string sql = "SELECT * FROM " + tabela + " ORDER BY Codigo ASC";
                DataTable dt = Consultar(CommandType.Text, sql);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.NewRow();
                    row[colunaDescricao] = "";
                    dt.Rows.InsertAt(row, 0); //insiro o valor nulo na combo
                    combo.DataSource = dt;
                    combo.ValueMember = colunaId;
                    combo.DisplayMember = colunaDescricao;
                    if (valor != null)
                    {
                        combo.SelectedValue = valor;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar combo! Detalhes: " + ex, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string PreencherGrade(DataGridView grade, string sql)
        {
            string qtdLinhas = "0";
            try
            {                                
                DataTable dt = Consultar(CommandType.Text, sql);
                grade.DataSource = dt;
                grade.DataMember = dt.TableName;
                grade.Update();
                grade.Refresh();
                qtdLinhas = Convert.ToString(grade.Rows.Count); //Verifico a quantidade de registros retornado
                return qtdLinhas;
                //limpar grade se necessário: grade.Columns.Clear();
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();
                return ex.Message;
            }
        }
    }
}  

//**********************************************************************************************************************************************
//daqui para baixo era a conexão antiga, estou utilizando apenas a de cima. (NÃO EXCLUIR!)

/*
        public SqlConnection cn = new SqlConnection();

        public string StringConexao()
        {
            return cn.ConnectionString = Settings.Default.stringConexao;
        }

        public void AbrirConexao()
        {
            try
            {
                cn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void FecharConexao()
        {
            try
            {
                cn.Close();
                cn.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        SqlDataReader dados;
        public SqlDataReader RealizarConsulta(string sql)
        {
            try
            {
                StringConexao();
                AbrirConexao();

                SqlCommand cmd = new SqlCommand(sql, cn);
                cmd.CommandText = sql;
                cmd.Connection = cn;

                SqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    dados = dr;
                }
                //conexao.Desconectar();   //não fechar a conexão pois gera erro ao tentar retornar registros
                //dr.Dispose();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dados;
        }

        public DataTable DevolverGradeDT(string sql)
        {
            DataTable gradeDT = null; //carrego o data table e devolvo ele para tela
            try
            {
                StringConexao();
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) //se grade tiver preenchida retorno a grade
                {
                    gradeDT = dt;
                    FecharConexao();
                    command.Dispose();
                }
                else
                {
                    gradeDT = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gradeDT;
        }

        public DataSet DevolverGradeDS(string sql)
        {
            DataSet gradeDS = null; //carrego o data set e devolvo ele para tela            
            try
            {
                StringConexao();
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                da.Fill(ds);
                gradeDS = ds;
                FecharConexao();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return gradeDS;
        }

        public void GerarGradeDT(string sql, DataGridView grade)
        {
            //carrego os dados na grade utilizando data table
            try
            {
                StringConexao();
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(command);                
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) //se grade tiver preenchida retorno a grade
                {
                    grade.DataSource = dt;
                    grade.DataMember = dt.TableName;
                    //ConfigurarGrid();
                    grade.Refresh();
                    grade.Update();
                    FecharConexao();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void GerarGradeDS(string sql, DataGridView grade) //método para atualizar a grid
        {
            //carrego os dados na grade utilizando data set
            try
            {
                StringConexao();
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                SqlDataAdapter da = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                da.Fill(ds);
                if (dt.Rows.Count > 0) //se grade tiver preenchida retorno a grade
                {
                    grade.DataSource = ds;
                    grade.DataMember = ds.Tables[0].TableName;
                    //ConfigurarGrid();
                    grade.Refresh();
                    grade.Update();
                    FecharConexao();
                }
                else
                {
                    MessageBox.Show("Nenhum registro foi encontrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void Manipular(string sql)
        {
            //utilizo para manipular dados, inserir, deletar e excluir do banco
            try
            {
                StringConexao();
                AbrirConexao();
                SqlCommand command = new SqlCommand(sql, cn);
                command.ExecuteNonQuery();
                FecharConexao();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CarregarCombo(ComboBox combo, string tabela, string colunaId, string colunaDescricao, string valor = null)
        {
            // carrego a combobox genérica
            StringConexao();
            try
            {
                AbrirConexao();
                string sql = "SELECT * FROM " + tabela + " ORDER BY Codigo ASC";
                SqlCommand command = new SqlCommand(sql, cn);
                SqlDataReader leitor = command.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(leitor);
                DataRow row = dt.NewRow();
                row[colunaDescricao] = "";
                dt.Rows.InsertAt(row, 0); //insiro o valor nulo na combo
                combo.DataSource = dt;
                combo.ValueMember = colunaId;
                combo.DisplayMember = colunaDescricao;
                if (valor != null)
                {
                    combo.SelectedValue = valor;
                }
                leitor.Close();
                leitor.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                FecharConexao();
            }
        }
    }
}

*/