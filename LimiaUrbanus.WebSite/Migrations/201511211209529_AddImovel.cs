namespace LimiaUrbanus.WebSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class AddImovel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Imovel",
                c => new
                {
                    ImovelId = c.Int(nullable: false, identity: true),
                    Nome = c.String(),
                    Referencia = c.String(),
                    Descricao = c.String(),
                    TipoId = c.Int(nullable: false),
                    EstadoId = c.Int(nullable: false),
                    FreguesiaId = c.Int(nullable: false),
                    Morada = c.String(),
                    CoordenadasGps = c.String(),
                    ObjetivoId = c.Int(nullable: false),
                    ClasseEnergeticaId = c.Int(),
                    Area = c.Double(nullable: false),
                    Wc = c.Int(),
                    TipologiaId = c.Int(nullable: false),
                    Preco = c.Double(nullable: false),
                    ContactoResponsavel = c.String(),
                    IsDestaque = c.Boolean(nullable: false),
                    IsPesquisa = c.Boolean(nullable: false),
                })
                .PrimaryKey(t => t.ImovelId)
                .ForeignKey("dbo.ClasseEnergetica", t => t.ClasseEnergeticaId)
                .ForeignKey("dbo.Estado", t => t.EstadoId, cascadeDelete: true)
                .ForeignKey("dbo.Freguesia", t => t.FreguesiaId, cascadeDelete: true)
                .ForeignKey("dbo.Objetivo", t => t.ObjetivoId, cascadeDelete: true)
                .ForeignKey("dbo.Tipo", t => t.TipoId, cascadeDelete: true)
                .ForeignKey("dbo.Tipologia", t => t.TipologiaId, cascadeDelete: true)
                .Index(t => t.TipoId)
                .Index(t => t.EstadoId)
                .Index(t => t.FreguesiaId)
                .Index(t => t.ObjetivoId)
                .Index(t => t.ClasseEnergeticaId)
                .Index(t => t.TipologiaId);

        }

        public override void Down()
        {
            DropForeignKey("dbo.Imovel", "TipologiaId", "dbo.Tipologia");
            DropForeignKey("dbo.Imovel", "TipoId", "dbo.Tipo");
            DropForeignKey("dbo.Imovel", "ObjetivoId", "dbo.Objetivo");
            DropForeignKey("dbo.Imovel", "FreguesiaId", "dbo.Freguesia");
            DropForeignKey("dbo.Imovel", "EstadoId", "dbo.Estado");
            DropForeignKey("dbo.Imovel", "ClasseEnergeticaId", "dbo.ClasseEnergetica");
            DropIndex("dbo.Imovel", new[] { "TipologiaId" });
            DropIndex("dbo.Imovel", new[] { "ClasseEnergeticaId" });
            DropIndex("dbo.Imovel", new[] { "ObjetivoId" });
            DropIndex("dbo.Imovel", new[] { "FreguesiaId" });
            DropIndex("dbo.Imovel", new[] { "EstadoId" });
            DropIndex("dbo.Imovel", new[] { "TipoId" });
            DropTable("dbo.Imovel");
        }
    }
}
