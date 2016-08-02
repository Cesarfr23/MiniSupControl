using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CategoriaBll
    {
        public static List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();

            var db = new MiniSubControlDb();

            lista = db.Categoria.ToList();

            return lista;

        }
    }
}
