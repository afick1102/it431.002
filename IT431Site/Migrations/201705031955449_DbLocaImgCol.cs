namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbLocaImgCol : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "LocationImg", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Locations", "LocationImg");
        }
    }
}
