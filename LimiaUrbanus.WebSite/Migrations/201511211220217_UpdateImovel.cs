namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateImovel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Imovel", "TipologiaId", "dbo.Tipologia");
            DropIndex("dbo.Imovel", new[] { "TipologiaId" });
            AddColumn("dbo.Imovel", "IsOportunidade", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Imovel", "TipologiaId", c => c.Int());
            CreateIndex("dbo.Imovel", "TipologiaId");
            AddForeignKey("dbo.Imovel", "TipologiaId", "dbo.Tipologia", "TipologiaId");
            DropColumn("dbo.Imovel", "IsPesquisa");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Imovel", "IsPesquisa", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.Imovel", "TipologiaId", "dbo.Tipologia");
            DropIndex("dbo.Imovel", new[] { "TipologiaId" });
            AlterColumn("dbo.Imovel", "TipologiaId", c => c.Int(nullable: false));
            DropColumn("dbo.Imovel", "IsOportunidade");
            CreateIndex("dbo.Imovel", "TipologiaId");
            AddForeignKey("dbo.Imovel", "TipologiaId", "dbo.Tipologia", "TipologiaId", cascadeDelete: true);
        }
    }
}
