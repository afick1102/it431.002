namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class POST_CHANGES : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Title", c => c.String());
            AlterColumn("dbo.Posts", "Author", c => c.String());
            AlterColumn("dbo.Posts", "Content", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Content", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Posts", "Author", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Posts", "Title", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
