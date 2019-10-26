using System.Collections.Generic;
using Scooby.Domain.ViewModels.CategoryViewModels;

namespace Scooby.Domain.Entity
{
    public class Categoria
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Produto> produto { get; set; }

        public Categoria(EditorCategoriaViewModel categoria)
        {
            this.Id = categoria.Id;
            this.Nome = categoria.Description;
        }

        public Categoria() { }
    }
}
