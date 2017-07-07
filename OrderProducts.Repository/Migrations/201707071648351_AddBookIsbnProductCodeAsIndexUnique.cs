namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBookIsbnProductCodeAsIndexUnique : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Product", "Code", c => c.String(maxLength: 20));
            AlterColumn("dbo.Book", "Isbn", c => c.String(maxLength: 20));
            CreateIndex("dbo.Product", "Code", unique: true);
            CreateIndex("dbo.Book", "Isbn", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Book", new[] { "Isbn" });
            DropIndex("dbo.Product", new[] { "Code" });
            AlterColumn("dbo.Book", "Isbn", c => c.String());
            AlterColumn("dbo.Product", "Code", c => c.String());
        }
    }
}
