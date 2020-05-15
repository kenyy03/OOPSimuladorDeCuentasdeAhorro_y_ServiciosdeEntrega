using System;
using System.Collections.Generic;
using System.Text;

namespace Cuentas.Models
{
    public class Cuenta
    {
        // Propiedades miembro
        public double SaldoCuenta { get; set; }

        //Constructor por Defecto

        public Cuenta()
        {
            this.SaldoCuenta = 0.0;
        }

        //Constructor Parametrizado
        public Cuenta(double pSaldoInicial)
        {
            if (pSaldoInicial<0 )
            {
                Console.WriteLine("   ¡¡¡ El Saldo Inicial es invalido!!!   \n_____________________________________________");
                this.SaldoCuenta = 0.0;
            }
            else
            {
                this.SaldoCuenta = pSaldoInicial;
            }

        }

        //Funciones

        public virtual double Abonar(double pAbono)
        {
            if (pAbono<0)
            {
                Console.WriteLine("   ¡¡¡ El Abono ingresado es invalido!!!   \n_____________________________________________");
                pAbono = 0.0;
            }
            else 
            { 
            this.SaldoCuenta += pAbono;
            }
            return this.SaldoCuenta;
        }

        public virtual bool Cargar(double pRetiro)
        {
            bool bRetiro = false;
            if (pRetiro<0)
            {
                Console.WriteLine("   ¡¡¡ El Retiro ingresado es invalido!!!   \n_____________________________________________");
                pRetiro = 0.0;
                bRetiro = false;
            }
            else if (pRetiro>this.SaldoCuenta)
            {
                Console.WriteLine("El monto a cargar excedió el saldo de la cuenta");
                this.SaldoCuenta = this.SaldoCuenta;
                bRetiro = false;
            }
            else
            {
                this.SaldoCuenta -= pRetiro;
                bRetiro = true;
            }
            return bRetiro;
        }
    }
}
