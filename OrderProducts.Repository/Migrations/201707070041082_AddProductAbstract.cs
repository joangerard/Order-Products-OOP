namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddProductAbstract : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Product", "Abstract", c => c.String());
            Sql("UPDATE dbo.Product SET Abstract = Code+Name WHERE Abstract IS NULL");
        }
        
        public override void Down()
        {
            DropColumn("dbo.Product", "Abstract");
        }
    }
}
