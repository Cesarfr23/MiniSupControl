﻿using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ventaBll
    {
        public static bool Insertar(venta Venta)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.venta.Add(Venta);
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

        public static venta Buscar(int VentaId)
        {
            var db = new MiniSubControlDb();

            return db.venta.Find(VentaId);

        }
        public static void Eliminar(int VentaId)
        {
            using (var db = new MiniSubControlDb())
            {
                var Venta = db.venta.Find(VentaId);

                db.venta.Remove(Venta);
                db.SaveChanges();
            }

        }

        public static void Modificar(int VentaId)
        {
            using (var db = new MiniSubControlDb())
            {
                var Venta = db.venta.Find(VentaId);
                db.SaveChanges();
            }
        }
        public static List<venta> GetLista()
        {
            List<venta> lista = new List<venta>();

            var db = new MiniSubControlDb();

            lista = db.venta.ToList();

            return lista;

        }
    }
}
