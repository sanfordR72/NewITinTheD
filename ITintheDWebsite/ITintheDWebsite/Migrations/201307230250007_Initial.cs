namespace ITintheDWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Email = c.String(nullable: false),
                        FirstName = c.String(nullable: false, maxLength: 16),
                        LastName = c.String(nullable: false, maxLength: 16),
                        HowYouHeard = c.String(nullable: false),
                        Role = c.String(nullable: false),
                        Question1 = c.String(nullable: false, maxLength: 200),
                        Question2 = c.String(nullable: false, maxLength: 200),
                        Question3 = c.String(nullable: false, maxLength: 200),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Applications");
        }
    }
}
