using System.ComponentModel.DataAnnotations;

namespace FurniLux.Models
{
    public class Product
    {
        public required int Id { get; set; }
        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name cannot exceed 100 characters.")]
        public required string Name { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string? Description { get; set; }
        [Required(ErrorMessage = "Price is required.")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than 0.")]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Stock quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity cannot be negative.")]
        public int StockQuantity { get; set; }
        public string? ImageUrl { get; set; }
        [StringLength(50, ErrorMessage = "Dimensions cannot exceed 50 characters.")]
        public string? Dimensions { get; set; }
        [StringLength(50, ErrorMessage = "Material cannot exceed 50 characters.")]
        public string? Material { get; set; }
        [Required(ErrorMessage = "Color is required.")]
        [StringLength(20, ErrorMessage = "Color cannot exceed 20 characters.")]
        public required string Color { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }


    }
}
