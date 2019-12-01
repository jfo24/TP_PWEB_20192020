namespace Trabalho.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DB_Trabalho : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.Estacoes", newName: "Estacaos");
            RenameTable(name: "dbo.Veiculos", newName: "Veiculoes");
            DropForeignKey("dbo.Veiculos", "Cliente_ID", "dbo.Clientes");
            DropIndex("dbo.Estacaos", new[] { "ID" });
            DropIndex("dbo.Veiculoes", new[] { "Cliente_ID" });
            DropIndex("dbo.Proprietarios", new[] { "ID" });
            DropPrimaryKey("dbo.Estacaos");
            DropPrimaryKey("dbo.Proprietarios");
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        EmpresaID = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Email = c.String(),
                        NIB = c.Int(nullable: false),
                        NIPC = c.Int(nullable: false),
                        Cliente_ID = c.Int(),
                        Veiculo_VeiculoID = c.Int(),
                    })
                .PrimaryKey(t => t.EmpresaID)
                .ForeignKey("dbo.Clientes", t => t.Cliente_ID)
                .ForeignKey("dbo.Veiculoes", t => t.Veiculo_VeiculoID)
                .Index(t => t.EmpresaID, unique: true)
                .Index(t => t.Cliente_ID)
                .Index(t => t.Veiculo_VeiculoID);
            
            AddColumn("dbo.Clientes", "NIF", c => c.String());
            AddColumn("dbo.Clientes", "NIB", c => c.String());
            AddColumn("dbo.Estacaos", "EstacaoID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Proprietarios", "ProprietarioID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Proprietarios", "NIB", c => c.Int(nullable: false));
            AddColumn("dbo.Proprietarios", "NIF", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Estacaos", "EstacaoID");
            AddPrimaryKey("dbo.Proprietarios", "ProprietarioID");
            CreateIndex("dbo.Estacaos", "EstacaoID", unique: true);
            CreateIndex("dbo.Proprietarios", "ProprietarioID", unique: true);
            DropColumn("dbo.Clientes", "Morada");
            DropColumn("dbo.Clientes", "Conta");
            DropColumn("dbo.Estacaos", "ID");
            DropColumn("dbo.Veiculoes", "Cliente_ID");
            DropColumn("dbo.Proprietarios", "ID");
            DropColumn("dbo.Proprietarios", "Conta");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Proprietarios", "Conta", c => c.Int(nullable: false));
            AddColumn("dbo.Proprietarios", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Veiculoes", "Cliente_ID", c => c.Int());
            AddColumn("dbo.Estacaos", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Clientes", "Conta", c => c.Int(nullable: false));
            AddColumn("dbo.Clientes", "Morada", c => c.String());
            DropForeignKey("dbo.Empresas", "Veiculo_VeiculoID", "dbo.Veiculoes");
            DropForeignKey("dbo.Empresas", "Cliente_ID", "dbo.Clientes");
            DropIndex("dbo.Proprietarios", new[] { "ProprietarioID" });
            DropIndex("dbo.Estacaos", new[] { "EstacaoID" });
            DropIndex("dbo.Empresas", new[] { "Veiculo_VeiculoID" });
            DropIndex("dbo.Empresas", new[] { "Cliente_ID" });
            DropIndex("dbo.Empresas", new[] { "EmpresaID" });
            DropPrimaryKey("dbo.Proprietarios");
            DropPrimaryKey("dbo.Estacaos");
            DropColumn("dbo.Proprietarios", "NIF");
            DropColumn("dbo.Proprietarios", "NIB");
            DropColumn("dbo.Proprietarios", "ProprietarioID");
            DropColumn("dbo.Estacaos", "EstacaoID");
            DropColumn("dbo.Clientes", "NIB");
            DropColumn("dbo.Clientes", "NIF");
            DropTable("dbo.Empresas");
            AddPrimaryKey("dbo.Proprietarios", "ID");
            AddPrimaryKey("dbo.Estacaos", "ID");
            CreateIndex("dbo.Proprietarios", "ID", unique: true);
            CreateIndex("dbo.Veiculoes", "Cliente_ID");
            CreateIndex("dbo.Estacaos", "ID", unique: true);
            AddForeignKey("dbo.Veiculos", "Cliente_ID", "dbo.Clientes", "ID");
            RenameTable(name: "dbo.Veiculoes", newName: "Veiculos");
            RenameTable(name: "dbo.Estacaos", newName: "Estacoes");
        }
    }
}
