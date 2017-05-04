namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IDC2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.LocationImages", new[] { "FileName" });
            DropIndex("dbo.Locations", new[] { "LocationImg" });
            AlterColumn("dbo.Locations", "LocationImg", c => c.String(nullable: false));
            DropTable("dbo.LocationImages");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.LocationImages",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FileName = c.String(maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            AlterColumn("dbo.Locations", "LocationImg", c => c.String(nullable: false, maxLength: 100));
            CreateIndex("dbo.Locations", "LocationImg", unique: true);
            CreateIndex("dbo.LocationImages", "FileName", unique: true);
        }
    }
}
