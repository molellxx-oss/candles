using Microsoft.AspNetCore.Identity;


namespace Minimarketplace.Web.Models
{
public class ApplicationUser : IdentityUser
{
public string? FullName { get; set; }
}
}