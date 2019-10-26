using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scooby.Domain.Entity;
using Scooby.Domain.ViewModels.CategoryViewModels;

namespace Scooby.Infra.Repository
{
    public interface ICategoriaRepository
    {
        Task<List<ListarCategoriaViewModel>> All();

        Task<Categoria> Save(EditorCategoriaViewModel categoria);

        Task<Categoria> GetById(long id);
    }
}
