using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class MiniSubControlDb : DbContext
    {
        public MiniSubControlDb() : base("name=MiniSubControl");
        {
        
        }
    }
}
