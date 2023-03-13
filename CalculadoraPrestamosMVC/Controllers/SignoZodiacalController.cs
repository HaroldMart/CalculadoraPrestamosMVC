using Microsoft.AspNetCore.Mvc;
using Application.ViewModels;
using Application.Enum;

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

            if((fecha.mes == (int)MesesSignoZodiacalEnum.MARZO && fecha.dia >= 21) || (fecha.mes == (int)MesesSignoZodiacalEnum.ABRIL && fecha.dia <= 19))
            {
                signo = "Aries";
            } 
            else if((fecha.mes == (int)MesesSignoZodiacalEnum.ABRIL && fecha.dia >= 20) || (fecha.mes == (int)MesesSignoZodiacalEnum.MAYO && fecha.dia <= 20))
            {
                signo = "Tauro";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.MAYO && fecha.dia >= 21) || (fecha.mes == (int)MesesSignoZodiacalEnum.JUNIO && fecha.dia <= 20))
            {
                signo = "Geminis";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.JUNIO && fecha.dia >= 21) || (fecha.mes == (int)MesesSignoZodiacalEnum.JULIO && fecha.dia <= 22))
            {
                signo = "Cancer";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.JULIO && fecha.dia >= 23) || (fecha.mes == (int)MesesSignoZodiacalEnum.AGOSTO && fecha.dia <= 22))
            {
                signo = "Leo";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.AGOSTO && fecha.dia >= 23) || (fecha.mes == (int)MesesSignoZodiacalEnum.SEPTIEMBRE && fecha.dia <= 22))
            {
                signo = "Virgo";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.SEPTIEMBRE && fecha.dia >= 23) || (fecha.mes == (int)MesesSignoZodiacalEnum.OCTUBRE && fecha.dia <= 22))
            {
                signo = "Libra";
            } 
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.OCTUBRE && fecha.dia >= 23) || (fecha.mes == (int)MesesSignoZodiacalEnum.NOVIEMBRE && fecha.dia <= 21))
            {
                signo = "Escorpio";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.NOVIEMBRE && fecha.dia >= 22) || (fecha.mes == (int)MesesSignoZodiacalEnum.DICIEMBRE && fecha.dia <= 21))
            {
                signo = "Sagitario";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.DICIEMBRE && fecha.dia >= 22) || (fecha.mes == (int)MesesSignoZodiacalEnum.ENERO && fecha.dia <= 20))
            {
                signo = "Capricornio";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.ENERO && fecha.dia >= 21) || (fecha.mes == (int)MesesSignoZodiacalEnum.FEBRERO && fecha.dia <= 19))
            {
                signo = "Acuario";
            }
            else if ((fecha.mes == (int)MesesSignoZodiacalEnum.FEBRERO && fecha.dia >= 20) || (fecha.mes == (int)MesesSignoZodiacalEnum.MARZO && fecha.dia <= 20))
            {
                signo = "Piscis";
            }

            ViewBag.mivida = signo;
            return View(fecha);
        }
    }
}
