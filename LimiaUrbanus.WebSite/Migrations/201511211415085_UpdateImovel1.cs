namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class UpdateImovel1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Imovel", "IsAtivo", c => c.Boolean(nullable: false));
        }

        public override void Down()
        {
            DropColumn("dbo.Imovel", "IsAtivo");
        }
    }
}
