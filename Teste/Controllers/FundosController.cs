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
    public class FundosController : ControllerBase
    {
        private readonly IFundosRepository repository;

        public FundosController(IFundosRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Fundos>> Get()
        {          
            return repository.GetFundos();
        }
    }
}