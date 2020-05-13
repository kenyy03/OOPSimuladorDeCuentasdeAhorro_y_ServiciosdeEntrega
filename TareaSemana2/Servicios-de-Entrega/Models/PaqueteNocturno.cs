using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios_de_Entrega.Models
{
    public class PaqueteNocturno : Paquete
    {
        //Miembros de clase
        public double CuotaNocturnaAdicional { get; set; }

        //Constructor por Defecto
        public PaqueteNocturno()
        {
            this.CuotaNocturnaAdicional=0.0;
        }

        //Funciones

        public override double CalcularCosto()
        {
            this.Costo_xOnza += this.CuotaNocturnaAdicional;
            return base.CalcularCosto();
        }
    }
}
