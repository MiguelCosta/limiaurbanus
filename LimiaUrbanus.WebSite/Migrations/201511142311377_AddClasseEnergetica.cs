namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddClasseEnergetica : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ClasseEnergetica",
                c => new
                {
                    ClasseEnergeticaId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Ordem = c.Int(nullable: false),
                })
                .PrimaryKey(t => t.ClasseEnergeticaId);

        }

        public override void Down()
        {
            DropTable("dbo.ClasseEnergetica");
        }
    }
}
