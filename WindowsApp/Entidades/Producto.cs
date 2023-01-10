using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsApp.Entidades
{
    public class Producto
    {
        public string Nombre { get; set; }     
        public string Descripcion{ get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; } 
        public decimal PrecioBruto
        {
            get { return (PrecioCosto + (PrecioCosto * Convert.ToDecimal(this.Margen))); }

        }
        public decimal PrecioVenta
        {
            get { return PrecioBruto * Convert.ToDecimal(1 + this.IVA); }
        }
        public string Proveedor { get; set; }

        public string Categoria { get; set; }
        public string SubCategoria { get; set; }
    }
}
