namespace FurniLux.Models
{
    public class Product
    {
        public required int Id { get; set; }
        public required string Name { get; set; }

        public string? Description { get; set; }

        public decimal Price { get; set; }

        public int StockQuantity { get; set; }

        public required string ImageUrl { get; set; }

        public string? Dimensions { get; set; }

        public string? Material { get; set; }

        public required string Color { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public DateTime? UpdatedAt { get; set; }


    }
}
