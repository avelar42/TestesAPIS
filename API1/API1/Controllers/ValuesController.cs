using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API1.Controllers
{
    [Route("taxaJuros")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        /// <summary>
        /// Responsavel por retornar o calculo de juros de 1%
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult Get()
        {
            decimal valor = 1 / 100m;
            return new JsonResult(valor);
        }
    }
}
