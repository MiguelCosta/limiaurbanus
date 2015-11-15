namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddFreguesia : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Freguesia",
                c => new
                {
                    FreguesiaId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    ConcelhoId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.FreguesiaId)
                .ForeignKey("dbo.Concelho", t => t.ConcelhoId, cascadeDelete: true)
                .Index(t => t.ConcelhoId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Freguesia", "ConcelhoId", "dbo.Concelho");
            DropIndex("dbo.Freguesia", new[] { "ConcelhoId" });
            DropTable("dbo.Freguesia");
        }
    }
}
