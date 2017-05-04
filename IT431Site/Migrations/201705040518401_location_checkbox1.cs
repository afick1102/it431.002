namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class location_checkbox1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Locations", "AddedBenefits", c => c.String(nullable: false));
            DropColumn("dbo.Locations", "AddBenefit");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Locations", "AddBenefit", c => c.String());
            DropColumn("dbo.Locations", "AddedBenefits");
        }
    }
}
