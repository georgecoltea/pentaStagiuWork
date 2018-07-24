namespace MyWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostDateTimeFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "TimeOfPosting", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "TimeOfPosting", c => c.DateTime(nullable: false));
        }
    }
}
