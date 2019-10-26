using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scooby.Domain.ViewModels;
using Scooby.Domain.ViewModels.ProductViewModels;
using Scooby.Infra.Repository;

namespace Scooby.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepository _repository;

        public ProdutoController(IProdutoRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAll()
        {
            var produtos = await _repository.All();
            if (produtos != null)
            {
                return Ok(new ResultViewModel(true, "Categorias Lisadas com sucesso.", produtos));
            }
            return NoContent();
        }

        [HttpPost]
        [ApiVersion("1.0")]
        public async Task<IActionResult> Create([FromBody] EditorProdutoViewModel request)
        {
            request.Validate();
            if(request.Invalid){
                return BadRequest(new ResultViewModel(false, "Erro ao inserir A Categoria", request.Notifications));
            }
            var produto = await _repository.Save(request);            
            return Created("", new ResultViewModel(true, "Categoria criado com sucesso.", produto));
        }
    }
}
