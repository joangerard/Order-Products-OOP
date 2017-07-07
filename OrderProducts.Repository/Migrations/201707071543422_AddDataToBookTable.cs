namespace OrderProducts.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDataToBookTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO BOOK (Name,Author,Isbn) VALUES('Inferno','Dan Brown','FSH4562FD')");
            Sql("INSERT INTO BOOK (Name,Author,Isbn) VALUES('DaVinci Code','Dan Brown','TREDL1234FD')");
            Sql("INSERT INTO BOOK (Name,Author,Isbn) VALUES('The eye of the Dragon','Stephen King','PREDL1234FD')");
        }
        
        public override void Down()
        {
        }
    }
}
