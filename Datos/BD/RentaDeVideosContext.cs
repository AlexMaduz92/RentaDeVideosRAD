using Datos.Entidades;
using System.Data.Entity;

namespace Datos.BD
{
    public class RentaDeVideosContext : DbContext
    {

        //Solo de esta forma me acepto la migracion, me daba el siguiente error,No connection string named 'RPELISCONEC' could be found in the application config file
        public RentaDeVideosContext()
      : base("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=RPELISCONEC;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True")

        {
            Peliculas = Set<Pelicula>();
            Clientes = Set<Cliente>();
            Rentas = Set<Renta>();
        }

        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Renta> Rentas { get; set; }

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
