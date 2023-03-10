using Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class CalculoCuotaPrestamo
    {
        public double prociento { get; set; }
        public double total { get; set; }
        public double Cuotamensual { get; set; }

        private CalculoCuotaPrestamo(double porci, double tot, double cuot) {

            this.prociento = porci;
            this.total = tot;
            this.Cuotamensual = cuot;
        }

        public static CalculoCuotaPrestamo CalculoCuota(Prestamos prestamo, int tasaDeInteres)
        {
            double monto = prestamo.monto;
            int meses = prestamo.meses;

            double porciento = (tasaDeInteres * monto) / 100;
            double total = monto + porciento;

            double cuotaMensual = total / meses;

            CalculoCuotaPrestamo CuotaPago = new(porciento, total, cuotaMensual);
            return CuotaPago;
        }
    }
}
