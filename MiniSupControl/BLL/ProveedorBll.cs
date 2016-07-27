using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ProveedorBll
    {
        public static bool Insertar(Proveedor proveedor)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Proveedor.Add(proveedor);
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

        public static Proveedor Buscar(int ProveedorId)
        {
            var db = new MiniSubControlDb();

            return db.Proveedor.Find(ProveedorId);

        }
        public static Proveedor Eliminar(int ProveedorId)
        {
            var db = new MiniSubControlDb();

            return db.Proveedor.Find(ProveedorId);

            db.Proveedor.Remove(ProveedorId);
            db.SaveChanges();

        }

        public static Proveedor Modificar(int ProveedorId)
        {
            var db = new MiniSubControlDb();

            return db.Proveedor.Find(ProveedorId);
        }

        public static List<Proveedor> GetLista()
        {
            List<Proveedor> lista = new List<Proveedor>();

            var db = new MiniSubControlDb();

            lista = db.Proveedor.ToList();

            return lista;

        }
    }
}
