namespace TPVersao4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Aluguer",
                c => new
                    {
                        AluguerId = c.Int(nullable: false, identity: true),
                        ProprietarioID = c.Int(nullable: false),
                        VeiculoID = c.Int(nullable: false),
                        ClienteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AluguerId)
                .ForeignKey("dbo.Cliente", t => t.ClienteID, cascadeDelete: true)
                .ForeignKey("dbo.Proprietario", t => t.ProprietarioID, cascadeDelete: true)
                .ForeignKey("dbo.Veiculo", t => t.VeiculoID, cascadeDelete: true)
                .Index(t => t.ProprietarioID)
                .Index(t => t.VeiculoID)
                .Index(t => t.ClienteID);
            
            CreateTable(
                "dbo.Cliente",
                c => new
                    {
                        ClienteId = c.Int(nullable: false, identity: true),
                        ClienteNome = c.String(),
                        ClienteMorada = c.String(),
                        ClienteNIF = c.String(),
                        ClienteNIB = c.String(),
                        ClienteEmail = c.String(),
                        ClienteTelefone = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ClienteId);
            
            CreateTable(
                "dbo.Proprietario",
                c => new
                    {
                        ProprietarioID = c.Int(nullable: false, identity: true),
                        ProprietarioNome = c.String(),
                        ProprietarioEmail = c.String(),
                        ProprietarioNIB = c.Int(nullable: false),
                        ProprietarioNIF = c.Int(nullable: false),
                        TipoProprietario = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProprietarioID);
            
            CreateTable(
                "dbo.Veiculo",
                c => new
                    {
                        VeiculoID = c.Int(nullable: false, identity: true),
                        TipoVeiculo = c.Int(nullable: false),
                        VeiculoPreco = c.Int(nullable: false),
                        VeiculoBateria = c.Int(nullable: false),
                        Estacao_EstacaoID = c.Int(),
                        Proprietario_ProprietarioID = c.Int(),
                    })
                .PrimaryKey(t => t.VeiculoID)
                .ForeignKey("dbo.Estacao", t => t.Estacao_EstacaoID)
                .ForeignKey("dbo.Proprietario", t => t.Proprietario_ProprietarioID)
                .Index(t => t.Estacao_EstacaoID)
                .Index(t => t.Proprietario_ProprietarioID);
            
            CreateTable(
                "dbo.Estacao",
                c => new
                    {
                        EstacaoID = c.Int(nullable: false, identity: true),
                        EstacaoNome = c.String(),
                        EstacaoLocalizacao = c.String(),
                        EstacaoNumVeiculos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EstacaoID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Aluguer", "VeiculoID", "dbo.Veiculo");
            DropForeignKey("dbo.Veiculo", "Proprietario_ProprietarioID", "dbo.Proprietario");
            DropForeignKey("dbo.Veiculo", "Estacao_EstacaoID", "dbo.Estacao");
            DropForeignKey("dbo.Aluguer", "ProprietarioID", "dbo.Proprietario");
            DropForeignKey("dbo.Aluguer", "ClienteID", "dbo.Cliente");
            DropIndex("dbo.Veiculo", new[] { "Proprietario_ProprietarioID" });
            DropIndex("dbo.Veiculo", new[] { "Estacao_EstacaoID" });
            DropIndex("dbo.Aluguer", new[] { "ClienteID" });
            DropIndex("dbo.Aluguer", new[] { "VeiculoID" });
            DropIndex("dbo.Aluguer", new[] { "ProprietarioID" });
            DropTable("dbo.Estacao");
            DropTable("dbo.Veiculo");
            DropTable("dbo.Proprietario");
            DropTable("dbo.Cliente");
            DropTable("dbo.Aluguer");
        }
    }
}
