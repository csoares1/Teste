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
    public class ResgateRepository: IResgateRepository
    {
        IConfiguration _configuration;
        public ResgateRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetConnection()
        {
            var connection = _configuration.GetSection("ConnectionStrings").
                GetSection("InvestimentoConn").Value;
            return connection;
        }

        public List<Resgate> GetResgate()
        {
            var connectionString = this.GetConnection();
            List<Resgate> resgate = new List<Resgate>();
            using (var con = new SqlConnection(connectionString))
            {
                try
                {
                    con.Open();
                    var query = "SELECT Id, Tipo, Id_Fundo, cpf_cliente, valor_movimentacao, Data_movimentacao FROM Resgate";
                    resgate = con.Query<Resgate>(query).ToList();
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
