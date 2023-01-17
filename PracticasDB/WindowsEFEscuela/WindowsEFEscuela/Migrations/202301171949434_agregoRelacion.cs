namespace WindowsEFEscuela.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregoRelacion : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Alumno", "profesor_ProfesorId", c => c.Int());
            CreateIndex("dbo.Alumno", "profesor_ProfesorId");
            AddForeignKey("dbo.Alumno", "profesor_ProfesorId", "dbo.Profesor", "ProfesorId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Alumno", "profesor_ProfesorId", "dbo.Profesor");
            DropIndex("dbo.Alumno", new[] { "profesor_ProfesorId" });
            DropColumn("dbo.Alumno", "profesor_ProfesorId");
        }
    }
}
