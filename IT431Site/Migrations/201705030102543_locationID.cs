namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locationID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "LocationID", c => c.Int(nullable: false));
            CreateIndex("dbo.Reservations", "LocationID");
            AddForeignKey("dbo.Reservations", "LocationID", "dbo.Locations", "Id", cascadeDelete: true);
            DropColumn("dbo.Reservations", "Location");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Location", c => c.String(nullable: false));
            DropForeignKey("dbo.Reservations", "LocationID", "dbo.Locations");
            DropIndex("dbo.Reservations", new[] { "LocationID" });
            DropColumn("dbo.Reservations", "LocationID");
        }
    }
}
