namespace Minimarketplace.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Description { get; set; } = "";
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = ""; // одно изображение на продукт
        public string ColorHex { get; set; } = "#FFD700"; // цвет свечи
    }
}