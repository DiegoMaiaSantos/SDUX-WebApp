using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_API_02.Entities
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, ErrorMessage = "O Nome só permite 100 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Range(0.01, 10000.00, ErrorMessage = "O Valor precisa estar entre 0.01 e 10000.00.")]
        public decimal Valor { get; set; }

        [Required(ErrorMessage = "O campo Quantidade é obrigatório.")]
        [Range(0, 100, ErrorMessage = "A Quantidade deve estar entre 0 e 100")]
        public int Quantidade { get; set; }

        //public int? ClienteId { get; set; }
        //public Cliente? Cliente { get; set; }
    }
}
