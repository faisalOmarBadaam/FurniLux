using FurniLux.Models;

namespace FurniLux.Data
{
    public static class ProductData
    {
        static List<Product> products =
        [
             new Product
            {
                Id = 1,
                Name = "Luxury Leather Chair",
                Description = "A comfortable chair made of genuine leather with a wooden frame.",
                Price = 250.99m,
                StockQuantity = 10,
                ImageUrl = "afeede83-a95d-4b4d-b4f2-31714193f449.webp",
                Dimensions = "50x60x90 cm",
                Material = "Leather + Wood",
                Color = "Black",
            },
            new Product
            {
                Id = 2,
                Name = "Wooden Dining Table",
                Description = "A modern dining table made of oak wood combines sleek, contemporary design with the natural warmth and durability of oak. It typically features clean lines, minimalist aesthetics, and a smooth finish, making it a perfect centerpiece for modern dining spaces. The oak wood adds a touch of elegance with its unique grain patterns, while the modern design ensures it fits seamlessly into stylish, urban interiors. This table is both functional and visually striking, ideal for everyday use or entertaining guests.",
                Price = 499.99m,
                StockQuantity = 5,
                ImageUrl = "b0f8c833-ec4a-4d50-bf2d-47381051a23b.webp",
                Dimensions = "200x90x75 cm",
                Material = "Oak Wood",
                Color = "Brown",
            },
            new Product
            {
                Id = 3,
                Name = "Large Triple Sofa",
                Description = "A luxury three-seater sofa with comfortable cushions.",
                Price = 799.99m,
                StockQuantity = 3,
                ImageUrl = "06221644-5e5a-4417-b5c7-b0510d847203.webp",
                Dimensions = "220x90x85 cm",
                Material = "Fabric + High-Density Foam",
                Color = "Gray",
            },
            new Product
            {
                Id = 4,
                Name = "Double Bed with Storage",
                Description = "A premium bed with storage space under the mattress, made of solid wood.",
                Price = 1200.50m,
                StockQuantity = 2,
                ImageUrl = "6487c35b-2e79-4c83-972f-f6d1821e710c.webp",
                Dimensions = "200x160x50 cm",
                Material = "Solid Wood",
                Color = "White",
            }
        ];


        public static List<Product> getData()
        {
            return products;
        }
    }
}
