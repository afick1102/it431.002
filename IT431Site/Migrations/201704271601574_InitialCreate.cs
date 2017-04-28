namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Locations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateOpen = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        LocationName = c.String(nullable: false, maxLength: 30),
                        LocationDescription = c.String(nullable: false, maxLength: 100),
                        LocationType = c.String(nullable: false),
                        AddBenefit = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Reservations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerName = c.String(nullable: false, maxLength: 30),
                        CustomerPhone = c.String(nullable: false),
                        CustomerEmail = c.String(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        TravelReason = c.String(nullable: false),
                        AdultNum = c.Int(nullable: false),
                        ChildrenNum = c.Int(nullable: false),
                        Request = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Widgets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Widgets");
            DropTable("dbo.Reservations");
            DropTable("dbo.Locations");
        }
    }
}
