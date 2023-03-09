using Microsoft.AspNetCore.Mvc;

namespace CalculadoraPrestamosMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }
    }
}
