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
    public class ResgateController : ControllerBase
    {
        private readonly IResgateRepository repository;

        public ResgateController(IResgateRepository repository)
        {
            this.repository = repository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<List<Resgate>> Get()
        {          
            return repository.GetResgate();
        }
    }
}