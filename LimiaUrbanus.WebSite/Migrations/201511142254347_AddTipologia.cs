namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddTipologia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tipologia",
                c => new
                {
                    TipologiaId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Ordem = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.TipologiaId);

        }

        public override void Down()
        {
            DropTable("dbo.Tipologia");
        }
    }
}
