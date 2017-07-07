namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToStoreTable : DbMigration
    {
        public override void Up()
        {
            //insert stores
            Sql("INSERT INTO STORE (Name,Address) VALUES('Store1','Lidio Ustares , Potosi, Bolivia')");
            Sql("INSERT INTO STORE (Name,Address) VALUES('Store2','Lidio Ustares , Cochabamba, Bolivia')");

            //Update Product Relations
            Sql("UPDATE PRODUCT SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store1') WHERE Code='G123'");
            Sql("UPDATE PRODUCT SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store1') WHERE Code='H123'");
            Sql("UPDATE PRODUCT SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store1') WHERE Code='I123'");

            //Update Product Relations
            Sql("UPDATE BOOK SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store2') WHERE Isbn='FSH4562FD'");
            Sql("UPDATE BOOK SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store2') WHERE Isbn='TREDL1234FD'");
            Sql("UPDATE BOOK SET Store_StoreId=(SELECT StoreId FROM Store WHERE Name='Store2') WHERE Isbn='PREDL1234FD'");
        }
        
        public override void Down()
        {
        }
    }
}
