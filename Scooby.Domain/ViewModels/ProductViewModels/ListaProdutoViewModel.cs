using System;

namespace Scooby.Domain.ViewModels.ProductViewModels
{
    public class ListaProdutoViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public long CategoryId { get; set; }
        public String Categoria { get; set; }
    }
}
