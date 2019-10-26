using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scooby.Domain.Entity;
using Scooby.Domain.ViewModels.ProductViewModels;

namespace Scooby.Infra.Repository
{
    public interface IProdutoRepository
    {
        Task<List<ListaProdutoViewModel>> All();

        Task<Produto> Save(EditorProdutoViewModel produto);
    }
}
