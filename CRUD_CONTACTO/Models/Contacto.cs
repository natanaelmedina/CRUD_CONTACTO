using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webApi.Models
{
    public class Contacto
    {
        [Key]
        public int ContactoId { get; set; }
        public int DireccionId { get; set; }
        public string Nombre { get; set; }
        public int Apellidos { get; set; }
        public string Correo { get; set; }
        public DateTime Cumpleaños { get; set; }
    }

    public class Direccion
    {
        [Key]
        public int DireccionId { get; set; }
        public string Calle { get; set; }
        public int Numero { get; set; }
        public string DireccionPrinicipal { get; set; }
    }
}
