using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TesteTecnico.Controllers
{
    [Route("showmethecode")]
    [ApiController]
    public class ShowMeTheCodeController : ControllerBase
    {
        /// <summary>
        /// Retornar o link do repositorio no git
        /// </summary>
        /// <returns>Json</returns>
        [HttpGet]
        public IActionResult Get()
        {
            return new JsonResult("https://github.com/avelar42/TestesAPIS");
        }
    }
}
