using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace SegundaAplicacaoMVC.Models
{
    public class Category
    {
        [Display(Name = "Category")]
        public long idCategory { get; set; }
        [Display(Name = "Name of Category")]
        public string name { get; set; }
    }
}
