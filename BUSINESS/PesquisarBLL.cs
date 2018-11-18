using System;
using System.Windows.Forms;
using Loja.DATA;
using System.Data;
using System.Text;

namespace Loja.BUSINESS
{
    public class PesquisarBLL
    {
        Conexao conexao = new Conexao();
        StringBuilder sql = new StringBuilder();        

        public void PesquisarDados(DataGridView grade, TextBox total, string sql)
        {
            try
            {
                DataTable dt = conexao.Consultar(CommandType.Text, sql);
                grade.DataSource = dt;
                grade.DataMember = dt.TableName;
                grade.Update();
                grade.Refresh();
                total.Text = Convert.ToString(grade.Rows.Count); //Verifico a quantidade de registros retornado
            }
            catch (Exception ex)
            {
                grade.Columns.Clear();
                total.Text = "0";
                MessageBox.Show("Falha ao carregar grade. Detalhes: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void Usuario(CheckBox considerarInativo, string texto, TextBox total, DataGridView grade)
        {
            if(considerarInativo.Checked == true)
            {
                if (texto == "*")
                {
                    sql.Clear();
                    sql.AppendLine("SELECT Codigo AS 'Código', Usuario AS 'Usuário', Grupo, Data_Cadastro  AS 'Data Cadastro', ");
                    sql.AppendLine("Data_Ult_Login AS 'Último Acesso', Ativo FROM Usuario");
                    PesquisarDados(grade, total, Convert.ToString(sql));
                }
                else
                {
                    conexao.LimparParametros();
                    conexao.AdicionarParametros("@texto", texto);
                    sql.Clear();
                    sql.AppendLine("SELECT Codigo AS 'Código', Usuario AS 'Usuário', Grupo, Data_Cadastro  AS 'Data Cadastro', ");
                    sql.AppendLine("Data_Ult_Login AS 'Último Acesso', Ativo FROM Usuario");
                    sql.AppendLine("WHERE Usuario LIKE @texto+'%'");
                    PesquisarDados(grade, total, Convert.ToString(sql));
                }
            }
            else
            {
                if (texto == "*")
                {
                    sql.Clear();
                    sql.AppendLine("SELECT Codigo AS 'Código', Usuario AS 'Usuário', Grupo, Data_Cadastro  AS 'Data Cadastro', ");
                    sql.AppendLine("Data_Ult_Login AS 'Último Acesso', Ativo FROM Usuario");
                    sql.AppendLine("WHERE Ativo = 1");
                    PesquisarDados(grade, total, Convert.ToString(sql));
                }
                else
                {
                    conexao.LimparParametros();
                    conexao.AdicionarParametros("@texto", texto);
                    sql.Clear();
                    sql.AppendLine("SELECT Codigo AS 'Código', Usuario AS 'Usuário', Grupo, Data_Cadastro  AS 'Data Cadastro', ");
                    sql.AppendLine("Data_Ult_Login AS 'Último Acesso', Ativo FROM Usuario");
                    sql.AppendLine("WHERE Usuario LIKE @texto+'%' AND Ativo = 1");
                    PesquisarDados(grade, total, Convert.ToString(sql));
                }
            }
            
        }
        public void Funcionario(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT F.Codigo AS 'Código', F.Nome, E.Fantasia AS 'Empresa Contratual' FROM Funcionario F ");
                sql.AppendLine(" LEFT JOIN Empresa E ON F.Empresa = E.Codigo ");
                sql.AppendLine(" ORDER BY Nome");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT F.Codigo AS 'Código', F.Nome, E.Fantasia AS 'Empresa Contratual' FROM Funcionario F ");
                sql.AppendLine("LEFT JOIN Empresa E ON F.Empresa = E.Codigo ");
                sql.AppendLine("WHERE F.Nome LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void RacaCor(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Raca_Cor AS 'Raça/Cor' FROM Funcionario_Raca_Cor ORDER BY Raca_Cor");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Raca_Cor AS 'Raça/Cor' FROM Funcionario_Raca_Cor WHERE Raca_Cor LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Cidade(string texto, TextBox total = null, DataGridView grade = null)
        {   
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Cidade FROM Cidade ORDER BY Cidade");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Cidade FROM Cidade WHERE Cidade LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Estado(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Uf AS 'Estado' FROM Cidade_Uf ORDER BY Uf");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Uf AS 'Estado' FROM Cidade_Uf WHERE Uf LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Pais(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Pais AS 'País' FROM Cidade_Pais ORDER BY Pais");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Pais AS 'País' FROM Cidade_Pais WHERE Pais LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void TipoDeficiencia(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Deficiencia AS 'Tipo de Deficiência' FROM Funcionario_Tipo_Deficiencia ORDER BY Tipo_Deficiencia");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Deficiencia AS 'Tipo de Deficiência' FROM Funcionario_Tipo_Deficiencia WHERE Tipo_Deficiencia LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void RescisaoCaged(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Rescisao AS 'Rescisão' FROM Rh_Rescisao_Caged ORDER BY Rescisao");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Rescisao AS 'Rescisão' FROM Rh_Rescisao_Caged WHERE Rescisao LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Cargo(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Cargo FROM Rh_Cargo_Salario ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Cargo FROM Rh_Cargo_Salario WHERE Cargo LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void TipoContrato(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Contrato AS 'Tipo Contrato' FROM Rh_Tipo_Contrato ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Contrato AS 'Tipo Contrato' FROM Rh_Tipo_Contrato WHERE Tipo_Contrato LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void AdmissaoCaged(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Admissao_Caged AS 'Admissão Caged' FROM Rh_Admissao_Caged ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Admissao_Caged AS 'Admissão Caged' FROM Rh_Admissao_Caged WHERE Admissao_Caged LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Setor(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Setor FROM Funcionario_Setor ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Setor FROM Funcionario_Setor WHERE Setor LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void Departamento(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Departamento FROM Funcionario_Departamento ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Departamento FROM Funcionario_Departamento WHERE Departamento LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }
        public void GrupoUsuario(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Grupo FROM Usuario_Grupo ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Grupo FROM Usuario_Grupo WHERE Grupo LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }
        public void Banco(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Banco FROM Financeiro_Banco ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Banco FROM Financeiro_Banco WHERE Banco LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }
        public void TipoConta(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Conta AS 'Tipo Conta' FROM Financeiro_Tipo_Conta_Bancaria ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Tipo_Conta AS 'Tipo Conta' FROM Financeiro_Tipo_Conta_Bancaria WHERE Tipo_Conta LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }

        public void GrauInstrucao(string texto, TextBox total, DataGridView grade)
        {
            if (texto == "*")
            {
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Escolaridade FROM Funcionario_Grau_Instrucao ORDER BY Codigo");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
            else
            {
                conexao.LimparParametros();
                conexao.AdicionarParametros("@texto", texto);
                sql.Clear();
                sql.AppendLine("SELECT Codigo AS 'Código', Escolaridade FROM Funcionario_Grau_Instrucao WHERE Escolaridade LIKE @texto+'%'");
                PesquisarDados(grade, total, Convert.ToString(sql));
            }
        }
    }
}