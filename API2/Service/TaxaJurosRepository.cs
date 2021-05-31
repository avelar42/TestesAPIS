using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class TaxaJurosRepository
    {
        HttpClient cliente = new HttpClient();

        //ALTERAR URL CASO API ESTEJA RODANDO EM OUTRA URL
        static string url = "http://localhost:64258/";

        public TaxaJurosRepository()
        {
            cliente.BaseAddress = new Uri(url);
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }
        /// <summary>
        /// Responsavel por conectar a API e consultar a taxa de juros
        /// </summary>
        /// <returns>decimal</returns>
        public async Task<decimal> GetValor()
        {
            HttpResponseMessage response = await cliente.GetAsync("TaxaJuros");
            if (response.IsSuccessStatusCode)
            {
                var dados = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<decimal>(dados);
            }
            return 0;

        }
    }
}
