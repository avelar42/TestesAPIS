using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Service;
using TesteTecnico.Repository;

namespace TesteTecnico.Controllers
{
    
    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        private CalculoTaxaJuros taxaJuros = new CalculoTaxaJuros();

        [HttpGet]
        public IActionResult Get()
        {
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();
            return new JsonResult(data.Result);
        }
    }
}
