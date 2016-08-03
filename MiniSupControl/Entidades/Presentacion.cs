using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Presentacion
    {
        [Key]
        public int PresentacionId { get; set; }
        public string Descripcion { get; set; }

        public Presentacion()
        {
            this.Producto = new HashSet<Producto>();
        }

        [Browsable(false)]
        public virtual ICollection<Producto> Producto { get; set; }

        public Presentacion(int presentacionId, string descripcion)
        {
            this.PresentacionId = presentacionId;
            this.Descripcion = descripcion;
            this.Producto = new HashSet<Producto>();
        }
    }
}
