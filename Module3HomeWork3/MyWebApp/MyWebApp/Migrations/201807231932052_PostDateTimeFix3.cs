namespace MyWebApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PostDateTimeFix3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "TimeOfPosting", c => c.DateTime(nullable: false, precision: 7, storeType: "datetime2"));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "TimeOfPosting", c => c.DateTime(precision: 7, storeType: "datetime2"));
        }
    }
}
