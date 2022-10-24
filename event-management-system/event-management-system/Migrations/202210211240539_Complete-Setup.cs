namespace event_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CompleteSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EventRevies",
                c => new
                    {
                        ReviewID = c.Int(nullable: false, identity: true),
                        EventID = c.Int(nullable: false),
                        Username = c.String(nullable: false),
                        Review = c.String(nullable: false),
                        ReviewDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ReviewID)
                .ForeignKey("dbo.EventStorages", t => t.EventID, cascadeDelete: true)
                .Index(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EventRevies", "EventID", "dbo.EventStorages");
            DropIndex("dbo.EventRevies", new[] { "EventID" });
            DropTable("dbo.EventRevies");
        }
    }
}
