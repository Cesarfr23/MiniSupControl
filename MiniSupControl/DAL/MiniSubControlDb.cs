using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DAL
{
    public class MiniSubControlDb : DbContext
    {
        public MiniSubControlDb() : base("name=MiniSubControl")
        {
        }

        public virtual DbSet<Usuario> Usuario { set; get; }

    public class DbContext
    {
    }
}
}
