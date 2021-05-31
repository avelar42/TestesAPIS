using Microsoft.AspNetCore.Mvc;
using Service;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("calculaJuros")]
    public class CalculaJurosController : ControllerBase
    {
        private CalculadoraJurosCompostos _calculadoraJurosCompostos = new CalculadoraJurosCompostos();

        /// <summary>
        /// Responsavel pelo calculo de juros compostos
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <returns>Json</returns>
        [HttpGet]
        public IActionResult Get(decimal valorInicial, int tempo)
        {
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();

            return new JsonResult(_calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo, data.Result));
        }
    }
}
