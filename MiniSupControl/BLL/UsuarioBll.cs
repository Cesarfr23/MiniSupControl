using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
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
        public static void Eliminar(int UsuarioId)
        {
            using (var db = new MiniSubControlDb())
            {
                var usuario = db.Usuario.Find(UsuarioId);

                db.Usuario.Remove(usuario);
                db.SaveChanges();
            }

        }

        public static void Modificar(int UsuarioId, string nombre, string apellido, string sexo, string fecha, string correo, string acceso, string usuario, string clave, string conficlave)
        {
            using (var db = new MiniSubControlDb())
            {
                var usuarios = db.Usuario.Find(UsuarioId);
                usuarios.Nombre = nombre;
                usuarios.Apellido = apellido;
                usuarios.Sexo = sexo;
                usuarios.Fecha_Nacimiento = fecha;
                usuarios.Correo = correo;
                usuarios.UseName = usuario;
                usuarios.Clave = clave;
                usuarios.ConfirmarClave = conficlave;
                db.SaveChanges();
            }
        }

        public static List<Usuario> GetLista()
        {
            List<Usuario> lista = new List<Usuario>();

            var db = new MiniSubControlDb();

            lista = db.Usuario.ToList();

            return lista;

        }

        public static List<Usuario> GetListaUsuario(string aux)
        {
            List<Usuario> lista = new List<Usuario>();

            var db = new MiniSubControlDb();

            lista = db.Usuario.Where(p => p.UseName == aux).ToList();

            return lista;

        }
    }
}
