namespace ITintheDWebsite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDBEntities : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Mentors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Info = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Mentors");
        }
    }
}
