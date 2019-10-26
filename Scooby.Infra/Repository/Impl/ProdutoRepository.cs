using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Scooby.Domain.Entity;
using Scooby.Domain.ViewModels.ProductViewModels;
using Scooby.Infra.Data;

namespace Scooby.Infra.Repository.Impl
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ScoobyContext _db;

        public ProdutoRepository(ScoobyContext context)
        {
            _db = context;
        }

        public async Task<List<ListaProdutoViewModel>> All()
        {
            return await _db.Produtos
                .Include(x => x.Categoria)
                .Select(x => new ListaProdutoViewModel()
                {
                    Id = x.Id,
                    Nome = x.Nome,
                    CategoryId = x.Categoria.Id,
                    Categoria = x.Categoria.Nome
                })
            .ToListAsync();
        }

        public async Task<Produto> Save(EditorProdutoViewModel produto)
        {
            var newProduto = new Produto(produto);
            _db.Produtos.Add(newProduto);
            await _db.SaveChangesAsync();
            if (newProduto.Id == 0)
            {
                return null;
            }
            return newProduto;
        }
    }
}
