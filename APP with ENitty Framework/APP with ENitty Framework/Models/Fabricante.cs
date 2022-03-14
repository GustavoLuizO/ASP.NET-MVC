using System.Collections.Generic;

namespace APP_with_ENitty_Framework.Models
{
    public class Fabricante
    {
        public int FabricanteId { get; set; }
        public string Nome { get; set; }
        public ICollection<Produto> Produtos { get; set; }
    }
}
