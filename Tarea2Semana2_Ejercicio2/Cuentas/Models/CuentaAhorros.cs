using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas.Models
{
    public class CuentaAhorros : Cuenta
    {
        //Propiedad Miembro
        public double TasaInteres { get; set; }

        //Constructor por Defecto
        public CuentaAhorros()
        {
            this.TasaInteres=0.0;
        }

        //Constructor Parametrizado
        public CuentaAhorros(double pSaldoInicial,double pTasaInicial)
        {
            this.SaldoCuenta = pSaldoInicial;
            this.TasaInteres = pTasaInicial;
        }

        //Funciones
        public double CalcularInteres()
        {
            this.TasaInteres *= this.SaldoCuenta;

            return this.TasaInteres;
        }


    }
}
