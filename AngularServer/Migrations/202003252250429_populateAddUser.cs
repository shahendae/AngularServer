namespace AngularServer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class populateAddUser : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'97910cd0-2bf8-43e0-87b3-96a54381983c', N'Abanob@gmail.com', 0, N'AGnoZnz5leLOpmVJejEhkEFjnAG4ejq7ov2jhPsxmVnzQN4AfQy9R9Zx+1fUxLeocA==', N'cde3fe15-e5c6-4d3a-9cc9-fbb7f054d81a', NULL, 0, 0, NULL, 0, 0, N'Abanob@gmail.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'a7622542-e843-412e-8b33-af94ce4c5319', N'Admin@admin.com', 0, N'AGBgmkcvzvhpz8GkqXWrgQIDdIS5+dhEUFXT7zhVhHdw1mXDUV1wsCYS97Nrzplj6Q==', N'31eb4f44-cc7f-4f22-ad52-5147519314e0', NULL, 0, 0, NULL, 0, 0, N'Admin@admin.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'b29774d4-48c3-49e1-9174-4ac94922cf9a', N'Mina@gmail.com', 0, N'AO/OL6MDrhNalIwbmbikqJcOadVOPV+CKlPEASahMBX7UyhiAUIF5hbTh1hAYShFMQ==', N'a9d03d12-de49-43f4-955d-6b612a384ff5', NULL, 0, 0, NULL, 0, 0, N'Mina@gmail.com')");
            Sql("INSERT INTO[dbo].[AspNetUsers]([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'd6fbf2f7-725a-4f9e-a3eb-33fd85e2f017', N'Manager@gmail.com', 0, N'AL0w311+DGVGdj8JxbUFkO+7dNu2iZryDWn+ngaTJFfRbMMQcOWEHqGS3kQESwcMIA==', N'42ee8359-6484-42a8-a625-b9cdd497ed75', NULL, 0, 0, NULL, 0, 0, N'Manager@gmail.com')");

        }

    public override void Down()
        {
        }
    }
}
