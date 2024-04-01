using Datos.Entidades;
using Datos.Repository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Datos.Repositories
{
    public class RepositorioPeliculas
    {
        private IRepository<Pelicula> _repositorio;

        public RepositorioPeliculas(IRepository<Pelicula> repositorio)
        {
            _repositorio = repositorio ?? throw new ArgumentNullException(nameof(repositorio));
        }

        public List<Pelicula> ObtenerPeliculas()
        {
            return _repositorio.GetAll().ToList();
        }

        public void GuardarPelicula(Pelicula pelicula)
        {
            try
            {
                _repositorio.Insert(pelicula);
                _repositorio.SaveChanges(); // Guardar los cambios en la base de datos
            }
            catch (Exception ex)
            {
                // Manejar la excepción o mostrar un mensaje de error
                Console.WriteLine("Error al guardar la película: " + ex.Message);
            }
        }
    }
}
