using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scooby.Domain.Entity;
using Scooby.Domain.Requests;
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

        public async Task<List<Categoria>> All()
        {
           return await _db.Categorias.ToListAsync();
        }

        public async Task Save(CategoriaRequest categoria)
        {
            _db.Categorias.Add(new Categoria(categoria.descricao));
            await _db.SaveChangesAsync();
        }
    }
}
