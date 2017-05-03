namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class newDateFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "LocationName", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Locations", "LocationDescription", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "LocationDescription", c => c.String(nullable: false, maxLength: 100));
            AlterColumn("dbo.Locations", "LocationName", c => c.String(nullable: false, maxLength: 30));
        }
    }
}
