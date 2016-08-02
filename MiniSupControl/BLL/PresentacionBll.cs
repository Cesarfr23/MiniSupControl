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
        public static List<Presentacion> GetLista()
        {
            List<Presentacion> lista = new List<Presentacion>();

            var db = new MiniSubControlDb();

            lista = db.Presentacion.ToList();

            return lista;

        }
    }
}
