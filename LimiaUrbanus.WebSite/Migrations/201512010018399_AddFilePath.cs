namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFilePath : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.FilePath",
                c => new
                    {
                        FilePathId = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 255),
                        FileTye = c.Int(nullable: false),
                        ImovelId = c.Int(nullable: false),
                        IsPrincipal = c.Boolean(nullable: false),
                        IsCapa = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.FilePathId)
                .ForeignKey("dbo.Imovel", t => t.ImovelId, cascadeDelete: true)
                .Index(t => t.ImovelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.FilePath", "ImovelId", "dbo.Imovel");
            DropIndex("dbo.FilePath", new[] { "ImovelId" });
            DropTable("dbo.FilePath");
        }
    }
}
