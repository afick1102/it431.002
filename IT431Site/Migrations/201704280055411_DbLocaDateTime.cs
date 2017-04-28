namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbLocaDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Locations", "DateOpen", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "DateClosed", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "AddBenefit", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Locations", "AddBenefit", c => c.String(nullable: false));
            AlterColumn("dbo.Locations", "DateClosed", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Locations", "DateOpen", c => c.DateTime(nullable: false));
        }
    }
}
