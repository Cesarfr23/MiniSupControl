using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ingreso
    {
        [Key]
        public int IngresoId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Proveedor Proveedor { get; set; }
        public DateTime Fecha { get; set; }
    }
}
