namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeActionToString : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Orders", "Action", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Orders", "Action", c => c.Int(nullable: false));
        }
    }
}
