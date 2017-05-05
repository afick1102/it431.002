namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedatabase : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Locations", new[] { "LocationImg" });
            AddColumn("dbo.Locations", "newColumn", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "newColumn");
            CreateIndex("dbo.Locations", "LocationImg", unique: true);
        }
    }
}
