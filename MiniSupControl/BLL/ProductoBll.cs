using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ProductoBll
    {
        public static bool Insertar(Producto producto)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Producto.Add(producto);
                    db.SaveChanges();
                    retorno = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return retorno;
        }

        public static Producto Buscar(int ProductoId)
        {
            var db = new MiniSubControlDb();

            return db.Producto.Find(ProductoId);

        }
        public static Producto Eliminar(int ProductoId)
        {
            var db = new MiniSubControlDb();

            return db.Producto.Find(ProductoId);

            db.Producto.Remove(ProductoId);
            db.SaveChanges();

        }

        public static Producto Modificar(int ProductoId)
        {
            var db = new MiniSubControlDb();

            return db.Producto.Find(ProductoId);
        }

        public static List<Producto> GetLista()
        {
            List<Producto> lista = new List<Producto>();

            var db = new MiniSubControlDb();

            lista = db.Producto.ToList();

            return lista;

        }
    }
}
