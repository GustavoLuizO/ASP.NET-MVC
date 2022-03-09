using System.Collections.Generic;
namespace APP_with_ENitty_Framework.Models
{
    public class manufacturer
    {
        public int manufacturerId { get; set; }
        public string name { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
