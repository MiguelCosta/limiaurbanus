namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddDistrito : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Distrito",
                c => new
                {
                    DistritoId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                })
                .PrimaryKey(t => t.DistritoId);

        }

        public override void Down()
        {
            DropTable("dbo.Distrito");
        }
    }
}
