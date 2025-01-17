using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_02.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime? DataNascimento { get; set; }
    }
}
