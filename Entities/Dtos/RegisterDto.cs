using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "Kullanýcý adý gerekli.")]
        public String? UserName { get; init; }
        
        [Required(ErrorMessage = "E-Posta gereklidir.")]
        public String? Email { get; init; }
        
        [Required(ErrorMessage = "Þifre Gereklidir.")]
        public String? Password { get; init; }
    }
}