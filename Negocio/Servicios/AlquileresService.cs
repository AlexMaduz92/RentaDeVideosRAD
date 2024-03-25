using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Peliculas.Data;
using Peliculas.Entidades;
using Peliculas.Negocio.Interfaces;

namespace Negocio.Servicios
{
    public class AlquileresService : IAlquileresService
    {
        private readonly IPeliculasContext _context;

        public AlquileresService(IPeliculasContext context)
        {
            _context = context;
        }

        public void RegistrarAlquiler(int clienteId, int peliculaId, int cantidad)
        {
            var cliente = _context.Clientes.Find(clienteId);
            var pelicula = _context.Peliculas.Find(peliculaId);

            if (cliente == null || pelicula == null)
            {
                throw new Exception("Cliente o película no encontrados");
            }

            if (pelicula.Existencia < cantidad)
            {
                throw new Exception("No hay suficientes existencias de la película");
            }

            var renta = new Renta
            {
                ClienteId = clienteId,
                PeliculaId = peliculaId,
                FechaRenta = DateTime.Now,
                FechaRetorno = DateTime.Now.AddDays(7),
                Cantidad = cantidad,
                PrecioRenta = pelicula.PrecioRenta * cantidad
            };

            pelicula.Existencia -= cantidad;

            _context.Rentas.Add(renta);
            _context.SaveChanges();
        }
    }
}


