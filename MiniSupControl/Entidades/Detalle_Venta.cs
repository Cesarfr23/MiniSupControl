using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Venta
    {
        [Key]
        public int Detalle_VentaId { get; set; }
        public virtual venta venta { get; set; }
        public virtual Ingreso Ingreso { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio_Venta { get; set; }
        public decimal Descuento { get; set; }
    }
}
