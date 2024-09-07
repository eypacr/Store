using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record RegisterDto
    {
        [Required(ErrorMessage = "Kullan�c� ad� gerekli.")]
        public String? UserName { get; init; }
        
        [Required(ErrorMessage = "E-Posta gereklidir.")]
        public String? Email { get; init; }
        
        [Required(ErrorMessage = "�ifre Gereklidir.")]
        public String? Password { get; init; }
    }
}