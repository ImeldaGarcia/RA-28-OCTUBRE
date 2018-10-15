namespace GOBUS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Citas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PlacaNumero = c.String(nullable: false, maxLength: 10, unicode: false, storeType: "nvarchar"),
                        FechaCita = c.DateTime(nullable: false, precision: 0),
                        IdCliente = c.Int(nullable: false),
                        IdSucursal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.IdCliente, cascadeDelete: true)
                .ForeignKey("dbo.Sucursales", t => t.IdSucursal, cascadeDelete: true)
                .Index(t => t.IdCliente)
                .Index(t => t.IdSucursal);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Apellidos = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Direccion = c.String(nullable: false, maxLength: 200, unicode: false, storeType: "nvarchar"),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Email = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sucursales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Direcion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Telefono = c.String(nullable: false, maxLength: 20, unicode: false, storeType: "nvarchar"),
                        Encargado = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Servicios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreServicio = c.String(nullable: false, maxLength: 50, unicode: false, storeType: "nvarchar"),
                        Descripcion = c.String(nullable: false, maxLength: 100, unicode: false, storeType: "nvarchar"),
                        Costo = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Citas", "IdSucursal", "dbo.Sucursales");
            DropForeignKey("dbo.Citas", "IdCliente", "dbo.Clientes");
            DropIndex("dbo.Citas", new[] { "IdSucursal" });
            DropIndex("dbo.Citas", new[] { "IdCliente" });
            DropTable("dbo.Servicios");
            DropTable("dbo.Sucursales");
            DropTable("dbo.Clientes");
            DropTable("dbo.Citas");
        }
    }
}
