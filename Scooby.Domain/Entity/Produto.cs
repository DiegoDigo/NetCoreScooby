namespace Scooby.Domain.Entity
{
    public class Produto
    {
        public long Id { get; private set; }
        public string Nome { get; private set; }
        public Categoria Categoria { get; private set; }

        public Produto(string nome, Categoria categoria)
        {
            Nome = nome;
            Categoria = categoria;
        }

        public Produto() { }
    }
}
