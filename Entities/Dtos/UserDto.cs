using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record UserDto
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage = "Kullanýcý Adý gerekli.")]
        public String? UserName { get; init; }
        
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "E-Posta gereklidir.")]
        public String? Email { get; init; }
        
        [DataType(DataType.PhoneNumber)]
        public String? PhoneNumber { get; init; }
        
        public HashSet<String> Roles { get; set; } = new HashSet<string>();
    }
}