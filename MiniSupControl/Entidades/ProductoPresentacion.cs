using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoPresentacion
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int PresentacionId { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Presentacion Presentacion { get; set; }
    }
}
