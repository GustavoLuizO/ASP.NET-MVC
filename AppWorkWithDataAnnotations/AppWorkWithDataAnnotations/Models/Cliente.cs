using System;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AppWorkWithDataAnnotations.Models
{
    public class Cliente
    {
        public int ClienteID { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [StringLength(50,MinimumLength =  4,ErrorMessage ="Digite um texto com 4 a 60 caracteres")]
        public string Sobrenome { get; set; }

        [Display(Name ="Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true,DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime DateDeNascimento { get; set; }

        [ScaffoldColumn(false)]
        public string Endereco { get; set; }

        [Display(Name ="Telefone")]
        [RegularExpression(@"^\(?\d{2}\)?[\s-]?[\s9]?\d{4}-?\d{4}$",ErrorMessage ="Digite o telefone no formato(xx) 9xxxx-xxxx")]
        public string Telefone { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="Digite um endereço válido com @")]
        public string Email { get; set; }

        [Compare("Email",ErrorMessage ="A confirmação não corresponde ao e-mail.")]
        public string ConfirmaEmail { get; set; }
        public string Usuario { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
