using Scooby.Domain.ViewModels.ProductViewModels;

namespace Scooby.Domain.Entity
{
    public class Produto
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public long CategoriaId { get; private set; }
        public Categoria Categoria { get; private set; }

        public Produto(EditorProdutoViewModel produto)
        {
            this.Id = produto.Id;
            this.Nome = produto.Nome;
            this.CategoriaId = produto.CategoryId;
        }

        public Produto() { }
    }
}
