namespace event_management_system.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EventsCodesModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CodeStorages",
                c => new
                    {
                        Code = c.String(nullable: false, maxLength: 128),
                        CodeType = c.String(nullable: false),
                        Username = c.String(),
                    })
                .PrimaryKey(t => t.Code);
            
            CreateTable(
                "dbo.EventStorages",
                c => new
                    {
                        EventID = c.Int(nullable: false, identity: true),
                        EventType = c.String(nullable: false),
                        EventName = c.String(nullable: false),
                        EventDate = c.DateTime(nullable: false),
                        EventDescription = c.String(nullable: false),
                        EventTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EventID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EventStorages");
            DropTable("dbo.CodeStorages");
        }
    }
}
