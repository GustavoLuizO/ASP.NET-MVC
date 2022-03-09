using Microsoft.EntityFrameworkCore;

namespace APP_with_ENitty_Framework.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        public DbSet<Product> Products { get; set; }
        public DbSet<manufacturer> manafactures { get; set; }
    }
}
