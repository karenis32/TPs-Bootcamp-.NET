namespace WindowsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clinica",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        FechaInicioActividades = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Habitaciones",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Numero = c.String(nullable: false),
                        Estado = c.String(nullable: false, maxLength: 50, unicode: false),
                        Descripción = c.String(maxLength: 200, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Habitaciones");
            DropTable("dbo.Clinica");
        }
    }
}
