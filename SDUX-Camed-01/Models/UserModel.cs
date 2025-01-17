using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_01.Models
{
    public class UserModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public DateTime DataNascimento { get; set; }
    }
}
