using Microsoft.AspNetCore.Mvc;

namespace Evidence_08.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
