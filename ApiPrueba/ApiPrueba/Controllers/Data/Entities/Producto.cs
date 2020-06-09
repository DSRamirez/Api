using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace ApiPrueba.Controllers.Data.Entities
{
    public class Producto
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Precio { get; set; }
        [Required]
        public string Proveedor { get; set; }
    }
}
