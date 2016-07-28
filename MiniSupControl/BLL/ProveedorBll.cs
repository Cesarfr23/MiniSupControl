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
        public static void Eliminar(int ProveedorId)
        {
            using (var db = new MiniSubControlDb())
            {
                var proveedor = db.Proveedor.Find(ProveedorId);

                db.Proveedor.Remove(proveedor);
                db.SaveChanges();
            }

        }

        public static void Modificar(int ProveedorId, string empresa)
        {
            using (var db = new MiniSubControlDb())
            {
                var proveedor = db.Proveedor.Find(ProveedorId);
                proveedor.Empresa = empresa;
                db.SaveChanges();
            }
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
