using Datos.Entidades;

using Datos.Repositories;
using Datos.Repository;
using System;
using System.Data.Entity;

namespace Datos.BD
{
    public class RentaDeVideosContext : DbContext
    {
        private readonly UnitOfWork _unitOfWork;

        public RentaDeVideosContext()
            : base("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=RPELISCONEC;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True")
        {
            _unitOfWork = new UnitOfWork(this);

            Peliculas = _unitOfWork.Peliculas;
            Clientes = _unitOfWork.Clientes;
            Rentas = _unitOfWork.Rentas;
        }

        public IRepository<Pelicula> Peliculas { get; }
        public IRepository<Cliente> Clientes { get; }
        public IRepository<Renta> Rentas { get; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Mapeo de las entidades a las tablas
            modelBuilder.Entity<Pelicula>().ToTable("Peliculas");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Renta>().ToTable("Rentas");

            // Configuración de las claves primarias
            modelBuilder.Entity<Pelicula>().HasKey(p => p.PeliculaId);
            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);
            modelBuilder.Entity<Renta>().HasKey(r => r.RentaId);

            // Configuración de las relaciones entre las entidades
            modelBuilder.Entity<Renta>()
                    .HasRequired(r => r.Pelicula)
                    .WithMany(p => p.Rentas)
                    .HasForeignKey(r => r.PeliculaId);

            modelBuilder.Entity<Renta>()
                .HasRequired(r => r.Cliente)
                .WithMany(c => c.Rentas)
                .HasForeignKey(r => r.ClienteId);
        }
    }
}
