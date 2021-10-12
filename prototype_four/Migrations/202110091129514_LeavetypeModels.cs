namespace prototype_four.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class LeavetypeModels : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into LeaveTypes(LeaveTypeName)Values('Sick Leave')");
            Sql("Insert into LeaveTypes(LeaveTypeName)Values('Casual Leave')");
            Sql("Insert into LeaveTypes(LeaveTypeName)Values('Compensatory Leave')");

        }

        public override void Down()
        {
        }
    }
}
