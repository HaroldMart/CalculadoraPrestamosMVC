using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;
using Application.Enum;
using Application.Services;

namespace CalculadoraPrestamosMVC.Controllers
{
    public class PrestamosController : Controller
    {
        public IActionResult Prestamos()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Prestamos(Prestamos prestamo)
        {
            int tasaDeInteres;
            
            if(prestamo.tipoPrestamo == (int)TipoPrestamosEnum.PERSONAL)
            {
                CalculoCuotaPrestamo resultado;
                tasaDeInteres = 22;
                resultado = CalculoCuotaPrestamo.CalculoCuota(prestamo, tasaDeInteres);
                ViewBag.total = resultado.total;
                ViewBag.cuota = resultado.Cuotamensual;

            } else if (prestamo.tipoPrestamo == (int)TipoPrestamosEnum.AUTOMOVIL)
            {
                CalculoCuotaPrestamo resultado;
                tasaDeInteres = 12;
                resultado = CalculoCuotaPrestamo.CalculoCuota(prestamo, tasaDeInteres);
                ViewBag.total = resultado.total;
                ViewBag.cuota = resultado.Cuotamensual;

            }
            else if (prestamo.tipoPrestamo == (int)TipoPrestamosEnum.HIPOTECARIO)
            {
                CalculoCuotaPrestamo resultado;
                tasaDeInteres = 8;
                resultado = CalculoCuotaPrestamo.CalculoCuota(prestamo, tasaDeInteres);
                ViewBag.total = resultado.total;
                ViewBag.cuota = resultado.Cuotamensual;
            }

            return View();
        }
    }
}
