using System;
using System.Collections.Generic;

namespace Loja.ENTITY
{
    public class C_UsuarioENT
    {
        public Int16 codigo;
        public string usuario;
        public string senha;
        public string codigo_grupo;
        public string grupo;
        public DateTime data_cadastro;
        public DateTime data_atualizacao;
        public string maquina;
        public string versao;
        public DateTime data_ult_login;
        public bool ativo;
        public Int16 codigo_empresa;
        public string empresa_fantasia;
        public List<Int16> lista_empresa = new List<Int16>();
    }
}
