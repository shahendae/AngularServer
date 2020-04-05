namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateAddRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'b21c5fd6-42ac-4147-be71-b10f855aa788', N'Admin')");
            Sql("INSERT INTO[dbo].[AspNetRoles]([Id], [Name]) VALUES(N'7a7637a0-2031-47a1-8acf-d9fa923cf66d', N'User')");

        }

    public override void Down()
        {
        }
    }
}
