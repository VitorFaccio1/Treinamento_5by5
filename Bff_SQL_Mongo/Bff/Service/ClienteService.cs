using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Bff.Dto;
using Newtonsoft.Json;

namespace Bff.Service
{
    public class ClienteService
    {
        HttpClient httpClient = new HttpClient();

        IEnumerable<ClienteDto> listaClientes;

        public async Task<IEnumerable<ClienteDto>> GetClientesAsync(){
            httpClient.BaseAddress = new Uri("http://localhost:5002/");
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            HttpResponseMessage responseMessage = await httpClient.GetAsync("api/Cliente");
            if(responseMessage.IsSuccessStatusCode){
                var clientesString = await responseMessage.Content.ReadAsStringAsync();
                listaClientes = JsonConvert.DeserializeObject<IEnumerable<ClienteDto>>(clientesString);
            }else{
                responseMessage.EnsureSuccessStatusCode();
            }
            return listaClientes;
        }
    }
}