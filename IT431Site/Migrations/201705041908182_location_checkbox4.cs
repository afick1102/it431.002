namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location_checkbox4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "BenefitsAdded", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "BenefitsAdded", c => c.Boolean(nullable: false));
        }
    }
}
