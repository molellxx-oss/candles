namespace Minimarketplace.Web.Models
{
public class Order
{
public int Id { get; set; }
public string? CustomerName { get; set; }
public string? CustomerEmail { get; set; }
public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
public decimal Total { get; set; }
public List<OrderItem> Items { get; set; } = new();
}
}