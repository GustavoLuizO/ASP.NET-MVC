using Microsoft.EntityFrameworkCore;

namespace APP_with_ENitty_Framework.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) //busca as configurações de conexão com o BD
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<manufacturer> manafactures { get; set; }
    }
}
