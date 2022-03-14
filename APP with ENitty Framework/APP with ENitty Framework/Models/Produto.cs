namespace APP_with_ENitty_Framework.Models
{
    public class Produto
    {
        public int ProdutoId { get; set; }
        public string Nome { get; set; }
        public float preco { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }
    }
}
               