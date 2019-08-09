using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Teste.Entities
{
    public class Fundos
    {
        [Key]
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public decimal Investimento { get; set; }
    }
}
