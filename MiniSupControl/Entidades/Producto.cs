using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        [Key]
        public int ProductoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public int CategoriaId { get; set; }
        public int PresentacionId { get; set; }

        public virtual Categoria Categoria { get; set; }
        public virtual Presentacion Presentacion { get; set; }
    }
}
