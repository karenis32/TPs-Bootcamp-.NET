namespace WindowsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class cambioTablas : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Clinicas", newName: "Clinica");
            RenameTable(name: "dbo.Habitacions", newName: "Habitaciones");
            AddColumn("dbo.Habitaciones", "Descripción", c => c.String(maxLength: 200, unicode: false));
            AlterColumn("dbo.Clinica", "Nombre", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Habitaciones", "Estado", c => c.String(nullable: false, maxLength: 50, unicode: false));
            DropColumn("dbo.Habitaciones", "Descripcion");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Habitaciones", "Descripcion", c => c.String());
            AlterColumn("dbo.Habitaciones", "Estado", c => c.String());
            AlterColumn("dbo.Clinica", "Nombre", c => c.String());
            DropColumn("dbo.Habitaciones", "Descripción");
            RenameTable(name: "dbo.Habitaciones", newName: "Habitacions");
            RenameTable(name: "dbo.Clinica", newName: "Clinicas");
        }
    }
}
