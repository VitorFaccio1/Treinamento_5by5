using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Bff.Dto;
using Newtonsoft.Json;

namespace Bff.Service
{
    public class ProdutoService
    {
        HttpClient httpClient = new HttpClient();

        IEnumerable<ProdutoDto> listaProducts;

        public async Task<IEnumerable<ProdutoDto>> Get(){
            httpClient.BaseAddress = new Uri("http://localhost:5003/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync("api/Produto");
            if(responseMessage.IsSuccessStatusCode){
                var clientesString = await responseMessage.Content.ReadAsStringAsync();
                listaProducts = JsonConvert.DeserializeObject<IEnumerable<ProdutoDto>>(clientesString);
            }else{
                responseMessage.EnsureSuccessStatusCode();
            }
            return listaProducts;
    }
    }
}