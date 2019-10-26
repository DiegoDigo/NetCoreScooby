using System.Collections.Generic;

namespace Scooby.Domain.Entity
{
    public class Categoria
    {
        public int Id { get; private set; }
        public string Nome { get; private set; }
        public IEnumerable<Produto> produto { get; set; }

        public Categoria(string nome)
        {
            Nome = nome;
        }

        public Categoria() { }
    }
}
