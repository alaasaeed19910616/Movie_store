namespace Movie_store.Migrations
{
    using System;
    using System.Data.Entity.Migrations;

    public partial class SeedUswers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'f5ece9d2-8531-497b-bd55-6f54b1268243', N'guest@example.com', 0, N'ACysNJNU4C3vaBLQnUckzb+grMV6ZmqBXtQeEuUzxPx8ZucTJCW/+Pe3irQe3x4ldg==', N'8579153e-b662-4ba2-ac14-aa671398bc0d', NULL, 0, 0, NULL, 1, 0, N'guest@example.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ff26d91d-4170-4f28-9d14-05f1baaad135', N'admin@moviestore.com', 0, N'AOpnCMTqhPNnjnxb9sLrP6v5lZ5LOfVEd6wRrUeWqfnY0QZkXdFA9R631rtbhNmPSA==', N'7db21f1c-d084-4713-872d-725c96b2988f', NULL, 0, 0, NULL, 1, 0, N'admin@moviestore.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'26bdb038-3bd7-46ac-8388-8f9cdbd495f5', N'CanManageMovie')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ff26d91d-4170-4f28-9d14-05f1baaad135', N'26bdb038-3bd7-46ac-8388-8f9cdbd495f5')
");
        }

        public override void Down()
        {
        }
    }
}
