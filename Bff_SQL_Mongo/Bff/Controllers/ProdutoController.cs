using System.Collections.Generic;
using System.Threading.Tasks;
using Bff.Dto;
using Bff.Service;
using Microsoft.AspNetCore.Mvc;

namespace Bff.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProdutoController: ControllerBase
    {
        public ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }

        [HttpGet]
        public async Task<IEnumerable<ProdutoDto>> GetProdutoAsync() => await _produtoService.Get();
    }
        
}
