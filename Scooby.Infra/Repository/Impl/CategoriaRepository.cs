using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scooby.Domain.Entity;
using Scooby.Domain.ViewModels.CategoryViewModels;
using Scooby.Infra.Data;

namespace Scooby.Infra.Repository.Impl
{
    public class CategoriaRepository : ICategoriaRepository
    {

        private readonly ScoobyContext _db;

        public CategoriaRepository(ScoobyContext context)
        {
            _db = context;
        }

        public async Task<List<ListarCategoriaViewModel>> All()
        {
            return await _db.Categorias.Select(x => new ListarCategoriaViewModel()
            {
                Id = x.Id,
                Description = x.Nome
            }).ToListAsync();
        }

        public async Task<Categoria> GetById(long id)
        {
            return await _db.Categorias.Where(x => x.Id == id).FirstAsync();
        }

        public async Task<Categoria> Save(EditorCategoriaViewModel categoria)
        {
            var newCategoria = new Categoria(categoria);
            _db.Categorias.Add(newCategoria);
            await _db.SaveChangesAsync();
            if (newCategoria.Id == 0)
            {
                return null;
            }
            return newCategoria;
        }
    }
}
