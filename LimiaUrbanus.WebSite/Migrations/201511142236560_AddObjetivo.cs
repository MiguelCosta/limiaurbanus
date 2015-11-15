namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddObjetivo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Objetivo",
                c => new
                {
                    ObjetivoId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                })
                .PrimaryKey(t => t.ObjetivoId);

        }

        public override void Down()
        {
            DropTable("dbo.Objetivo");
        }
    }
}
