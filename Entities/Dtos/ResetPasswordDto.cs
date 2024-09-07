using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ResetPasswordDto
    {
        public String? UserName { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Þifre gereklidir.")]
        public String? Password { get; init; }
        
        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Onaylama Þifresi gerekli.")]
        [Compare("Password",ErrorMessage = "Þifre ve Þifreyi Onayla eþleþmelidir.")]
        public String? ConfirmPassword { get; init; }
    }
}