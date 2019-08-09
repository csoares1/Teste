using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Teste.Entities;
using Teste.Repository;

namespace Teste.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AplicacaoController : ControllerBase
    {
        private readonly IAplicacaoRepository repository;

        public AplicacaoController(IAplicacaoRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Investimento>> Get()
        {          
            return repository.GetAplicacao();
        }
    }
}