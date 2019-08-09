using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Teste.Enums;

namespace Teste.Entities
{
    public class Resgate
    {
        [Key]
        public Guid Id { get; set; }
        public EtipoMovimentacao Tipo { get; set; }
        public string Cpf_cliente { get; set; }
        public decimal Valor_movimentacao { get; set; }
        public DateTime Data_movimentacao { get; set; }
        public Fundos Fundos { get;  set; }
    }
}
