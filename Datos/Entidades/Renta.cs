using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    public class Renta
    {
        public int RentaId { get; set; }
        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; } = new Cliente();
        public int PeliculaId { get; set; }
        public Pelicula Pelicula { get; set; } = new Pelicula();
        public DateTime FechaRenta { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioRenta { get; set; }

    }
}

