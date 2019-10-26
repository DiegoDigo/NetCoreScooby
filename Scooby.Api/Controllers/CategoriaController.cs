using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scooby.Domain.ViewModels;
using Scooby.Domain.ViewModels.CategoryViewModels;
using Scooby.Infra.Repository;

namespace Scooby.Api.Controllers
{
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiController]
    public class CategoriaController : Controller
    {
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaController(ICategoriaRepository categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }


        [HttpGet]
        [ApiVersion("1.0")]
        public async Task<IActionResult> GetAll()
        {
            var categorias = await _categoriaRepository.All();
            if (categorias != null)
            {
                return Ok(new ResultViewModel(true, "Categorias Lisadas com sucesso.", categorias));
            }
            return NoContent();
        }

        [HttpPost]
        [ApiVersion("1.0")]
        public async Task<IActionResult> Create([FromBody] EditorCategoriaViewModel request)
        {
            var categoria = await _categoriaRepository.Save(request);
            if (categoria == null)
            {
                return BadRequest(new ResultViewModel(false, "Erro ao inserir A Categoria", null));
            }
            return Created("", new ResultViewModel(true, "Categoria criado com sucesso.", categoria));
        }
    }
}
