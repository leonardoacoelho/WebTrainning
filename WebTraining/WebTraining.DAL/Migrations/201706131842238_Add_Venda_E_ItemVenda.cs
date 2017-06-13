namespace WebTraining.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Venda_E_ItemVenda : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItensVenda",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Item = c.Int(nullable: false),
                        Produto_Id = c.Int(nullable: false),
                        Quantidade = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValorUnitario = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ValoTotal = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Venda_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Produtos", t => t.Produto_Id, cascadeDelete: true)
                .ForeignKey("dbo.Vendas", t => t.Venda_Id, cascadeDelete: true)
                .Index(t => t.Produto_Id)
                .Index(t => t.Venda_Id);
            
            CreateTable(
                "dbo.Vendas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Cliente_Id = c.Int(nullable: false),
                        Data = c.DateTime(nullable: false),
                        Valor = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.Cliente_Id, cascadeDelete: true)
                .Index(t => t.Cliente_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ItensVenda", "Venda_Id", "dbo.Vendas");
            DropForeignKey("dbo.Vendas", "Cliente_Id", "dbo.Clientes");
            DropForeignKey("dbo.ItensVenda", "Produto_Id", "dbo.Produtos");
            DropIndex("dbo.Vendas", new[] { "Cliente_Id" });
            DropIndex("dbo.ItensVenda", new[] { "Venda_Id" });
            DropIndex("dbo.ItensVenda", new[] { "Produto_Id" });
            DropTable("dbo.Vendas");
            DropTable("dbo.ItensVenda");
        }
    }
}
