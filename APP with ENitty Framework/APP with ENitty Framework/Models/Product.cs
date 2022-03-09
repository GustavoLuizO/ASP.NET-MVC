namespace APP_with_ENitty_Framework.Models
{
    public class Product
    {
        public int produutoId { get; set; }
        public string name { get; set; }
        public float cost { get; set; }
        public int manufacturerId { get; set; }
        public manufacturer manufacturer { get; set; }
    }
}
