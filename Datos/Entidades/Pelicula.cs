using System.Collections.Generic;

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
