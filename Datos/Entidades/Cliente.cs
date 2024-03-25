using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    internal class Cliente
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaRegistro { get; set; }
        public bool Estado { get; set; }
    }
}
