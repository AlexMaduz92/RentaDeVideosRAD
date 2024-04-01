using Datos.Repositories;
using System;

namespace Datos.Infrastructure
{
    public class UnitOfWork : IDisposable
    {
        private readonly RentaDeVideosContext _context;
        private Repository<Pelicula> _peliculaRepository;
        private Repository<Cliente> _clienteRepository;
        private Repository<Renta> _rentaRepository;

        public UnitOfWork(RentaDeVideosContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public Repository<Pelicula> PeliculaRepository
        {
            get
            {
                if (_peliculaRepository == null)
                {
                    _peliculaRepository = new Repository<Pelicula>(_context);
                }
                return _peliculaRepository;
            }
        }

        public Repository<Cliente> ClienteRepository
        {
            get
            {
                if (_clienteRepository == null)
                {
                    _clienteRepository = new Repository<Cliente>(_context);
                }
                return _clienteRepository;
            }
        }

        public Repository<Renta> RentaRepository
        {
            get
            {
                if (_rentaRepository == null)
                {
                    _rentaRepository = new Repository<Renta>(_context);
                }
                return _rentaRepository;
            }
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
