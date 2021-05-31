using Microsoft.AspNetCore.Mvc;
using Service;
using System;
using System.Globalization;
using TesteTecnico.Repository;

namespace TesteTecnico.Controllers
{
    [ApiController]
    [Route("calculaJuros")]
    public class CalculaJurosController : ControllerBase
    {
        private CalculadoraJurosCompostos _calculadoraJurosCompostos = new CalculadoraJurosCompostos();

        [HttpGet]
        public IActionResult Get(decimal valorInicial, int tempo)
        {
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();

            return new JsonResult(_calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo, data.Result));
        }
    }
}
