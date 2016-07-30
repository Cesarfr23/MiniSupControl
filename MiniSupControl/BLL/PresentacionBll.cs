using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class PresentacionBll
    {
        public static bool Insertar(Presentacion presentacion)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Presentacion.Add(presentacion);
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

        public static Presentacion Buscar(int PresentacionId)
        {
            var db = new MiniSubControlDb();

            return db.Presentacion.Find(PresentacionId);

        }
        public static void Eliminar(int PresentacionId)
        {
            using (var db = new MiniSubControlDb())
            {
                var presentacion = db.Presentacion.Find(PresentacionId);

                db.Presentacion.Remove(presentacion);
                db.SaveChanges();
            }

        }

        public static void Modificar(int PresentacionId, string descripcion)
        {
            using (var db = new MiniSubControlDb())
            {
                var presentacion = db.Presentacion.Find(PresentacionId);
                presentacion.Descripcion = descripcion;
                db.SaveChanges();
            }
        }

        public static List<Presentacion> GetLista()
        {
            List<Presentacion> lista = new List<Presentacion>();

            var db = new MiniSubControlDb();

            lista = db.Presentacion.ToList();

            return lista;

        }
    }
}
