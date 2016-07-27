using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class Detalle_VentaBll
    {
        public static bool Insertar(Detalle_Venta detalle_Venta)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Detalle_Venta.Add(detalle_Venta);
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

        public static Detalle_Venta Buscar(int Detalle_VentaId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Venta.Find(Detalle_VentaId);

        }
        public static Detalle_Venta Eliminar(int Detalle_VentaId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Venta.Find(Detalle_VentaId);

            db.Detalle_Venta.Remove(Detalle_VentaId);
            db.SaveChanges();

        }

        public static Detalle_Venta Modificar(int Detalle_VentaId)
        {
            var db = new MiniSubControlDb();

            return db.Detalle_Venta.Find(Detalle_VentaId);
        }

        public static List<Detalle_Venta> GetLista()
        {
            List<Detalle_Venta> lista = new List<Detalle_Venta>();

            var db = new MiniSubControlDb();

            lista = db.Detalle_Venta.ToList();

            return lista;

        }
    }
}
