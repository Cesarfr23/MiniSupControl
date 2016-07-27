using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class TipoUsuarioBll
    {
        public static bool Insertar(TipoUsuario tipoUsuario)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.TipoUsuario.Add(tipoUsuario);
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

        public static TipoUsuario Buscar(int TipoUsuarioId)
        {
            var db = new MiniSubControlDb();

            return db.TipoUsuario.Find(TipoUsuarioId);

        }
        public static TipoUsuario Eliminar(int TipoUsuarioId)
        {
            var db = new MiniSubControlDb();

            return db.TipoUsuario.Find(TipoUsuarioId);

            db.TipoUsuario.Remove(TipoUsuarioId);
            db.SaveChanges();

        }

        public static TipoUsuario Modificar(int TipoUsuarioId)
        {
            var db = new MiniSubControlDb();

            return db.TipoUsuario.Find(TipoUsuarioId);
        }

        public static List<TipoUsuario> GetLista()
        {
            List<TipoUsuario> lista = new List<TipoUsuario>();

            var db = new MiniSubControlDb();

            lista = db.TipoUsuario.ToList();

            return lista;

        }
    }
}
