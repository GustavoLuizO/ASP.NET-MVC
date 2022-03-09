using Microsoft.EntityFrameworkCore;

namespace APP_with_ENitty_Framework.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options)
            : base(options) //busca as configurações de conexão com o BD
        {

        }

        public DbSet<Product> Products { get; set; } //Conjunto de dados do tipo Porudto se constituira em uma tabela do Bd*
        public DbSet<manufacturer> manafactures { get; set; }
    }
}
