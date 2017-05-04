namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locationImage2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.LocationImages", "FileName", c => c.String(maxLength: 100));
            CreateIndex("dbo.LocationImages", "FileName", unique: true);
        }
        
        public override void Down()
        {
            DropIndex("dbo.LocationImages", new[] { "FileName" });
            AlterColumn("dbo.LocationImages", "FileName", c => c.String());
        }
    }
}
