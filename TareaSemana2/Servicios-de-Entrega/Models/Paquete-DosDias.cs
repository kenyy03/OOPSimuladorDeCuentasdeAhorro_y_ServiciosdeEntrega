using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios_de_Entrega.Models
{
    public class Paquete_DosDias : Paquete
    {
        // Miembro de clase
        public double CuotaFija { get; set; }
        public double TotalCuotaFija { get; set; }

        //Constructor por Defecto
        public Paquete_DosDias()
        {
            this.CuotaFija = 0.0;
            this.TotalCuotaFija = 0.0;
        }

        //Constructor Parametrizado
        public Paquete_DosDias(double pCuotaFija)
        {
            this.TotalCuotaFija = pCuotaFija;
        }

        //Funciones

        public override double CalcularCosto()
        {
            this.CuotaFija = this.TotalCuotaFija + base.CalcularCosto();

            return this.CuotaFija;
        }
    }
}
