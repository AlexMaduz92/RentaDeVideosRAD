using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
   public class Pelicula
    {
        public int PeliculaId { get; set; }
        public string Nombre { get; set; } = "";
        public string Genero { get; set; } = "";
        public string Autores { get; set; } = "";
        public int Existencia { get; set; }
        public decimal PrecioRenta { get; set; }
        public bool Estado { get; set; }

        public List<Renta> Rentas { get; set; } = new List<Renta>();

    }
}

