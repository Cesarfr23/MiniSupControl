using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Detalle_Ingreso
    {
        [Key]
        public int Detalle_IngresoId { get; set; }
        public virtual Ingreso Ingreso { get; set; }
        public virtual Producto Producto { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public DateTime FechaVencimiento { get; set; }
    }
}
