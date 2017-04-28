namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbReservLocation : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Reservations", "Location", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Reservations", "Location");
        }
    }
}
