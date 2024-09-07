using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "�ifre gereklidir.")]
        public String? Password { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Onaylama �ifresi gerekli.")]
        [Compare("Password",ErrorMessage = "�ifre ve �ifreyi Onayla e�le�melidir.")]
        public String? ConfirmPassword { get; init; }
    }
}