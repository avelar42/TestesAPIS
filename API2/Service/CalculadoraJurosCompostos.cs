using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class CalculadoraJurosCompostos
    {

        /// <summary>
        /// Retorna o valor calculado da taxa de Juros composta
        /// </summary>
        /// <param name="valorInicial"></param>
        /// <param name="tempo"></param>
        /// <param name="taxaJuros"></param>
        /// <returns>decimal</returns>
        public decimal CalcularJurosCompostos(decimal valorInicial, int tempo, decimal taxaJuros)
        {
           
            var resultado = (Convert.ToDouble(valorInicial) * Math.Pow(1 + Convert.ToDouble(taxaJuros), tempo)) * 100;
            return ((Convert.ToDecimal(Math.Truncate(resultado)) / 100) * 1.0m);
        }
    }
}
