using Datos.BD;
using Datos.Entidades;
using Datos.Repository;
using System;
using System.Collections.Generic;

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
            _repositorio.Insert(pelicula);
        }
    }
}

