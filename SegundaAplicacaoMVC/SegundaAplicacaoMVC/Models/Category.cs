using System.ComponentModel.DataAnnotations;
namespace SegundaAplicacaoMVC.Models
{
    public class Category
    {
        [Display(Name = "Category Code")]
        public long CategoryID { get; set; }

        [Display(Name = "Category Name")]
        public string Name { get; set; }
    }
}
