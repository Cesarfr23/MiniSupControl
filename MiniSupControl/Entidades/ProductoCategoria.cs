using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ProductoCategoria
    {
        [Key]
        public int Id { get; set; }
        public int ProductoId { get; set; }
        public int CategoriaId { get; set; }

        public virtual Producto Producto { get; set; }
        public virtual Categoria Categoria { get; set; }
    }
}
