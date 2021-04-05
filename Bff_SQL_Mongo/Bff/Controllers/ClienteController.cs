using System.Collections.Generic;
using System.Threading.Tasks;
using Bff.Dto;
using Bff.Service;
using Microsoft.AspNetCore.Mvc;

namespace Bff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        public ClienteService _clienteservice;

        public ClienteController()
        {
            _clienteservice = new ClienteService();
        }

        [HttpGet]
        public async Task<IEnumerable<ClienteDto>> GetClienteAsync() => await _clienteservice.GetClientesAsync();
    }
}