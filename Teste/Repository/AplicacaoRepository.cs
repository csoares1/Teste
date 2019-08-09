using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Teste.Entities;
using Teste.Enums;

namespace Teste.Repository
{
    public class AplicacaoRepository: IAplicacaoRepository
    {
        IConfiguration _configuration;
        public AplicacaoRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").
                GetSection("InvestimentoConn").Value;
            return connection;
        }

        public List<Investimento> GetAplicacao()
        {
            var connectionString = this.GetConnection();
            List<Investimento> resgate = new List<Investimento>();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = string.Format("SELECT Id, Tipo, Id_Fundo, cpf_cliente, valor_movimentacao, Data_movimentacao FROM Investimento Where Tipo = {0}", (int)EtipoMovimentacao.Aplicacao);
                    resgate = con.Query<Investimento>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return resgate;
            }
        }
    }
}
