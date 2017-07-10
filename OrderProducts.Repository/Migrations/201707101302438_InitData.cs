namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitData : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO STORE (Name,Address) VALUES('Store1','Potosi,Bolivia')");
            Sql("INSERT INTO STORE (Name,Address) VALUES('Store2','Cochabamba,Bolivia')");

            //books
            Sql("INSERT INTO PAPERS (Name,Author,Isbn,PaperType,Store_StoreId) VALUES('Harry Potter 1','JK ROWLING','A1234','1',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Name,Author,Isbn,PaperType,Store_StoreId) VALUES('Harry Potter 2','JK ROWLING','B1234','1',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Name,Author,Isbn,PaperType,Store_StoreId) VALUES('Harry Potter 3','JK ROWLING','C1234','1',(SELECT StoreId FROM STORE WHERE Name='Store1'))");

            //magazines
            Sql("INSERT INTO PAPERS (Title,Type,PaperType,Store_StoreId) VALUES('People and mode','2','2',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Title,Type,PaperType,Store_StoreId) VALUES('Natgeo','1','2',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Title,Type,PaperType,Store_StoreId) VALUES('Social Networs','1','2',(SELECT StoreId FROM STORE WHERE Name='Store1'))");

            //newspapers
            Sql("INSERT INTO PAPERS (Title,PublicationDate,PaperType,Store_StoreId) VALUES('El Potosi','20100301','3',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Title,PublicationDate,PaperType,Store_StoreId) VALUES('Newstime','20130301','3',(SELECT StoreId FROM STORE WHERE Name='Store1'))");
            Sql("INSERT INTO PAPERS (Title,PublicationDate,PaperType,Store_StoreId) VALUES('El Potosi','20170301','3',(SELECT StoreId FROM STORE WHERE Name='Store1'))");

            //products
            Sql("INSERT INTO PRODUCT (Code,Name,Stock,ExpirationDate,Abstract,Store_StoreId) VALUES('A123','Apple','1000','20180301','A123Apple',(SELECT StoreId FROM STORE WHERE Name='Store2'))");
            Sql("INSERT INTO PRODUCT (Code,Name,Stock,ExpirationDate,Abstract,Store_StoreId) VALUES('B123','Orange','1000','20190301','B123Orange',(SELECT StoreId FROM STORE WHERE Name='Store2'))");
            Sql("INSERT INTO PRODUCT (Code,Name,Stock,ExpirationDate,Abstract,Store_StoreId) VALUES('C123','Pinapple','1000','20170301','C123Pinapple',(SELECT StoreId FROM STORE WHERE Name='Store2'))");
        }
        
        public override void Down()
        {
        }
    }
}
