namespace WebTraining.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GruposProdutos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Produtos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descricao = c.String(),
                        Valor = c.Double(nullable: false),
                        GrupoProduto_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.GruposProdutos", t => t.GrupoProduto_Id, cascadeDelete: true)
                .Index(t => t.GrupoProduto_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Produtos", "GrupoProduto_Id", "dbo.GruposProdutos");
            DropIndex("dbo.Produtos", new[] { "GrupoProduto_Id" });
            DropTable("dbo.Produtos");
            DropTable("dbo.GruposProdutos");
        }
    }
}
