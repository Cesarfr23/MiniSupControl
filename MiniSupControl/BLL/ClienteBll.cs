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
        public static void Eliminar(int ClienteId)
        {
            using (var db = new MiniSubControlDb())
            {
                var cliente = db.Cliente.Find(ClienteId);

                db.Cliente.Remove(cliente);
                db.SaveChanges();
            }

        }

        public static void Modificar(int ClienteId, string nombre)
        {
            using (var db = new MiniSubControlDb())
            {
                var cliente = db.Cliente.Find(ClienteId);
                cliente.Nombre = nombre;
                db.SaveChanges();
            }
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
