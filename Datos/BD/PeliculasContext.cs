using Datos.Entidades;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.BD
{
    internal class PeliculasContext : DbContext
    {
        public PeliculasContext(DbContextOptions<PeliculasContext> options)
        : base(options)
        {
        }
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Renta> Rentas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pelicula>().ToTable("Peliculas");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Renta>().ToTable("Rentas");

            modelBuilder.Entity<Pelicula>()
                .HasKey(p => p.PeliculaId);

            modelBuilder.Entity<Cliente>()
                .HasKey(c => c.ClienteId);

            modelBuilder.Entity<Renta>()
                .HasKey(r => r.RentaId);

            modelBuilder.Entity<Renta>()
                .HasOne(r => r.Cliente)
                .WithMany(c => c.Rentas)
                .HasForeignKey(r => r.ClienteId);

            modelBuilder.Entity<Renta>()
                .HasOne(r => r.Pelicula)
                .WithMany(p => p.Rentas)
                .HasForeignKey(r => r.PeliculaId);
        }
    }
}
