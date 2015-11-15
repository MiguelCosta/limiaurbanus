namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddConcelho : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Concelho",
                c => new
                {
                    ConcelhoId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    DistritoId = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ConcelhoId)
                .ForeignKey("dbo.Distrito", t => t.DistritoId, cascadeDelete: true)
                .Index(t => t.DistritoId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Concelho", "DistritoId", "dbo.Distrito");
            DropIndex("dbo.Concelho", new[] { "DistritoId" });
            DropTable("dbo.Concelho");
        }
    }
}
