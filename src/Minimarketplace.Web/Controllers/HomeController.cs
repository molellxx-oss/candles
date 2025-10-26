using Microsoft.AspNetCore.Mvc;

namespace Minimarketplace.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
