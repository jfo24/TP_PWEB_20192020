namespace TPVersao4.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SecondModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Cliente", "ClienteNome", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "ClienteMorada", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "ClienteNIF", c => c.String(nullable: false));
            AlterColumn("dbo.Cliente", "ClienteNIB", c => c.String(nullable: false));
            AlterColumn("dbo.Proprietario", "ProprietarioNome", c => c.String(nullable: false));
            AlterColumn("dbo.Estacao", "EstacaoNome", c => c.String(nullable: false));
            AlterColumn("dbo.Estacao", "EstacaoLocalizacao", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Estacao", "EstacaoLocalizacao", c => c.String());
            AlterColumn("dbo.Estacao", "EstacaoNome", c => c.String());
            AlterColumn("dbo.Proprietario", "ProprietarioNome", c => c.String());
            AlterColumn("dbo.Cliente", "ClienteNIB", c => c.String());
            AlterColumn("dbo.Cliente", "ClienteNIF", c => c.String());
            AlterColumn("dbo.Cliente", "ClienteMorada", c => c.String());
            AlterColumn("dbo.Cliente", "ClienteNome", c => c.String());
        }
    }
}
