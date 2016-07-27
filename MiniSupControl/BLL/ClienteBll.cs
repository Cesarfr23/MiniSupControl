using DAL;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public static class ClienteBll
    {
        public static bool Insertar(Cliente cliente)
        {
            bool retorno = false;
            try
            {
                using (var db = new MiniSubControlDb())
                {
                    db.Cliente.Add(cliente);
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

        public static Cliente Buscar(int ClienteId)
        {
            var db = new MiniSubControlDb();

            return db.Cliente.Find(ClienteId);

        }
        public static Cliente Eliminar(int ClienteId)
        {
            var db = new MiniSubControlDb();

            return db.Cliente.Find(ClienteId);

            db.Categoria.Remove(ClienteId);
            db.SaveChanges();

        }

        public static Cliente Modificar(int ClienteId)
        {
            var db = new MiniSubControlDb();

            return db.Cliente.Find(ClienteId);
        }

        public static List<Cliente> GetLista()
        {
            List<Cliente> lista = new List<Cliente>();

            var db = new MiniSubControlDb();

            lista = db.Cliente.ToList();

            return lista;

        }
    }
}
