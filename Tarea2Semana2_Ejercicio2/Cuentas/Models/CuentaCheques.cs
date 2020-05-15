using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas.Models
{
    public class CuentaCheques : Cuenta
    {
        //Propiedad Miembro
        public double CuotaporTransaccion { get; set; }

        //Constructor por Defecto
        public CuentaCheques()
        {
            this.CuotaporTransaccion = 0.0;
        }

        //Constructor Parametrizado
        public CuentaCheques(double pSaldoInicial, double pMontoCuota )
        {
            this.SaldoCuenta = pSaldoInicial;
            this.CuotaporTransaccion = pMontoCuota;
        }

        //Funciones
        public override double Abonar(double pAbono)
        {
            this.CuotaporTransaccion -= base.Abonar(pAbono);
            return this.CuotaporTransaccion;
        }

        public override bool Cargar(double pRetiro)
        {
            bool bEvaluar = true;

            if (base.Cargar(pRetiro).Equals(bEvaluar))
            {
                this.CuotaporTransaccion -= this.SaldoCuenta ;
                bEvaluar = true;
            }
            else
            {
                bEvaluar = false;
            }
            return bEvaluar;
        }
    }
}
