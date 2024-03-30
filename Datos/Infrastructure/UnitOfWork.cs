using System;
using Datos.Entidades;
using Datos.Repositories;
using System.Data.Entity;

namespace Datos.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;
        private bool _disposed;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Peliculas = new Repository<Pelicula>(_context);
            Clientes = new Repository<Cliente>(_context);
            Rentas = new Repository<Renta>(_context);
        }

        public IRepository<Pelicula> Peliculas { get; private set; }
        public IRepository<Cliente> Clientes { get; private set; }
        public IRepository<Renta> Rentas { get; private set; }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    // Liberar recursos administrados
                    _context.Dispose();
                }

                // Liberar recursos no administrados

                _disposed = true;
            }
        }
        Recuerda que esta corrección es válida si la clase UnitOfWork
    }
}
