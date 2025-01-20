using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_API_02.Entities
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome só permite 100 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatório.")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve ter o formato: 000.000.000-00")]
        public string CPF { get; set;}

        public ICollection<Produto>? ClienteProdutos { get; set; }
    }
}
