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

        public static void Eliminar(int Detalle_VenteId)
        {
            using (var db = new MiniSubControlDb())
            {
                var detalle_Venta = db.Detalle_Venta.Find(Detalle_VenteId);

                db.Detalle_Venta.Remove(detalle_Venta);
                db.SaveChanges();
            }

        }

        public static void Modificar(int Detalle_VentaId, int cantidad)
        {
            using (var db = new MiniSubControlDb())
            {
                var detalle_Venta = db.Detalle_Venta.Find(Detalle_VentaId);
                detalle_Venta.Cantidad = cantidad;
                db.SaveChanges();
            }
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
