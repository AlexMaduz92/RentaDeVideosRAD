namespace Datos.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class Tablas_Clinete_Renta_Pelicula : DbMigration
    {
        private static readonly string[] RentasIndexClienteId = { "ClienteId" };
        private static readonly string[] RentasIndexPeliculaId = { "PeliculaId" };

        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                {
                    ClienteId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Apellidos = c.String(),
                    FechaIngreso = c.DateTime(nullable: false),
                    Estado = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ClienteId);

            CreateTable(
                "dbo.Rentas",
                c => new
                {
                    RentaId = c.Int(nullable: false, identity: true),
                    ClienteId = c.Int(nullable: false),
                    PeliculaId = c.Int(nullable: false),
                    FechaRenta = c.DateTime(nullable: false),
                    FechaRetorno = c.DateTime(nullable: false),
                    Cantidad = c.Int(nullable: false),
                    PrecioRenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                })
                .PrimaryKey(t => t.RentaId)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Peliculas", t => t.PeliculaId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.PeliculaId);

            CreateTable(
                "dbo.Peliculas",
                c => new
                {
                    PeliculaId = c.Int(nullable: false, identity: true),
                    Nombre = c.String(),
                    Genero = c.String(),
                    Autores = c.String(),
                    Existencia = c.Int(nullable: false),
                    PrecioRenta = c.Decimal(nullable: false, precision: 18, scale: 2),
                    Estado = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.PeliculaId);

            CreateIndex("dbo.Rentas", RentasIndexClienteId);
            CreateIndex("dbo.Rentas", RentasIndexPeliculaId);
        }

        public override void Down()
        {
            DropForeignKey("dbo.Rentas", "PeliculaId", "dbo.Peliculas");
            DropForeignKey("dbo.Rentas", "ClienteId", "dbo.Clientes");
            DropIndex("dbo.Rentas", RentasIndexPeliculaId);
            DropIndex("dbo.Rentas", RentasIndexClienteId);
            DropTable("dbo.Peliculas");
            DropTable("dbo.Rentas");
            DropTable("dbo.Clientes");
        }
    }
}
