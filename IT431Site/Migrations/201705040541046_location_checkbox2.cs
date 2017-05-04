namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location_checkbox2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "BenefitsAdded", c => c.Boolean(nullable: false));
            DropColumn("dbo.Locations", "AddedBenefits");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "AddedBenefits", c => c.String(nullable: false));
            DropColumn("dbo.Locations", "BenefitsAdded");
        }
    }
}
