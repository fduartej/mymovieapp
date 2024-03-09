using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mymovieapp.Models
{
    public class Cliente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? CorreoElectronico { get; set; }
        public string? Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
    }
}