using System;
using Datos.Entidades;
using Datos.Repository;
using System.Data.Entity;

namespace Datos.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Pelicula> Peliculas { get; }
        IRepository<Cliente> Clientes { get; }
        IRepository<Renta> Rentas { get; }

        void SaveChanges();
    }

    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _context;

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
