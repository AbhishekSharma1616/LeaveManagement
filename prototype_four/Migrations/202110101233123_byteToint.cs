namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class byteToint : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Leaves", "Checked", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Leaves", "Checked", c => c.Byte(nullable: false));
        }
    }
}
