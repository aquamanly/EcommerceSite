using Microsoft.AspNetCore.Mvc;

namespace EcommerceSite.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
