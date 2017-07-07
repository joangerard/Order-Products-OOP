namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStoreClassAndDependencies : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Store",
                c => new
                    {
                        StoreId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.StoreId);
            
            AddColumn("dbo.Product", "Store_StoreId", c => c.Int());
            AddColumn("dbo.Book", "Store_StoreId", c => c.Int());
            CreateIndex("dbo.Product", "Store_StoreId");
            CreateIndex("dbo.Book", "Store_StoreId");
            AddForeignKey("dbo.Book", "Store_StoreId", "dbo.Store", "StoreId");
            AddForeignKey("dbo.Product", "Store_StoreId", "dbo.Store", "StoreId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Product", "Store_StoreId", "dbo.Store");
            DropForeignKey("dbo.Book", "Store_StoreId", "dbo.Store");
            DropIndex("dbo.Book", new[] { "Store_StoreId" });
            DropIndex("dbo.Product", new[] { "Store_StoreId" });
            DropColumn("dbo.Book", "Store_StoreId");
            DropColumn("dbo.Product", "Store_StoreId");
            DropTable("dbo.Store");
        }
    }
}
