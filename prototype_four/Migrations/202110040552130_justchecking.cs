namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class justchecking : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Works", "MyProperty");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Works", "MyProperty", c => c.Int(nullable: false));
        }
    }
}
