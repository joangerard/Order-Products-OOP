namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToProducts : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO PRODUCT (Code,Name,ExpirationDate,Stock) VALUES('G123','Cocacola','20201010',1000)");
            Sql("INSERT INTO PRODUCT (Code,Name,ExpirationDate,Stock) VALUES('H123','Fanta','20201011',2000)");
            Sql("INSERT INTO PRODUCT (Code,Name,ExpirationDate,Stock) VALUES('I123','Sprite','20201012',3000)");
        }
        
        public override void Down()
        {
        }
    }
}
