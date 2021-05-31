using Microsoft.AspNetCore.Mvc;
using Service;

namespace TesteTecnico.Controllers
{

    [ApiController]
    [Route("taxaJuros")]
    public class TaxaJurosController : ControllerBase
    {
        /// <summary>
        /// Retornar o valor da taxa de Juros em decimal
        /// </summary>
        /// <returns>Json</returns>
        [HttpGet]
        public IActionResult Get()
        {
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();
            return new JsonResult(data.Result);
        }
    }
}
