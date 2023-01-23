namespace WindowsClinica.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class agregoClases : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Medico",
                c => new
                    {
                        IdMedico = c.Int(nullable: false, identity: true),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        IdEspecialidad = c.Int(nullable: false),
                        Matricula = c.Int(nullable: false),
                        FechaNacimiento = c.DateTime(),
                        clinica_Id = c.Int(),
                    })
                .PrimaryKey(t => t.IdMedico)
                .ForeignKey("dbo.Clinica", t => t.clinica_Id)
                .ForeignKey("dbo.Especialidad", t => t.IdEspecialidad, cascadeDelete: true)
                .Index(t => t.IdEspecialidad)
                .Index(t => t.clinica_Id);
            
            CreateTable(
                "dbo.Especialidad",
                c => new
                    {
                        IdEspecialidad = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.IdEspecialidad);
            
            CreateTable(
                "dbo.Paciente",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 50, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 50, unicode: false),
                        NroHistClinica = c.Int(nullable: false),
                        clinica_Id = c.Int(),
                        medico_IdMedico = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clinica", t => t.clinica_Id)
                .ForeignKey("dbo.Medico", t => t.medico_IdMedico)
                .Index(t => t.clinica_Id)
                .Index(t => t.medico_IdMedico);
            
            AddColumn("dbo.Habitaciones", "clinica_Id", c => c.Int());
            CreateIndex("dbo.Habitaciones", "clinica_Id");
            AddForeignKey("dbo.Habitaciones", "clinica_Id", "dbo.Clinica", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Paciente", "medico_IdMedico", "dbo.Medico");
            DropForeignKey("dbo.Paciente", "clinica_Id", "dbo.Clinica");
            DropForeignKey("dbo.Medico", "IdEspecialidad", "dbo.Especialidad");
            DropForeignKey("dbo.Medico", "clinica_Id", "dbo.Clinica");
            DropForeignKey("dbo.Habitaciones", "clinica_Id", "dbo.Clinica");
            DropIndex("dbo.Paciente", new[] { "medico_IdMedico" });
            DropIndex("dbo.Paciente", new[] { "clinica_Id" });
            DropIndex("dbo.Medico", new[] { "clinica_Id" });
            DropIndex("dbo.Medico", new[] { "IdEspecialidad" });
            DropIndex("dbo.Habitaciones", new[] { "clinica_Id" });
            DropColumn("dbo.Habitaciones", "clinica_Id");
            DropTable("dbo.Paciente");
            DropTable("dbo.Especialidad");
            DropTable("dbo.Medico");
        }
    }
}
