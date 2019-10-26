using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Scooby.Domain.Requests;
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
            return Ok(await _categoriaRepository.All());
        }

        [HttpPost]
        [ApiVersion("1.0")]
        public async Task<IActionResult> Create([FromBody] CategoriaRequest request)
        {
            await _categoriaRepository.Save(request);
            return Ok();
        }
    }
}
