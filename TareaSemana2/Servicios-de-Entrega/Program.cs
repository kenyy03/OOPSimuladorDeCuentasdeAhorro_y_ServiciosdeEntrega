using Servicios_de_Entrega.Models;
using System;

namespace Servicios_de_Entrega
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prueba Peso con *Valor Negativo*
            Paquete P1 = new Paquete("Juan Carlos", "Bo. Centro, 2da avenida, 7 calle", "SPS", "Soltero", "10101",-4.2, 2.05);
            P1.CalcularCosto();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("---Prueba *Peso en onzas* con valor de *Negativo*---\n");
            Console.WriteLine("Nombre: {0}\nCiudad: {1}\nDireccion: {2}\nEstado: {3}\nCodigo Postal: {4}\nPeso(Onzas): {5}" +
                "\nCosto por Onzas: {6}\nGasto Total del Paquete: {7}", P1.Nombre, P1.Ciudad,P1.Direccion,P1.Estado,P1.CodigoPost,P1.PesoOnza,P1.Costo_xOnza,P1.CostoPaquetes);
            Console.WriteLine("________________________________________________________________________\n");
            //Prueba Costo por Onza con *Valor Negativo*
            Paquete P2 = new Paquete("Pablo Ramirez", "Bo. Centro, 3era avenida, 7 calle", "SPS", "Soltero", "10101", 4.2, -2.05);
            P2.CalcularCosto();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("---Prueba *Costo por onzas* con valor de *Negativo*---\n");
            Console.WriteLine("Nombre: {0}\nCiudad: {1}\nDireccion: {2}\nEstado: {3}\nCodigo Postal: {4}\nPeso(Onzas): {5}" +
                "\nCosto por Onzas: {6}\nGasto Total del Paquete: {7}", P2.Nombre, P2.Ciudad, P2.Direccion, P2.Estado, P2.CodigoPost, P2.PesoOnza, P2.Costo_xOnza, P2.CostoPaquetes);
            Console.WriteLine("________________________________________________________________________\n");

            //PAQUETE DOS DIAS
            Paquete_DosDias P2Dias = new Paquete_DosDias(10.03);
            P2Dias.Nombre = "Rebecca Iscoa";
            P2Dias.Ciudad = "SPS";
            P2Dias.Direccion = "Col. 15 Octubre, calle principal";
            P2Dias.Estado = "Casada";
            P2Dias.CodigoPost = "10102";
            P2Dias.PesoOnza = 4.2;
            P2Dias.Costo_xOnza = 2.05;

            P2Dias.CalcularCosto();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("---Prueba *PAQUETE DE DOS DIAS* *Cuota Fija de: 10.03 *---\n");
            Console.WriteLine("Nombre: {0}\nCiudad: {1}\nDireccion: {2}\nEstado: {3}\nCodigo Postal: {4}\nPeso(Onzas): {5}" +
                "\nCosto por Onzas: {6}\nGasto Total del Paquete: {7}", P2Dias.Nombre, P2Dias.Ciudad, P2Dias.Direccion, P2Dias.Estado, P2Dias.CodigoPost, P2Dias.PesoOnza, P2Dias.Costo_xOnza, P2Dias.CuotaFija);
            Console.WriteLine("________________________________________________________________________\n");


            //PAQUETE ADICIONAL NOCTURNO
            PaqueteNocturno PN1 = new PaqueteNocturno();
            PN1.CuotaNocturnaAdicional = 12.06;
            PN1.Nombre = "Rebecca Iscoa";
            PN1.Ciudad = "SPS";
            PN1.Direccion = "Col. 15 Octubre, calle principal";
            PN1.Estado = "Casada";
            PN1.CodigoPost = "10102";
            PN1.PesoOnza = 4.2;
            PN1.Costo_xOnza = 2.05;

            PN1.CalcularCosto();
            Console.WriteLine("________________________________________________________________________");
            Console.WriteLine("---Prueba *PAQUETE ADICIONAL NOCTURNO* *Cuota Nocturna de: 12.06 *---\n");
            Console.WriteLine("Nombre: {0}\nCiudad: {1}\nDireccion: {2}\nEstado: {3}\nCodigo Postal: {4}\nPeso(Onzas): {5}" +
                "\nCosto por Onzas: {6}\nGasto Total del Paquete: {7}", PN1.Nombre, PN1.Ciudad, PN1.Direccion, PN1.Estado, PN1.CodigoPost, PN1.PesoOnza, PN1.Costo_xOnza, PN1.CostoPaquetes);
            Console.WriteLine("________________________________________________________________________\n");
        }
    }
}
