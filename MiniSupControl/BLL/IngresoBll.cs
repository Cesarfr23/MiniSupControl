using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class IngresoBll
    {
        public static bool Insertar(Ingreso ingreso)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Ingreso.Add(ingreso);
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

        public static Ingreso Buscar(int IngresoId)
        {
            var db = new MiniSubControlDb();

            return db.Ingreso.Find(IngresoId);

        }
        public static void Eliminar(int IngresoId)
        {
            using (var db = new MiniSubControlDb())
            {
                var ingreso = db.Ingreso.Find(IngresoId);

                db.Ingreso.Remove(ingreso);
                db.SaveChanges();
            }

        }
        public static void Modificar(int IngresoId, DateTime fecha)
        {
            using (var db = new MiniSubControlDb())
            {
                var ingreso = db.Ingreso.Find(IngresoId);
                ingreso.Fecha = fecha;
                db.SaveChanges();
            }
        }

        public static List<Ingreso> GetLista()
        {
            List<Ingreso> lista = new List<Ingreso>();

            var db = new MiniSubControlDb();

            lista = db.Ingreso.ToList();

            return lista;

        }
    }
}
