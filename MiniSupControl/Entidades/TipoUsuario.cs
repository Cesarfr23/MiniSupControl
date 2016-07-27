using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class TipoUsuario
    {
        [Key]
        public string Administrador { get; set; }
        public string Invitado { get; set; }
        public virtual Usuario Usuario { get; set; }
    }
}
