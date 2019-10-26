using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Scooby.Domain.Entity;
using Scooby.Domain.Requests;

namespace Scooby.Infra.Repository
{
    public interface ICategoriaRepository
    {
        Task<List<Categoria>> All();

        Task Save(CategoriaRequest categoria);
    }
}
