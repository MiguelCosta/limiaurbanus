namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Estado",
                c => new
                    {
                        EstadoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.EstadoId);
            
            CreateTable(
                "dbo.Tipo",
                c => new
                    {
                        TipoId = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                    })
                .PrimaryKey(t => t.TipoId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tipo");
            DropTable("dbo.Estado");
        }
    }
}
