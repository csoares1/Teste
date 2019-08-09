using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using Teste.Entities;

namespace Teste.Repository
{
    public class FundosRepository:IFundosRepository
    {
        IConfiguration _configuration;
        public FundosRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").
                GetSection("InvestimentoConn").Value;
            return connection;
        }

        public List<Fundos> GetFundos()
        {
            var connectionString = this.GetConnection();
            List<Fundos> fundos = new List<Fundos>();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT Id, Nome, Cnpj, InvestimentoInicial FROM Fundos";
                    fundos = con.Query<Fundos>(query).ToList();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    con.Close();
                }
                return fundos;
            }
        }
    }
}
