namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbReservDateTime : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Reservations", "StartDate", c => c.String(nullable: false));
            AlterColumn("dbo.Reservations", "EndDate", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Reservations", "EndDate", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Reservations", "StartDate", c => c.DateTime(nullable: false));
        }
    }
}
