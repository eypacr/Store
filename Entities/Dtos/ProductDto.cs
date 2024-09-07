using System.ComponentModel.DataAnnotations;

namespace Entities.Dtos
{
    public record ProductDto
    {
        public int ProductId { get; init; }
        
        [Required(ErrorMessage = "�r�n Ad� gerekli.")]
        public String? ProductName { get; init; } = String.Empty;

        [Required(ErrorMessage = "Fiyat gereklidir.")]
        public decimal Price { get; init; }
        public String? Summary { get; init; } = String.Empty;
        public String? ImageUrl { get; set; }
        public int? CategoryId { get; init; }  
        
    }
}