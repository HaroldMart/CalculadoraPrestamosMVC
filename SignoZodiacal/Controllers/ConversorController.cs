using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;

namespace CalculadoraPrestamosMVC.Controllers
{
    public class ConversorController : Controller
    {
        public IActionResult Conversor()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Conversor(ConversorMoneda peso)
        {
            double resultado = 0;

            //Convertir dolar a peso
            if (peso.moneda == 1 && peso.convertido == 2)
            {
                resultado = 55.15 * peso.cantidad;
            }
            //Convertir peso a dolar 
            if (peso.moneda == 2 && peso.convertido == 1)
            {
                resultado = 0.018 * peso.cantidad;
            }
            //Convertir dolar a euro
            if (peso.moneda == 1 && peso.convertido == 3)
            {
                resultado = 0.95 * peso.cantidad;
            }
            //Convertir peso a euro
            if (peso.moneda == 2 && peso.convertido == 3)
            {
                resultado = 0.017 * peso.cantidad;
            }
            //Convertir euro a dolar
            if (peso.moneda == 3 && peso.convertido == 1)
            {
                resultado = 1.05 * peso.cantidad;
            }
            //Convertir euro a peso
            if (peso.moneda == 3 && peso.convertido == 2)
            {
                resultado = 58.17 * peso.cantidad;
            }

            ViewBag.resultado = resultado;
            return View(peso);

            }
        }
    }