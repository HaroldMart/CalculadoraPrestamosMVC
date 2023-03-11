using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;

namespace CalculadoraPrestamosMVC.Controllers
{
    public class SignoZodiacalController : Controller
    {
        public IActionResult SignoZodiacal()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignoZodiacal(FechaNacimiento fecha)
        {
            string signo = "default";

            if((fecha.mes == 3 && fecha.dia >= 21) || (fecha.mes == 4 && fecha.dia <= 19))
            {
                signo = "Aries";
            } 
            else if((fecha.mes == 4 && fecha.dia >= 20) || (fecha.mes == 5 && fecha.dia <= 20))
            {
                signo = "Tauro";
            }
            else if ((fecha.mes == 5 && fecha.dia >= 21) || (fecha.mes == 6 && fecha.dia <= 20))
            {
                signo = "Geminis";
            }
            else if ((fecha.mes == 6 && fecha.dia >= 21) || (fecha.mes == 7 && fecha.dia <= 22))
            {
                signo = "Cancer";
            }
            else if ((fecha.mes == 7 && fecha.dia >= 23) || (fecha.mes == 8 && fecha.dia <= 22))
            {
                signo = "Leo";
            }
            else if ((fecha.mes == 8 && fecha.dia >= 23) || (fecha.mes == 9 && fecha.dia <= 22))
            {
                signo = "Virgo";
            }
            else if ((fecha.mes == 9 && fecha.dia >= 23) || (fecha.mes == 10 && fecha.dia <= 22))
            {
                signo = "Libra";
            } 
            else if ((fecha.mes == 10 && fecha.dia >= 23) || (fecha.mes == 11 && fecha.dia <= 21))
            {
                signo = "Escorpio";
            }
            else if ((fecha.mes == 11 && fecha.dia >= 22) || (fecha.mes == 12 && fecha.dia <= 21))
            {
                signo = "Sagitario";
            }
            else if ((fecha.mes == 12 && fecha.dia >= 22) || (fecha.mes == 1 && fecha.dia <= 20))
            {
                signo = "Capricornio";
            }
            else if ((fecha.mes == 1 && fecha.dia >= 21) || (fecha.mes == 2 && fecha.dia <= 19))
            {
                signo = "Acuario";
            }
            else if ((fecha.mes == 2 && fecha.dia >= 20) || (fecha.mes == 3 && fecha.dia <= 20))
            {
                signo = "Piscis";
            }

            ViewBag.mivida = signo;
            return View(fecha);
        }
    }
}
