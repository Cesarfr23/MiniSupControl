using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Detalle_IngresoBll
    {
        public static bool Insertar(Detalle_Ingreso detalle_Ingreso)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Detalle_Ingreso.Add(detalle_Ingreso);
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

        public static Detalle_Ingreso Buscar(int Detalle_IngresoId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Ingreso.Find(Detalle_IngresoId);

        }
        public static Detalle_Ingreso Eliminar(int Detalle_IngresoId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Ingreso.Find(Detalle_IngresoId);

            db.Detalle_Ingreso.Remove(Detalle_IngresoId);
            db.SaveChanges();

        }

        public static Detalle_Ingreso Modificar(int Detalle_IngresoId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Ingreso.Find(Detalle_IngresoId);
        }

        public static List<Detalle_Ingreso> GetLista()
        {
            List<Detalle_Ingreso> lista = new List<Detalle_Ingreso>();

            var db = new MiniSubControlDb();

            lista = db.Detalle_Ingreso.ToList();

            return lista;

        }
    }
}
