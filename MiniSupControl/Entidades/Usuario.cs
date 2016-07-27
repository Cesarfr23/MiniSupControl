using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        [Key]
        public int UsuarioId { get; set; }
        public string Nombre {get; set;}
        public string Apellido {get; set;}
        public string Sexo {get; set;}
        public string Fecha_Nacimiento {get; set;}
        public string Telefono {get; set;}
        public string Correo {get; set;}
        public string Acceso {get; set;}
        public string UseName {get; set;}
        public string Clave {get; set;}
        public string ConfirmarClave {get; set;}
    }
}
