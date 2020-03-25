namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoriesTable : DbMigration
    {
        public override void Up()
        {
            Sql("insert into Categories values('Hot Drinks')");
            Sql("insert into Categories values('Cold Drinks')");
            Sql("insert into Categories values('Coffee')");
            Sql("insert into Categories values('Sandwitches')");
            Sql("insert into Categories values('Desserts')");
        }
        
        public override void Down()
        {
        }
    }
}
