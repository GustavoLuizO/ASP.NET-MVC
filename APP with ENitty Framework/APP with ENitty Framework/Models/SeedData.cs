using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.Extensions.DependencyInjection;

namespace APP_with_ENitty_Framework.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            //associa os dados ao contexto
            Context context = app.ApplicationServices.GetRequiredService<Context>();
            //inserir os dados nas entidades do contexto
            context.Database.Migrate();
            //se o contexto estiver vazio
            
            if(!context.Produtos.Any())
            //inserir os produtos inicias
            {
                context.Produtos.AddRange(
                    new Produto { Nome = "Camisa Social", preco = 250, FabricanteId = 1 },
                    new Produto { Nome = "Short", preco = 120, FabricanteId = 1 },
                    new Produto { Nome = "Tenis", preco = 540, FabricanteId = 2 });
                context.Fabricantes.AddRange(
                    new Fabricante { Nome = "Adidas" },
                    new Fabricante { Nome = "Nike" });
            }
        }
    }
}
