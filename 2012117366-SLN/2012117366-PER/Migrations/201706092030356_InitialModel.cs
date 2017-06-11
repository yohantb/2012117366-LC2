namespace _2012117366_PER.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AdministradorEquipo",
                c => new
                    {
                        AdministradorEquipoID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorEquipoID);
            
            CreateTable(
                "dbo.EquipoCelular",
                c => new
                    {
                        EquipoCelularID = c.Int(nullable: false, identity: true),
                        AdministradorEquipoID = c.Int(nullable: false),
                        EvaluacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EquipoCelularID)
                .ForeignKey("dbo.AdministradorEquipo", t => t.AdministradorEquipoID, cascadeDelete: true)
                .Index(t => t.AdministradorEquipoID);
            
            CreateTable(
                "dbo.Evaluacion",
                c => new
                    {
                        EvaluacionID = c.Int(nullable: false),
                        EstadoEvalucionId = c.Int(nullable: false),
                        TipoEvaluacion = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                        plandId = c.Int(nullable: false),
                        TrabajadorID = c.Int(nullable: false),
                        CentroAtencionID = c.Int(nullable: false),
                        EquipoCelular_EquipoCelularID = c.Int(nullable: false),
                        EstadoEvaluacion_EstadoEvaluacionID = c.Int(nullable: false),
                        LineaTelefonica_LineaTelefonicaID = c.Int(nullable: false),
                        Plan_PlanID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EvaluacionID)
                .ForeignKey("dbo.Venta", t => t.EvaluacionID)
                .ForeignKey("dbo.CentroAtencion", t => t.CentroAtencionID, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.EquipoCelular", t => t.EquipoCelular_EquipoCelularID, cascadeDelete: true)
                .ForeignKey("dbo.EstadoEvaluacion", t => t.EstadoEvaluacion_EstadoEvaluacionID, cascadeDelete: true)
                .ForeignKey("dbo.LineaTelefonica", t => t.LineaTelefonica_LineaTelefonicaID, cascadeDelete: true)
                .ForeignKey("dbo.Plan", t => t.Plan_PlanID, cascadeDelete: true)
                .ForeignKey("dbo.Trabajor", t => t.TrabajadorID, cascadeDelete: true)
                .Index(t => t.EvaluacionID)
                .Index(t => t.ClienteId)
                .Index(t => t.TrabajadorID)
                .Index(t => t.CentroAtencionID)
                .Index(t => t.EquipoCelular_EquipoCelularID)
                .Index(t => t.EstadoEvaluacion_EstadoEvaluacionID)
                .Index(t => t.LineaTelefonica_LineaTelefonicaID)
                .Index(t => t.Plan_PlanID);
            
            CreateTable(
                "dbo.CentroAtencion",
                c => new
                    {
                        CentroAtencionID = c.Int(nullable: false, identity: true),
                        DireccionID = c.Int(nullable: false),
                        EvaluacionID = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.CentroAtencionID);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        DireccionID = c.Int(nullable: false),
                        CadenaUbigeo = c.String(),
                        CentroAtencionID = c.Int(nullable: false),
                        DistritoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DireccionID)
                .ForeignKey("dbo.Distrito", t => t.DistritoID, cascadeDelete: true)
                .ForeignKey("dbo.CentroAtencion", t => t.DireccionID)
                .Index(t => t.DireccionID)
                .Index(t => t.DistritoID);
            
            CreateTable(
                "dbo.Distrito",
                c => new
                    {
                        DistritoID = c.Int(nullable: false, identity: true),
                        ProvinciaID = c.Int(nullable: false),
                        DireccionID = c.Int(nullable: false),
                        CadenaUbigeo = c.String(),
                    })
                .PrimaryKey(t => t.DistritoID)
                .ForeignKey("dbo.Provincia", t => t.ProvinciaID, cascadeDelete: true)
                .Index(t => t.ProvinciaID);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        ProvinciaID = c.Int(nullable: false, identity: true),
                        CadenaUbigeo = c.String(),
                        DepartamentoID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProvinciaID)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoID, cascadeDelete: true)
                .Index(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        DepartamentoID = c.Int(nullable: false, identity: true),
                        ProvinciaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.DepartamentoID);
            
            CreateTable(
                "dbo.Venta",
                c => new
                    {
                        VentaID = c.Int(nullable: false, identity: true),
                        ClienteId = c.Int(nullable: false),
                        TipoPago = c.Int(nullable: false),
                        ContratoId = c.Int(nullable: false),
                        EvaluacionId = c.Int(nullable: false),
                        LineaTelefonicaId = c.Int(nullable: false),
                        CentroAtencionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.VentaID)
                .ForeignKey("dbo.CentroAtencion", t => t.CentroAtencionID, cascadeDelete: true)
                .ForeignKey("dbo.Cliente", t => t.ClienteId, cascadeDelete: true)
                .Index(t => t.ClienteId)
                .Index(t => t.CentroAtencionID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteID = c.Int(nullable: false, identity: true),
                        EvaluacionID = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteID);
            
            CreateTable(
                "dbo.Contrato",
                c => new
                    {
                        ContratoID = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ContratoID)
                .ForeignKey("dbo.Venta", t => t.ContratoID)
                .Index(t => t.ContratoID);
            
            CreateTable(
                "dbo.LineaTelefonica",
                c => new
                    {
                        LineaTelefonicaID = c.Int(nullable: false),
                        TipoLinea = c.Int(nullable: false),
                        AdministradorLineaID = c.Int(nullable: false),
                        VentaID = c.Int(nullable: false),
                        EvaluacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LineaTelefonicaID)
                .ForeignKey("dbo.AdministradorLinea", t => t.AdministradorLineaID, cascadeDelete: true)
                .ForeignKey("dbo.Venta", t => t.LineaTelefonicaID)
                .Index(t => t.LineaTelefonicaID)
                .Index(t => t.AdministradorLineaID);
            
            CreateTable(
                "dbo.AdministradorLinea",
                c => new
                    {
                        AdministradorLineaID = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.AdministradorLineaID);
            
            CreateTable(
                "dbo.EstadoEvaluacion",
                c => new
                    {
                        EstadoEvaluacionID = c.Int(nullable: false, identity: true),
                        EvaluacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstadoEvaluacionID);
            
            CreateTable(
                "dbo.Plan",
                c => new
                    {
                        PlanID = c.Int(nullable: false, identity: true),
                        TipoPlan = c.Int(nullable: false),
                        EvaluacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.PlanID);
            
            CreateTable(
                "dbo.Trabajor",
                c => new
                    {
                        TrabajadorID = c.Int(nullable: false, identity: true),
                        TipoTrabajador = c.Int(nullable: false),
                        EvaluacionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TrabajadorID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Evaluacion", "TrabajadorID", "dbo.Trabajor");
            DropForeignKey("dbo.Evaluacion", "Plan_PlanID", "dbo.Plan");
            DropForeignKey("dbo.Evaluacion", "LineaTelefonica_LineaTelefonicaID", "dbo.LineaTelefonica");
            DropForeignKey("dbo.Evaluacion", "EstadoEvaluacion_EstadoEvaluacionID", "dbo.EstadoEvaluacion");
            DropForeignKey("dbo.Evaluacion", "EquipoCelular_EquipoCelularID", "dbo.EquipoCelular");
            DropForeignKey("dbo.Evaluacion", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Evaluacion", "CentroAtencionID", "dbo.CentroAtencion");
            DropForeignKey("dbo.LineaTelefonica", "LineaTelefonicaID", "dbo.Venta");
            DropForeignKey("dbo.LineaTelefonica", "AdministradorLineaID", "dbo.AdministradorLinea");
            DropForeignKey("dbo.Evaluacion", "EvaluacionID", "dbo.Venta");
            DropForeignKey("dbo.Contrato", "ContratoID", "dbo.Venta");
            DropForeignKey("dbo.Venta", "ClienteId", "dbo.Cliente");
            DropForeignKey("dbo.Venta", "CentroAtencionID", "dbo.CentroAtencion");
            DropForeignKey("dbo.Direccion", "DireccionID", "dbo.CentroAtencion");
            DropForeignKey("dbo.Direccion", "DistritoID", "dbo.Distrito");
            DropForeignKey("dbo.Distrito", "ProvinciaID", "dbo.Provincia");
            DropForeignKey("dbo.Provincia", "DepartamentoID", "dbo.Departamento");
            DropForeignKey("dbo.EquipoCelular", "AdministradorEquipoID", "dbo.AdministradorEquipo");
            DropIndex("dbo.LineaTelefonica", new[] { "AdministradorLineaID" });
            DropIndex("dbo.LineaTelefonica", new[] { "LineaTelefonicaID" });
            DropIndex("dbo.Contrato", new[] { "ContratoID" });
            DropIndex("dbo.Venta", new[] { "CentroAtencionID" });
            DropIndex("dbo.Venta", new[] { "ClienteId" });
            DropIndex("dbo.Provincia", new[] { "DepartamentoID" });
            DropIndex("dbo.Distrito", new[] { "ProvinciaID" });
            DropIndex("dbo.Direccion", new[] { "DistritoID" });
            DropIndex("dbo.Direccion", new[] { "DireccionID" });
            DropIndex("dbo.Evaluacion", new[] { "Plan_PlanID" });
            DropIndex("dbo.Evaluacion", new[] { "LineaTelefonica_LineaTelefonicaID" });
            DropIndex("dbo.Evaluacion", new[] { "EstadoEvaluacion_EstadoEvaluacionID" });
            DropIndex("dbo.Evaluacion", new[] { "EquipoCelular_EquipoCelularID" });
            DropIndex("dbo.Evaluacion", new[] { "CentroAtencionID" });
            DropIndex("dbo.Evaluacion", new[] { "TrabajadorID" });
            DropIndex("dbo.Evaluacion", new[] { "ClienteId" });
            DropIndex("dbo.Evaluacion", new[] { "EvaluacionID" });
            DropIndex("dbo.EquipoCelular", new[] { "AdministradorEquipoID" });
            DropTable("dbo.Trabajor");
            DropTable("dbo.Plan");
            DropTable("dbo.EstadoEvaluacion");
            DropTable("dbo.AdministradorLinea");
            DropTable("dbo.LineaTelefonica");
            DropTable("dbo.Contrato");
            DropTable("dbo.Cliente");
            DropTable("dbo.Venta");
            DropTable("dbo.Departamento");
            DropTable("dbo.Provincia");
            DropTable("dbo.Distrito");
            DropTable("dbo.Direccion");
            DropTable("dbo.CentroAtencion");
            DropTable("dbo.Evaluacion");
            DropTable("dbo.EquipoCelular");
            DropTable("dbo.AdministradorEquipo");
        }
    }
}
