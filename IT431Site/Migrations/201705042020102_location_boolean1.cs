namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location_boolean1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "HousekeepingAdded", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locations", "GymAdded", c => c.Boolean(nullable: false));
            AddColumn("dbo.Locations", "BreakfastAdded", c => c.Boolean(nullable: false));
            AlterColumn("dbo.Locations", "BenefitsAdded", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "BenefitsAdded", c => c.String(nullable: false));
            DropColumn("dbo.Locations", "BreakfastAdded");
            DropColumn("dbo.Locations", "GymAdded");
            DropColumn("dbo.Locations", "HousekeepingAdded");
        }
    }
}
