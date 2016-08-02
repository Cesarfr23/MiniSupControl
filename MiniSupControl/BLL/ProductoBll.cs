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
        public static void Eliminar(int ProductoId)
        {
            using (var db = new MiniSubControlDb())
            {
                var producto = db.Producto.Find(ProductoId);

                db.Producto.Remove(producto);
                db.SaveChanges();
            }

        }

        public static void Modificar(int ProductoId, string nombre, string descripcion, int cantidad, int presentacion)
        {
            using (var db = new MiniSubControlDb())
            {
                var producto = db.Producto.Find(ProductoId);
                producto.Nombre = nombre;
                producto.Descripcion = descripcion;
                producto.Cantidad = cantidad;
                producto.PresentacionId = presentacion;
                db.SaveChanges();
            }
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
