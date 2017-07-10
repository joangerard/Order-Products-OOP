namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Papers",
                c => new
                    {
                        BookId = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Author = c.String(),
                        Isbn = c.String(),
                        Title = c.String(),
                        Type = c.Int(nullable: false,defaultValue:0),
                        PublicationDate = c.DateTime(nullable: false,defaultValue:new DateTime(2000,01,01)),
                        PaperType = c.Int(nullable: false,defaultValue:1),
                        Store_StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.BookId)
                .ForeignKey("dbo.Store", t => t.Store_StoreId)
                .Index(t => t.Store_StoreId);
            
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        StoreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.StoreId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false, identity: true),
                        Code = c.String(maxLength: 20),
                        Name = c.String(),
                        Stock = c.Int(nullable: false),
                        ExpirationDate = c.DateTime(nullable: false),
                        Abstract = c.String(),
                        Store_StoreId = c.Int(),
                    })
                .PrimaryKey(t => t.ProductId)
                .ForeignKey("dbo.Store", t => t.Store_StoreId)
                .Index(t => t.Code, unique: true)
                .Index(t => t.Store_StoreId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Store_StoreId", "dbo.Store");
            DropForeignKey("dbo.Papers", "Store_StoreId", "dbo.Store");
            DropIndex("dbo.Product", new[] { "Store_StoreId" });
            DropIndex("dbo.Product", new[] { "Code" });
            DropIndex("dbo.Papers", new[] { "Store_StoreId" });
            DropTable("dbo.Product");
            DropTable("dbo.Store");
            DropTable("dbo.Papers");
        }
    }
}
