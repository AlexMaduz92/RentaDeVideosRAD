using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Entidades
{
    internal class Renta
    {
        public int RentaId { get; set; }
        public int ClienteId { get; set; }
        public int PeliculaId { get; set; }
        public DateTime FechaRenta { get; set; }
        public DateTime FechaRetorno { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioRenta { get; set; }
    }
}
