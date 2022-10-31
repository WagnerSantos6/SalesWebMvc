using Microsoft.AspNetCore.Mvc;

namespace SalesWeb.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
