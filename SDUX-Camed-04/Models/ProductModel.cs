using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_04.Models
{
    public class ProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O campo ProductName é obrigatório.")]
        [StringLength(100)]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "O campo Value é obrigatório.")]
        [Range(0.01, 10000, ErrorMessage = "O valor permitido deve estar entre 0.01 e 10000")]
        public decimal Value { get; set; }

        [Required(ErrorMessage = "O campo Quantity é obrigatório.")]
        [Range(0, 100, ErrorMessage = "A quantidade deve estar entre 0 e 100")]
        public int Quantity { get; set; }
    }
}
