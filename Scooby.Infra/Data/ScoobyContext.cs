using Microsoft.EntityFrameworkCore;
using Scooby.Domain.Entity;
using Scooby.Infra.Map;

namespace Scooby.Infra.Data
{
    public class ScoobyContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Categoria> Categorias { get; set; }

        public ScoobyContext(DbContextOptions<ScoobyContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new CategoriaMap());
        }
    }
}
