using Minimarketplace.Web.Models;

namespace Minimarketplace.Web.Data
{
    public static class SeedData
    {
        public static void Initialize(AppDbContext context)
        {
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product { Name = "Свеча Лаванда", Description = "Ароматная свеча лаванды", Price = 5.99m, ImageUrl = "images/lavender.jpg" },
                    new Product { Name = "Свеча Роза", Description = "Свеча с ароматом розы", Price = 6.99m, ImageUrl = "images/rose.jpg" },
                    new Product { Name = "Свеча Ваниль", Description = "Тёплый аромат ванили", Price = 4.99m, ImageUrl = "images/vanilla.jpg" }
                );
                context.SaveChanges();
            }
        }
    }
}
