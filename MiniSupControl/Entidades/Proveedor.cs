using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Proveedor
    {
        [Key]
        public int ProveedorId { get; set; }
        public string Empresa { get; set;}
        public string Direccion { get; set;}
        public string Telefono { get; set;}
        public string Correo { get; set;}
        public int RNC { get; set; }
    }
}
