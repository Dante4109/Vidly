namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Seedusers : DbMigration
    {
        public override void Up()
        {
        Sql(@"
        INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'6eaa2d0d-7f7f-4d86-be12-23be0a4a2ec3', N'Guest@gmail.com', 0, N'AETjY+yFFUV2y+NYuXMJOUdMozgduVMH+3WXzoZyvKDGt3M7SHlXLTFv4b83KvjRog==', N'33d32c12-6787-4102-bc4a-0edb3ea92649', NULL, 0, 0, NULL, 1, 0, N'Guest@gmail.com')
        INSERT INTO[dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES(N'72f6cdb4-c4d0-4fee-887d-5571fe9479db', N'Admin@gmail.com', 0, N'AA2l1MpUEkIWaGsd9fvzYXrs0Vi3D5/ceY06q7Mh1A9GW6O6yUvoKUJ2sF3U4jCmOA==', N'a7766dbc-a163-42cb-a6cc-19794817c179', NULL, 0, 0, NULL, 1, 0, N'Admin@gmail.com')
                
        INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'648fdb3c-62c5-4a36-89da-8912e75110f5', N'CanManageMovies')
        
        INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'72f6cdb4-c4d0-4fee-887d-5571fe9479db', N'648fdb3c-62c5-4a36-89da-8912e75110f5')
");           
        }

    public override void Down()
        {
        }
    }
}
