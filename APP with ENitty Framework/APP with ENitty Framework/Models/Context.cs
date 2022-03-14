using Microsoft.EntityFrameworkCore;

namespace APP_with_ENitty_Framework.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) { }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Fabricante> Fabricantes { get; set; }
    }
}
