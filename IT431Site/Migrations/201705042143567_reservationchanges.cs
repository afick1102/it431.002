namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class reservationchanges : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Reservations", "Request");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reservations", "Request", c => c.String(maxLength: 100));
        }
    }
}
