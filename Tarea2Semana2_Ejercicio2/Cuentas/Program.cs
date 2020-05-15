using Cuentas.Models;
using System;

namespace Cuentas
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta Cuenta1 = new Cuenta();
            CuentaAhorros CuentaA1 = new CuentaAhorros(5000.0,0.02);
            CuentaA1.Abonar(200.0);
            CuentaA1.CalcularInteres();
            CuentaCheques CuentaC1 = new CuentaCheques();
            Console.WriteLine("El Interes del Saldo inicial ({0}) es: {1}",CuentaA1.SaldoCuenta,CuentaA1.TasaInteres);
        }
    }
}
