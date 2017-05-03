namespace IT431Site.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DbNothing : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Posts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 50),
                        Author = c.String(nullable: false, maxLength: 50),
                        Content = c.String(nullable: false, maxLength: 100),
                        Date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Posts");
        }
    }
}
