using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace TesteTecnico.Repository
{
    public class TaxaJurosRepository
    {
        HttpClient cliente = new HttpClient();


        public TaxaJurosRepository()
        {
            cliente.BaseAddress = new Uri("http://localhost:64258/");
            cliente.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

        }

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
