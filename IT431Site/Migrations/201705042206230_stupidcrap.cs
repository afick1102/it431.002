namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class stupidcrap : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "LocationImg", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Locations", "LocationImg", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.Locations", new[] { "LocationImg" });
            AlterColumn("dbo.Locations", "LocationImg", c => c.String(nullable: false));
        }
    }
}
