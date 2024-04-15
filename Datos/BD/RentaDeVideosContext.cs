using Datos.Entidades;
using System.Data.Entity;

namespace Datos.BD
{
    public class RentaDeVideosContext : DbContext
    {
        public DbSet<Pelicula> Peliculas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Renta> Rentas { get; set; }

        public RentaDeVideosContext()
            : base("Data Source=DESKTOP-Q6JBD0N\\SQLEXPRESS01;Initial Catalog=RPELISCONEC;Persist Security Info=True;User ID=sa;Password=123456789;MultipleActiveResultSets=True")
        {
        }

        public override int SaveChanges()
        {
            // Se ha verificado que este método se está llamando correctamente.
            return base.SaveChanges();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuración de las entidades
            modelBuilder.Entity<Pelicula>().ToTable("Peliculas");
            modelBuilder.Entity<Cliente>().ToTable("Clientes");
            modelBuilder.Entity<Renta>().ToTable("Rentas");

            // Configuración de las claves primarias y relaciones
            modelBuilder.Entity<Pelicula>().HasKey(p => p.PeliculaId);
            modelBuilder.Entity<Cliente>().HasKey(c => c.ClienteId);
            modelBuilder.Entity<Renta>().HasKey(r => r.RentaId);

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
