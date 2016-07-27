using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class UsuarioBll
    {
        public static bool Insertar(Usuario usuario)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Usuario.Add(usuario);
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

        public static Usuario Buscar(int UsuarioId)
        {
            var db = new MiniSubControlDb();

            return db.Usuario.Find(UsuarioId);

        }
        public static Usuario Eliminar(int UsuarioId)
        {
            var db = new MiniSubControlDb();

            db.Usuario.Find(UsuarioId);

            db.Usuario.Remove(UsuarioId);
            db.SaveChanges();

        }

        public static Usuario Modificar(int UsuarioId)
        {
            var db = new MiniSubControlDb();

            return db.Usuario.Find(UsuarioId);
        }

        public static List<Usuario> GetLista()
        {
            List<Usuario> lista = new List<Usuario>();

            var db = new MiniSubControlDb();

            lista = db.Usuario.ToList();

            return lista;

        }
    }
}
