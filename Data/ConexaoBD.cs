using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace SistemaEleicoesEstudantis.Data
{
    public class ConexaoBD
    {
        private string conexao =
            @"Server=localhost;
              Database=SistemaEleicoes;
              Trusted_Connection=True;";

        public SqlConnection ObterConexao()
        {
            return new SqlConnection(conexao);
        }
    }
}
