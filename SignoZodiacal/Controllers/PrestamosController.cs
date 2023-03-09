using Microsoft.AspNetCore.Mvc;

namespace CalculadoraPrestamosMVC.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Prestamos()
        {
            return View();
        }
    }
}
