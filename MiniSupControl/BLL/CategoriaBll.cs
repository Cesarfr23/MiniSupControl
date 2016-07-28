using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class CategoriaBll
    {
        public static bool Insertar(Categoria categoria)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Categoria.Add(categoria);
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

        public static Categoria Buscar(int CategoriaId)
        {
            var db = new MiniSubControlDb();

            return db.Categoria.Find(CategoriaId);

        }
        public static void Eliminar()
        {
            var db = new MiniSubControlDb();

            Categoria categoria = db.Categoria.Find();

            db.Categoria.Remove(categoria);
            db.SaveChanges();

        }

        public static Categoria Modificar(int CategoriaId)
        {
            var db = new MiniSubControlDb();

            return db.Categoria.Find(CategoriaId);
        }

        public static List<Categoria> GetLista()
        {
            List<Categoria> lista = new List<Categoria>();

            var db = new MiniSubControlDb();

            lista = db.Categoria.ToList();

            return lista;

        }
    }
}
