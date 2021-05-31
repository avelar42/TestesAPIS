using Service;
using System;
using TesteTecnico.Repository;
using Xunit;

namespace TesteCalculadoras
{
    public class TesteTaxas
    {
        private readonly CalculoTaxaJuros _taxaJuros;
        private readonly CalculadoraJurosCompostos _calculadoraJurosCompostos;
        public TesteTaxas()
        {
            _taxaJuros = new CalculoTaxaJuros();
            _calculadoraJurosCompostos = new CalculadoraJurosCompostos();
        }

        [Fact]
        public void ValidarCalculoDeTaxa()
        {
            var result = 0.01m;
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();
            Assert.Equal(data.Result, result);
        }

        [Fact]
        public void ValidarCalculadoraJurosCompostos()
        {
            var repo = new TaxaJurosRepository();
            var data = repo.GetValor();
            var result = 105.10m;
            decimal valorInicial = 100;
            int tempo = 5; 
            var resultado = _calculadoraJurosCompostos.CalcularJurosCompostos(valorInicial, tempo, data.Result);
            Assert.Equal(resultado, result);
        }
    }
}
