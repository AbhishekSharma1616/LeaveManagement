namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedLeaveModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Leaves",
                c => new
                    {
                        LeaveId = c.Int(nullable: false, identity: true),
                        LeaveDescription = c.String(),
                        fromTo = c.String(),
                        Useremail = c.String(),
                        Checked = c.Byte(nullable: false),
                        LeaveTypeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.LeaveId)
                .ForeignKey("dbo.LeaveTypes", t => t.LeaveTypeId, cascadeDelete: true)
                .Index(t => t.LeaveTypeId);
            
            CreateTable(
                "dbo.LeaveTypes",
                c => new
                    {
                        LeaveTypeId = c.Int(nullable: false, identity: true),
                        LeaveTypeName = c.String(),
                    })
                .PrimaryKey(t => t.LeaveTypeId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Leaves", "LeaveTypeId", "dbo.LeaveTypes");
            DropIndex("dbo.Leaves", new[] { "LeaveTypeId" });
            DropTable("dbo.LeaveTypes");
            DropTable("dbo.Leaves");
        }
    }
}
