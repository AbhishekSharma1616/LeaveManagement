namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedTaskTeam : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        TeamId = c.Int(nullable: false, identity: true),
                        TeamName = c.String(),
                    })
                .PrimaryKey(t => t.TeamId);
            
            AddColumn("dbo.Works", "MyProperty", c => c.Int(nullable: false));
            AddColumn("dbo.Works", "TeamId", c => c.Int(nullable: false));
            CreateIndex("dbo.Works", "TeamId");
            AddForeignKey("dbo.Works", "TeamId", "dbo.Teams", "TeamId", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Works", "TeamId", "dbo.Teams");
            DropIndex("dbo.Works", new[] { "TeamId" });
            DropColumn("dbo.Works", "TeamId");
            DropColumn("dbo.Works", "MyProperty");
            DropTable("dbo.Teams");
        }
    }
}
