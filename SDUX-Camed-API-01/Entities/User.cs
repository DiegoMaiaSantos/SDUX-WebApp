using System.ComponentModel.DataAnnotations;

namespace SDUX_Camed_API_01.Entities
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
