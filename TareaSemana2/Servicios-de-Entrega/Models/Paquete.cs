using System;
using System.Collections.Generic;
using System.Text;

namespace Servicios_de_Entrega.Models
{
    public class Paquete
    {
        private double costoPaquete; //Miembro
        public double CostoPaquetes { get { return costoPaquete; } }
        public string Nombre { get; set; } // Propiedad miembro nombre
        public string Direccion { get; set; } // Propiedad miembro direccion
        public string Ciudad { get; set; } // Propiedad miembro ciudad
        public string Estado { get; set; } // Propiedad miembro estado
        public string CodigoPost { get; set; } // Propiedad miembro codigoPost
        private double pesoOnza; //Miembro
        public double PesoOnza //Propiedad
        {
            get { return pesoOnza; }
            set {
                    if (value<0)
                    {
                        Console.WriteLine("   !!!No se permiten valores negativos¡¡¡   \n_____________________________________________");
                        pesoOnza = 0;
                    }
                    else
                    {
                        pesoOnza = value;
                    }
                }
        }
        private double costo_xOnza; //Miembro
        public double Costo_xOnza //Propiedad
        {
            get { return costo_xOnza; }
            set {
                    if (value<0)
                    {
                        Console.WriteLine("   !!!No se permiten valores negativos¡¡¡   \n_____________________________________________");
                        costo_xOnza = 0;
                    }
                    else
                    {
                        costo_xOnza = value;
                    }
                }
        }

        //Constructor por Defecto
        public Paquete()
        {
            this.Nombre = null;
            this.Direccion = null;
            this.Ciudad = null;
            this.Estado = null;
            this.CodigoPost = null;
            this.pesoOnza = 0.0;
            this.costo_xOnza = 0.0;
            this.costoPaquete = 0.0;
        }

        //Cosntructor Parametrizado
        public Paquete(string pnombre, string pdireccion, string pciudad, string pestado, string pcodigoPost, double ppesoOnza, double pcosto_xOnza)
        {
            this.Nombre = pnombre;
            this.Direccion = pdireccion;
            this.Ciudad = pciudad;
            this.Estado = pestado;
            this.CodigoPost = pcodigoPost;
            if (ppesoOnza<0)
            {
                Console.WriteLine("   !!!No se permiten valores negativos¡¡¡   \n_____________________________________________");
                ppesoOnza = 0;
            }
            else
            {
                this.pesoOnza = ppesoOnza;
            }
            if (pcosto_xOnza < 0)
            {
                Console.WriteLine("   !!!No se permiten valores negativos¡¡¡   \n_____________________________________________");
                pcosto_xOnza = 0;
            }
            else
            {
                this.costo_xOnza = pcosto_xOnza;
            }
            
        }

        //Funciones miembros
        public virtual double CalcularCosto()
        {
            this.costoPaquete = this.pesoOnza * this.costo_xOnza;

            return this.costoPaquete;
        }
        

    }
}
