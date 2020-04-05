namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateAddUserRoles : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'97910cd0-2bf8-43e0-87b3-96a54381983c', N'7a7637a0-2031-47a1-8acf-d9fa923cf66d')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'b29774d4-48c3-49e1-9174-4ac94922cf9a', N'7a7637a0-2031-47a1-8acf-d9fa923cf66d')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'a7622542-e843-412e-8b33-af94ce4c5319', N'b21c5fd6-42ac-4147-be71-b10f855aa788')");
            Sql("INSERT INTO[dbo].[AspNetUserRoles]([UserId], [RoleId]) VALUES(N'd6fbf2f7-725a-4f9e-a3eb-33fd85e2f017', N'b21c5fd6-42ac-4147-be71-b10f855aa788')");

        }

    public override void Down()
        {
        }
    }
}
