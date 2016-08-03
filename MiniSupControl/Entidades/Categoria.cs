using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        public string Descripcion { get; set; }

        public Categoria()
        {
            this.Producto = new HashSet<Producto>();
        }

        [Browsable(false)]
        public virtual ICollection<Producto> Producto { get; set; }

        public Categoria(int categoriaId, string descripcion)
        {
            this.CategoriaId = categoriaId;
            this.Descripcion = descripcion;
            this.Producto = new HashSet<Producto>();
        }
    }
}
