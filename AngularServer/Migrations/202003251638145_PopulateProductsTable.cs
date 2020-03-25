namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateProductsTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Tea', 1, 200, 10)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Hot Chocolate', 1, 150, 30)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Green Tea', 1, 100, 15)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Ice Mocha', 2, 200, 40)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Mango', 2, 200, 50)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Espresso', 3, 200, 25)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Mocha', 3, 150, 30)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Americano', 3, 100, 35)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Burger', 4, 200, 80)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('Seafood', 4, 200, 100)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('CupCake', 5, 80, 50)");
            Sql("insert into Products(ProductName, CategoryId, Quantity, Price) values ('CheeseCake', 5, 100, 60)");
        }
        
        public override void Down()
        {
        }
    }
}
