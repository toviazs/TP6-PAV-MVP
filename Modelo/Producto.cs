using System;
using System.Collections.Generic;
using System.Text;

namespace TP6.Modelo
{
    public class Producto : ICloneable
    {
        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public double CSI { get; set; }
        public double PI { get { return 0.21; } }
        public double CCI { get; set; }
        public double MG { get; set; }
        public double PF { get; set; }
        public int Stock { get; set; }
        public Estado Estado { get; set; }

        public Producto(int cod, string desc, double csi, double pf, int stock)
        {
            Codigo = cod;
            Descripcion = desc;
            CSI = csi;
            PF = pf;
            Stock = stock;
            Estado = Estado.Activo;

            CCI = CalcularCostoCI(csi, PI);
            MG = CalcularMargenGanancia(pf, CCI);
        }
        public double CalcularCostoCI(double costoSI, double iva)
        {
            return costoSI + (costoSI * iva);
        }
        public double CalcularMargenGanancia(double precioFinal, double costoCI)
        {
            return (precioFinal - costoCI) / costoCI;
        }
        public double CalcularPrecioFinal(double costoCI, double margenGncia)
        {
            return costoCI + costoCI * margenGncia;
        }

        public Producto(int cod, string desc, double csi, int stock, double mg)
        {
            Codigo = cod;
            Descripcion = desc;
            CSI = csi;
            Stock = stock;
            Estado = Estado.Activo;
            MG = mg;

            CCI = csi + (csi * PI);
            PF = CalcularPrecioFinal(CCI, mg);
        }

        public Object Clone()
        {
            Producto clon = new Producto();

            clon.Codigo = this.Codigo;
            clon.Descripcion = this.Descripcion;
            clon.CSI = this.CSI;
            clon.CCI = this.CCI;
            clon.MG = this.MG;
            clon.PF = this.PF;
            clon.Stock = this.Stock;
            clon.Estado = this.Estado;

            return clon;
        }

        public void CopiarEn(Producto p)
        {
            p.CCI = this.CCI;
            p.CSI = this.CSI;
            p.Descripcion = this.Descripcion;
            p.Estado = this.Estado;
            p.MG = this.MG;
            p.PF = this.PF;
            p.Stock = this.Stock;
        }

        public Producto() { }
    }

    public enum Estado
    {
        Activo,
        Inactivo,
        Eliminiado
    }
}
